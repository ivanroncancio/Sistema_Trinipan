using LibreriaDLL;
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

namespace Sitema_Trinipan
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);


        private void Administrador_Load(object sender, EventArgs e)
        {
            string id_Consulta = "Select * FROM Usuarios WHERE id_usuarios = " + Login.codigo;

            DataSet dataSet = Biblioteca.Herramientas(id_Consulta);

            lbl_Nombre.Text = dataSet.Tables[0].Rows[0]["Nombre_usuarios"].ToString();
            Lbl_Cuenta.Text = dataSet.Tables[0].Rows[0]["Cuenta_usuario"].ToString();
            Lbl_Codigo.Text = dataSet.Tables[0].Rows[0]["id_usuarios"].ToString();

            
            
            byte[] imagenBytes = (byte[])dataSet.Tables[0].Rows[0]["imagen"];

            
            using (MemoryStream ms = new MemoryStream(imagenBytes))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void btn_Principal_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal principal = new ContenedorPrincipal();
            this.Hide();
            principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUsuarios adminUsuarios = new AdminUsuarios();
            adminUsuarios.Show();
            

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var salir = MessageBox.Show("¿Desea salir de aplicación?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Administrador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bnt_ActualizarDatos_Click(object sender, EventArgs e)
        {
            ActualizacionDeDatos actualizacionDeDatos = new ActualizacionDeDatos();
            this.Hide();
            actualizacionDeDatos.Show();    
        }
    }
}
