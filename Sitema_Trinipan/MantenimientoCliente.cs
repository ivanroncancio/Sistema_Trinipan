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
    public partial class MantenimientoCliente : Mantenimiento   
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            ConsultasClientes consultasClientes = new ConsultasClientes();
            consultasClientes.Show();
        }
        public override Boolean Guardar()
        {
            if (Biblioteca.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string inserta = string.Format("EXEC ActualizarClientes '{0}','{1}','{2}' ", TexBox_idCliente.Text.Trim(), TexBox_NombreCliente.Text.Trim(), TexBox_ApellidoCliente.Text.Trim());
                    Biblioteca.Herramientas(inserta);

                    MessageBox.Show("El cliente se guardo correctamente");
                    return true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex.Message);
                    return false;
                }
            }

            return false;


        }
        public override void Eliminar()
        {
            try
            {
                string eliminar = string.Format("Exec EliminarClientes '{0}' ", TexBox_idCliente.Text.Trim());
                Biblioteca.Herramientas(eliminar);
                MessageBox.Show("El producto se ha eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }


        }
        public override void Nuevo()
        {
            try
            {
                TexBox_idCliente.Text = "";
                TexBox_NombreCliente.Text = "";
                TexBox_ApellidoCliente.Text = "";

                TexBox_idCliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }
        public override void Consultar()
        {
            this.Hide();
            ConsultasClientes consultasClientes = new ConsultasClientes();
            consultasClientes.Show();
        }

        private void TexBox_idProducto_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void TexBox_idCliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
