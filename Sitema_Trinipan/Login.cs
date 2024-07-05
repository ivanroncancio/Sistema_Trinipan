using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL;
using System.Runtime.InteropServices;

namespace Sitema_Trinipan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public static string codigo;

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string validar = string.Format("Select * from Usuarios where Cuenta_usuario = '{0}' and Contrasena_usuario = '{1}' ", textBox_CuentaUsuario.Text.Trim(), textBox_Contrasena.Text.Trim());
                DataSet sd = Biblioteca.Herramientas(validar);
                string cuenta = sd.Tables[0].Rows[0]["Cuenta_usuario"].ToString().Trim();
                string contrasena = sd.Tables[0].Rows[0]["Contrasena_usuario"].ToString().Trim();

                codigo = sd.Tables[0].Rows[0]["id_usuarios"].ToString().Trim();

                if (Convert.ToBoolean(sd.Tables[0].Rows[0]["Validar_usuario"].ToString().Trim()))
                {
                    this.Hide();
                    Administrador administrador = new Administrador();
                    administrador.Show();
                }
                else
                {
                    this.Close();
                    Usuario usuario = new Usuario();
                    usuario.Show();
                }

            }
            catch
            {
                MessageBox.Show("Usuario Incorrecto ");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var cerrar = MessageBox.Show("Estas seguro que deseas cerrar la ventana","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cerrar == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox_Contrasena_Leave(object sender, EventArgs e)
        {
            textBox_Contrasena.UseSystemPasswordChar = true;
        }

        private void textBox_Contrasena_Enter(object sender, EventArgs e)
        {
            textBox_Contrasena.UseSystemPasswordChar = true;
        }
    }
}
