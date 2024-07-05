using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL;

namespace Sitema_Trinipan
{
    public partial class MantenimientoProducto : Mantenimiento  
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);




        public override Boolean Guardar()
        {
            if (Biblioteca.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string inserta = string.Format("EXEC ActualizarProductos '{0}','{1}','{2}' ", TexBox_idProducto.Text.Trim(), TexBox_Descripcion.Text.Trim(), TexBox_Precio.Text.Trim());
                    Biblioteca.Herramientas(inserta);

                    MessageBox.Show("El producto se guardo correctamente");
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
                string eliminar = string.Format("Exec EliminarProductos '{0}' ", TexBox_idProducto.Text.Trim());
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
                TexBox_idProducto.Text = "";
                TexBox_Descripcion.Text = "";
                TexBox_Precio.Text = "";

                TexBox_idProducto.Focus();
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

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            ConsultasProductos consultasProductos = new ConsultasProductos();
            consultasProductos.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MantenimientoProducto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
