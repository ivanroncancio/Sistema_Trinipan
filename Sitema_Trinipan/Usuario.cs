using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private void Usuario_Load(object sender, EventArgs e)
        {
            string validar = "Select * from Usuarios where id_usuarios = " + Login.codigo;
            DataSet ds = Biblioteca.Herramientas(validar);

            lbl_Nombre.Text = ds.Tables[0].Rows[0]["Nombre_usuarios"].ToString();
            Lbl_Cuenta.Text = ds.Tables[0].Rows[0]["Cuenta_usuario"].ToString();
            Lbl_Codigo.Text = ds.Tables[0].Rows[0]["id_usuarios"].ToString();

            byte[] image = (byte[])ds.Tables[0].Rows[0]["imagen"];

            using(MemoryStream ms = new MemoryStream(image))
            {
                pictureBox1.Image = Image.FromStream(ms); 
            }

        }

        private void btn_Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContenedorPrincipal principal = new ContenedorPrincipal();
            principal.Show();
        }
    }
}
