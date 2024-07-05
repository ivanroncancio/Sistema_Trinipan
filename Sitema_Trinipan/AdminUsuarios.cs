using LibreriaDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sitema_Trinipan
{
    public partial class AdminUsuarios : Form
    {
        public AdminUsuarios()
        {
            InitializeComponent();
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);






        SqlConnection conexion = new SqlConnection("Data Source=IVAN\\SQLEXPRES;Initial Catalog=Sistema_Trinipan;Integrated Security=True;Encrypt=False");
        
        public static int validar = 0;
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            if (Biblioteca.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    if (TexBox_Contrasena.Text == TexBox_ConfiContrasena.Text)
                    {
                        if (radioButton2.Checked == true || radioButton1.Checked == true)
                        {

                            if (radioButton1.Checked == true)
                            {
                                validar = 1;
                            }
                            else if (radioButton2.Checked == true) 
                            {
                                validar = 0;
                            }


                            MemoryStream ms = new MemoryStream();
                            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                            byte[] data = ms.ToArray();

                            
                            string consulta = "insert into Usuarios values(" + TexBox_id.Text + ",'" + TexBox_Nombre.Text + "','" + TexBox_Cuenta.Text + "','" + TexBox_Contrasena.Text + "'," + validar + ",@imagen)";
                            SqlCommand cmd = new SqlCommand(consulta, conexion);
                            cmd.Parameters.AddWithValue("imagen", data);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Se ha guardado el nuevo usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);

                            conexion.Close();

                            TexBox_Nombre.Text = "";
                            TexBox_Cuenta.Text = "";
                            TexBox_id.Text = "";
                            TexBox_Contrasena.Text = "";
                            TexBox_ConfiContrasena.Text = "";
                            TexBox_Correo.Text = "";

                            radioButton1.Checked = false;
                            radioButton2 .Checked = false;

                            TexBox_id.Focus();

                        }
                        else
                        {
                            MessageBox.Show("Selecciona el rol de usuario");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("¡Las contraseñas no coniciden!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("el nuemro "+ TexBox_id.Text + " de identificación ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();

                    TexBox_Nombre.Text = "";
                    TexBox_Cuenta.Text = "";
                    TexBox_id.Text = "";
                    TexBox_Contrasena.Text = "";
                    TexBox_ConfiContrasena.Text = "";
                    TexBox_Correo.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                    TexBox_id.Focus();
                }


            }
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog foto = new OpenFileDialog();
                DialogResult rs = foto.ShowDialog();

                if (rs == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(foto.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Sole se aceptan imagenes");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            string validar = "Select * from Usuarios where id_usuarios = " + Login.codigo;
            DataSet ds = Biblioteca.Herramientas(validar);

            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Validar_usuario"].ToString()) == true)
            {
                Administrador administrador = new Administrador();
                administrador.Show();
            }

        }

        private void errorTexBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var salir = MessageBox.Show("¿Desea salir de la aplicacion?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AdminUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
