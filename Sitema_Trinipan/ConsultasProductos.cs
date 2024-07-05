using LibreriaDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sitema_Trinipan
{
    public partial class ConsultasProductos : Form
    {
        public ConsultasProductos()
        {
            InitializeComponent();
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);




        private void ConsultasProductos_Load(object sender, EventArgs e)
        {
            string consulta = string.Format("Select * from Articulos ");
            DataSet ds = Biblioteca.Herramientas(consulta);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta = string.Format("Select * from Articulos ");
            DataSet ds = Biblioteca.Herramientas(consulta);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string consulta = string.Format("Select * from Articulos where Nombre_producto like ('%" +TexBox1.Text.Trim() +"%')");
            DataSet ds = Biblioteca.Herramientas(consulta);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();

            //if(dataGridView1.Rows.Count == 0)
            //{
            //    return;
            //}
            //else
            //{
            //}

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ConsultasProductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
