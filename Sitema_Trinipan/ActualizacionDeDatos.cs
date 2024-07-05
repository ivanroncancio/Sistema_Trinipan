using LibreriaDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Sitema_Trinipan
{
    public partial class ActualizacionDeDatos : Form
    {
        public ActualizacionDeDatos()
        {
            InitializeComponent();
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);





        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var cerrar = MessageBox.Show("¿Desea cerrar la aplicacion?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if ( cerrar == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        public byte[] imagenBite { get;set; }

        private void ActualizacionDeDatos_Load(object sender, EventArgs e)
        {
            string validar = "Select * From Usuarios where id_usuarios = " + Login.codigo;
            DataSet ds = Biblioteca.Herramientas(validar);

            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["validar_usuario"].ToString()) == true)
            {
                lbl_Rol.Text = "Administrador";
                TexBox_NombreUsuario.Text = ds.Tables[0].Rows[0]["Nombre_usuarios"].ToString().Trim();
                TexBox_CuentaUsuario.Text = ds.Tables[0].Rows[0]["Cuenta_usuario"].ToString().Trim();
                TexBox_CodigoUsuario.Text = ds.Tables[0].Rows[0]["id_usuarios"].ToString().Trim();

                imagenBite = (byte[])ds.Tables[0].Rows[0]["imagen"];

                using(MemoryStream ms = new MemoryStream(imagenBite))
                {
                    pictureBox2.Image = Image.FromStream(ms);
                }


            }
            else
            {
                lbl_Rol.Text = "Usuario";
                TexBox_NombreUsuario.Text = ds.Tables[0].Rows[0]["Nombre_usuarios"].ToString().Trim();
                TexBox_CuentaUsuario.Text = ds.Tables[0].Rows[0]["Cuenta_usuario"].ToString().Trim();
                TexBox_CodigoUsuario.Text = ds.Tables[0].Rows[0]["id_usuarios"].ToString().Trim();

                byte[] imagenn = (byte[])ds.Tables[0].Rows[0]["imagen"];
                using(MemoryStream ms = new MemoryStream(imagenn))
                {
                    pictureBox2.Image = Image.FromStream(ms);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BasesDatos.Connection();
            
            try
            {
                
                string actualizar = "update Usuarios set Nombre_usuarios=@NombreUsuarios, Cuenta_usuario=@cuentaUsuario where id_usuarios=@idUsuarios";
                SqlCommand actualiza = new SqlCommand(actualizar, BasesDatos.Connection());

                actualiza.Parameters.AddWithValue("@NombreUsuarios", TexBox_NombreUsuario.Text);
                actualiza.Parameters.AddWithValue("@cuentaUsuario", TexBox_CuentaUsuario.Text);
                actualiza.Parameters.AddWithValue("@idUsuarios", TexBox_CodigoUsuario.Text);
                               

                actualiza.ExecuteNonQuery();

                MessageBox.Show("Datos actualizados");


                string validar = "Select * From Usuarios where id_usuarios = " + Login.codigo;
                DataSet ds = Biblioteca.Herramientas(validar);

                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["validar_usuario"].ToString()) == true)
                {
                    lbl_Rol.Text = "Administrador";
                    TexBox_NombreUsuario.Text = ds.Tables[0].Rows[0]["Nombre_usuarios"].ToString().Trim();
                    TexBox_CuentaUsuario.Text = ds.Tables[0].Rows[0]["Cuenta_usuario"].ToString().Trim();
                    TexBox_CodigoUsuario.Text = ds.Tables[0].Rows[0]["id_usuarios"].ToString().Trim();

                }
                else
                {
                    lbl_Rol.Text = "Usuario";
                    TexBox_NombreUsuario.Text = ds.Tables[0].Rows[0]["Nombre_usuarios"].ToString().Trim();
                    TexBox_CuentaUsuario.Text = ds.Tables[0].Rows[0]["Cuenta_usuario"].ToString().Trim();
                    TexBox_CodigoUsuario.Text = ds.Tables[0].Rows[0]["id_usuarios"].ToString().Trim();
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("No se realizaron cambios");
            }
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            CambiarFoto cambiarFoto = new CambiarFoto();
            cambiarFoto.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            string validar = "Select * from Usuarios where id_usuarios = " + Login.codigo;
            DataSet ds = Biblioteca.Herramientas(validar);

            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["validar_usuario"].ToString()) == true)
            {
                Administrador administrador = new Administrador();
                administrador.Show();
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.Show();
            }

            
        }

        private void ActualizacionDeDatos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contraseña contraseña = new Contraseña();
            this.Close();
            contraseña.Show();
        }
    }
}
