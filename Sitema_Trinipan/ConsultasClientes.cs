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
    public partial class ConsultasClientes : Consultas
    { 
        public ConsultasClientes()
        {
            InitializeComponent();
        }

        private void ConsultasClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarInformacio("Clientes").Tables[0];
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;
                    string buscar = "Select * from Articulos WHERE Nombre_producto LIKE ('%" + textBox1.Text.Trim() + "%') ";
                    ds = Biblioteca.Herramientas(buscar);

                    dataGridView1.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Articulo no encontrado, Error: " + ex.Message);
                }
            }
        }
    }
}
