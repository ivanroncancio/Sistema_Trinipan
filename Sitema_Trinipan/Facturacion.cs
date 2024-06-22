using LibreriaDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sitema_Trinipan
{
    public partial class Facturacion : Procesos 
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where id_usuarios = " + Login.codigo;
            DataSet ds = Biblioteca.Herramientas(cmd);
            lbl_vendedor.Text = ds.Tables[0].Rows[0]["Nombre_usuarios"].ToString();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TexBox_CodigoCliente.Text.Trim()) == false)
            {
                string cmd = string.Format("Select * from Clientes ", TexBox_CodigoCliente.Text.Trim());
                DataSet ds = Biblioteca.Herramientas(cmd);

                TexBox_NombreCliente.Text = ds.Tables[0].Rows[0]["Nombre_cliente"].ToString();


            }
        }
    }
}
