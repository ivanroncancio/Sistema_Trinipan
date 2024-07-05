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
    public partial class ContenedorPrincipal : Form
    {
        private int childFormNumber = 0;

        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string validar = "Select * from Usuarios where id_usuarios = " + Login.codigo;
            DataSet ds = Biblioteca.Herramientas(validar);

            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Validar_usuario"].ToString()) == true || Convert.ToBoolean(ds.Tables[0].Rows[0]["validar_usuario"].ToString()) == false)
            {
                MantenimientoCliente mantenimientoCliente = new MantenimientoCliente();
                mantenimientoCliente.MdiParent = this;
                mantenimientoCliente.Show();
            }
            else
            {
                MessageBox.Show("No tienes permisos de administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string validar = "Select * from Usuarios where id_usuarios = " + Login.codigo;
            DataSet ds = Biblioteca.Herramientas(validar);

            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Validar_usuario"].ToString()) == true)
            {
                MantenimientoProducto mantenimientoProducto = new MantenimientoProducto();
                mantenimientoProducto.MdiParent = this;
                mantenimientoProducto.Show();
            }
            else
            {
                MessageBox.Show("No tienes permisos de administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultasClientes consultasClientes = new ConsultasClientes();
            consultasClientes.MdiParent = this;
            consultasClientes.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultasProductos consultasProductos = new ConsultasProductos();
            consultasProductos.MdiParent = this;
            consultasProductos.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = new Facturacion();
            facturacion.MdiParent = this;
            facturacion.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.MdiParent = this;
            ventas.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
            
        }
    }
}
