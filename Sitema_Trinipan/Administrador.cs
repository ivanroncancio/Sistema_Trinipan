using LibreriaDLL;
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

namespace Sitema_Trinipan
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

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
    }
}
