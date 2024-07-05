using LibreriaDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sitema_Trinipan
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }
        public int Contador = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);


        private void Ventas_Load(object sender, EventArgs e)
        {
            
            string consulta = string.Format("Select * From Facturas ORDER BY NumeroFactura ASC");
            DataSet consultas = Biblioteca.Herramientas(consulta);

            string consultar = string.Format("Select * From Facturas ORDER BY NumeroFactura DESC");
            DataSet consultass = Biblioteca.Herramientas(consultar);

            lbl_ventas.Text = consultass.Tables[0].Rows[0]["NumeroFactura"].ToString();
            
            dataGridView1.DataSource = consultas.Tables[0];
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio, fechaFin;
            if (DateTime.TryParse(textBox1.Text.Trim(), out fechaInicio) && DateTime.TryParse(textBox2.Text.Trim(), out fechaFin))
            {
                // Asegurarse de que la fecha de inicio sea anterior o igual a la fecha de fin
                if (fechaInicio <= fechaFin )
                {
                    fechaFin = fechaFin.AddDays(1);
                    string buscar = string.Format("SELECT * FROM Facturas WHERE FechaFactura >='{0:yyyy-MM-dd}' and FechaFactura <='{1:yyyy-MM-dd}'", fechaInicio, fechaFin);

                    DataSet ds = Biblioteca.Herramientas(buscar);
                    dataGridView1.DataSource = ds.Tables[0];

                    int totalFilas = dataGridView1.RowCount;

                    lbl_ventas.Text = totalFilas.ToString();
                }                
                else
                {
                    MessageBox.Show("La fecha de inicio debe ser anterior o igual a la fecha final.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese fechas válidas.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta = string.Format("Select * From Facturas ORDER BY NumeroFactura ASC");
            DataSet consultas = Biblioteca.Herramientas(consulta);
            dataGridView1.DataSource = consultas.Tables[0];

            int totalFilas = dataGridView1.RowCount;

            lbl_ventas.Text = totalFilas.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ventas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private List<Datos> datos = new List<Datos>();
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            Contador = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Datos dat = new Datos();
                dat.numeroFactura = dataGridView1.Rows[i].Cells[0].Value.ToString();
                dat.fechaFactura = dataGridView1.Rows[i].Cells[1].Value.ToString();
                dat.codigoCliente = dataGridView1.Rows[i].Cells[2].Value.ToString();

                datos.Add(dat);
                Contador++;
            }
            ReporteVentas reporteVentas = new ReporteVentas();
            reporteVentas.reportViewer_ventas.LocalReport.DataSources.Clear();
            reporteVentas.reportViewer_ventas.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2",datos));
            reporteVentas.reportViewer_ventas.RefreshReport();

            Datos dt = new Datos();
            dt.contador = Contador.ToString();
            datos.Add(dt);

            reporteVentas.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");
        }
    }
}
