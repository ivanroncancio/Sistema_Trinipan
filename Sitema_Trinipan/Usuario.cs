using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL;

namespace Sitema_Trinipan
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);


        private void Usuario_Load(object sender, EventArgs e)
        {
            string validar = "Select * from Usuarios where id_usuarios = " + Login.codigo;
            DataSet ds = Biblioteca.Herramientas(validar);

            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["validar_usuario"].ToString()) == false)
            {
                lbl_Nombre.Text = ds.Tables[0].Rows[0]["Nombre_usuarios"].ToString();
                Lbl_Cuenta.Text = ds.Tables[0].Rows[0]["Cuenta_usuario"].ToString();
                Lbl_Codigo.Text = ds.Tables[0].Rows[0]["id_usuarios"].ToString();

                byte[] image = (byte[])ds.Tables[0].Rows[0]["imagen"];

                using (MemoryStream ms = new MemoryStream(image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }

            }

            

        }

        private void btn_Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContenedorPrincipal principal = new ContenedorPrincipal();
            principal.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var salir = MessageBox.Show("¿Desea salir de la aplicacion?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Usuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ActualizarDatos_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualizacionDeDatos actualizacionDeDatos = new ActualizacionDeDatos();
            actualizacionDeDatos.Show();
        }
    }
}
