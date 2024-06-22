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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sitema_Trinipan
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=IVAN\\SQLEXPRES;Initial Catalog=Sistema_Trinipan;Integrated Security=True;Encrypt=False");


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if(Biblioteca.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    if (TexBox_Contrasena.Text == TexBox_ConfiContrasena.Text)
                    {
                        int validar = 1;
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] data = ms.ToArray();

                        conexion.Open();
                        string consulta = "insert into Usuarios values(" + TexBox_id.Text + ",'" + TexBox_Nombre.Text + "','" + TexBox_Cuenta.Text + "','" + TexBox_Contrasena.Text + "'," + validar + ",@imagen)";
                        SqlCommand cmd = new SqlCommand(consulta, conexion);
                        cmd.Parameters.AddWithValue("imagen", data);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se ha guardado el administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);

                        conexion.Close();

                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("¡Las contraseñas no coniciden!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();

            if (rs == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(foto.FileName);
            }
        }
    }
}
