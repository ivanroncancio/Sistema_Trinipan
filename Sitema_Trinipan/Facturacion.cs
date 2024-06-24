using LibreriaDLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sitema_Trinipan
{
    public partial class Facturacion : Procesos 
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where id_usuarios = " + Login.codigo;
            DataSet ds = Biblioteca.Herramientas(cmd);
            lbl_vendedor.Text = ds.Tables[0].Rows[0]["Nombre_usuarios"].ToString();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TexBox_CodigoCliente.Text.Trim()) == false)
                {
                    string cmd = string.Format("Select * from Clientes ", TexBox_CodigoCliente.Text.Trim());
                    DataSet ds = Biblioteca.Herramientas(cmd);

                    TexBox_NombreCliente.Text = ds.Tables[0].Rows[0]["Nombre_cliente"].ToString();

                    TexBox_CodigoArticulo.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message);
            }
            
        }

        public static int contadorFila = 0;
        public static double total;

        private void btn_Colocar_Click(object sender, EventArgs e)
        {
            if (Biblioteca.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int NumeroFila = 0;

                if (contadorFila == 0)
                {
                    dataGridView1.Rows.Add(TexBox_CodigoArticulo.Text.Trim(), TexBox_DescripcionArticulo.Text.Trim(), TexBox_PrecioArticulo.Text.Trim(), TexBox_CantidadArticulo.Text.Trim());
                    double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                    dataGridView1.Rows[contadorFila].Cells[4].Value = importe;
                    
                    contadorFila++;

                }
                else
                {
                    foreach (DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == TexBox_CodigoArticulo.Text.Trim())
                        {
                            existe = true;
                            NumeroFila = Fila.Index;

                            

                        }
                        
                    }

                    if (existe == true)
                    {
                        dataGridView1.Rows[NumeroFila].Cells[3].Value = (Convert.ToDouble(TexBox_CantidadArticulo.Text) + Convert.ToDouble(dataGridView1.Rows[NumeroFila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[NumeroFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[NumeroFila].Cells[3].Value);
                        dataGridView1.Rows[NumeroFila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(TexBox_CodigoArticulo.Text.Trim(), TexBox_DescripcionArticulo.Text.Trim(), TexBox_PrecioArticulo.Text.Trim(), TexBox_CantidadArticulo.Text.Trim());
                        double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                        dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                        contadorFila++;
                    }



                }

                total = 0;
                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);
                    
                }
                lbl_Total.Text = "$ " + total.ToString();

            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (contadorFila >  0)
            {
                total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lbl_Total.Text = "$ " + total.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);    

                contadorFila--;

            }
            
        }

        private void TexBox_CodigoCliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            ConsultasClientes consultasClientes = new ConsultasClientes();
            consultasClientes.ShowDialog();

            if (consultasClientes.DialogResult == DialogResult.OK)
            {
                TexBox_CodigoCliente.Text = consultasClientes.dataGridView1.Rows[consultasClientes.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TexBox_NombreCliente.Text = consultasClientes.dataGridView1.Rows[consultasClientes.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                TexBox_CodigoArticulo.Focus();
            }
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            ConsultasProductos consultasProductos = new ConsultasProductos();
            consultasProductos.ShowDialog();

            if(consultasProductos.DialogResult == DialogResult.OK)
            {
                TexBox_CodigoArticulo.Text = consultasProductos.dataGridView1.Rows[consultasProductos.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TexBox_DescripcionArticulo.Text = consultasProductos.dataGridView1.Rows[consultasProductos.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                TexBox_PrecioArticulo.Text = consultasProductos.dataGridView1.Rows[consultasProductos.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                TexBox_CantidadArticulo.Focus();
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        public override void Nuevo()
        {
            TexBox_CodigoCliente.Text = "";
            TexBox_NombreCliente.Text = "";
            TexBox_CodigoArticulo.Text = "";
            TexBox_DescripcionArticulo.Text = "";
            TexBox_PrecioArticulo.Text = "";
            TexBox_CantidadArticulo.Text = "";

            dataGridView1.Rows.Clear();
            lbl_Total.Text = "$ 0";
            contadorFila = 0;
            total = 0;

            TexBox_CodigoCliente.Focus();

        }

        private void bnt_Facturar_Click(object sender, EventArgs e)
        {
            if (contadorFila != 0)
            {
                string cmd = string.Format("Exec ActualizarFacturas '{0}' ", TexBox_CodigoCliente.Text.Trim());
                DataSet ds = Biblioteca.Herramientas(cmd);

                string NumeroFactura = ds.Tables[0].Rows[0]["NumeroFactura"].ToString().Trim();

                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    cmd = string.Format("Exec ActualizarDetalles '{0}','{1}','{2}','{3}' ", NumeroFactura, Fila.Cells[0].Value.ToString(), Fila.Cells[2].Value.ToString(), Fila.Cells[3].Value.ToString());

                    ds = Biblioteca.Herramientas(cmd);
                }

                cmd = "Exec DatosFactura " + NumeroFactura;

                ds = Biblioteca.Herramientas(cmd);

                Factura factura = new Factura();

                factura.reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]); 
                factura.reportViewer1.LocalReport.DataSources.Add(rds);
                
                factura.reportViewer1.RefreshReport();

                factura.ShowDialog();
                
            }
        }
    }
}
