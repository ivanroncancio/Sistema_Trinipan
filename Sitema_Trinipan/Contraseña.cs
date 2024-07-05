using LibreriaDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sitema_Trinipan
{
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }




        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);




        private void button1_Click(object sender, EventArgs e)
        {
            if (Biblioteca.ValidarFormulario(this, errorProvider1) == false )
            {
                string validar = "Select * From Usuarios where id_usuarios = " + Login.codigo;

                DataSet ds = Biblioteca.Herramientas(validar);

                string contrasena = ds.Tables[0].Rows[0]["Contrasena_usuario"].ToString();

                string id = ds.Tables[0].Rows[0]["id_usuarios"].ToString();
                

                if (contrasena == TexBox_PasswordActual.Text)
                {
                    BasesDatos.Connection();
                    string actuali = "update Usuarios set Contrasena_usuario=@Contrasena where id_usuarios=@id_usuarios ";
                    SqlCommand update = new SqlCommand(actuali, BasesDatos.Connection());

                    if (TexBox2_NuevaPassword.Text == TexBox_NuevaPassword_2.Text)
                    {
                        update.Parameters.AddWithValue("@Contrasena", TexBox2_NuevaPassword.Text);
                        update.Parameters.AddWithValue("@id_usuarios",id);
                        update.ExecuteNonQuery();

                        MessageBox.Show("¡Actualización exitosa!");

                        this.Close();
                        ActualizacionDeDatos actualizacionDeDatos = new ActualizacionDeDatos();
                        actualizacionDeDatos.Show();
                    }
                    else
                    {
                        MessageBox.Show("¡Las nuevas contraseñas no coinciden!");
                    }
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!");
                }

            }
            
        }

        private void TexBox_PasswordActual_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  
        }

        private void Contraseña_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualizacionDeDatos actualizacionDeDatos = new ActualizacionDeDatos();
            actualizacionDeDatos.Show();
        }
    }
}
