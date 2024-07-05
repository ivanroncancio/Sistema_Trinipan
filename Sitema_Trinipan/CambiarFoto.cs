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
    public partial class CambiarFoto : Form
    {
        public CambiarFoto()
        {
            InitializeComponent();
        }




        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);





        private byte[] imagenBit { get; set; }
        private byte[] dataFoto { get; set; }    

        private void CambiarFoto_Load(object sender, EventArgs e)
        {
            string validar = "Select * From Usuarios where id_usuarios = " + Login.codigo;
            DataSet ds = Biblioteca.Herramientas(validar);

            imagenBit = (byte[])ds.Tables[0].Rows[0]["imagen"];
            dataFoto = imagenBit;

            using (MemoryStream ms = new MemoryStream(imagenBit))
            {
                pictureBox3.Image = Image.FromStream(ms);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            

            if (imagenBit != dataFoto)
            {
                string validar = "Select * From Usuarios where id_usuarios = " + Login.codigo;
                DataSet ds = Biblioteca.Herramientas(validar);
                string id = ds.Tables[0].Rows[0]["id_usuarios"].ToString();

                BasesDatos.Connection();                
                string actualizar = "update Usuarios set imagen=@imagen where id_usuarios=@idUsuarios";
                SqlCommand actualiza = new SqlCommand(actualizar, BasesDatos.Connection());
                actualiza.Parameters.AddWithValue("@imagen",imagenBit);
                actualiza.Parameters.AddWithValue("@idUsuarios",id);
                actualiza.ExecuteNonQuery();
                MessageBox.Show("Actualizacion exitosa");

                this.Close();
                ActualizacionDeDatos actualizacionDeDatos = new ActualizacionDeDatos();
                actualizacionDeDatos.Show();
            }
            else
            {
                MessageBox.Show("las imagenes son Iguales");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();

            if (rs == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(foto.FileName);
                MemoryStream ms = new MemoryStream();
                pictureBox3.Image.Save(ms, ImageFormat.Jpeg);
                imagenBit = ms.ToArray();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualizacionDeDatos actualizacionDeDatos = new ActualizacionDeDatos();
            actualizacionDeDatos.Show();

        }

        private void CambiarFoto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
