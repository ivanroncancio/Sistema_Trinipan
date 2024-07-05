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

namespace Sitema_Trinipan
{
    public partial class ConsultasClientes : Form
    {
        public ConsultasClientes()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);



        private void ConsultasClientes_Load(object sender, EventArgs e)
        {
            string consulta = string.Format("Select * from Clientes ");
            DataSet ds = Biblioteca.Herramientas(consulta);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string buscar = string.Format("Select * from Clientes where id_clientes like ('%" + TexBox1.Text.Trim() + "%')");
            DataSet ds = Biblioteca.Herramientas(buscar);
            dataGridView1.DataSource= ds.Tables[0];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string consulta = string.Format("Select * from Clientes ");
            DataSet ds = Biblioteca.Herramientas(consulta);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ConsultasClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
