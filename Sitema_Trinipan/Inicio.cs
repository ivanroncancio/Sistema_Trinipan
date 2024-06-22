using LibreriaDLL;
using Microsoft.Win32;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void bnt_INICIAR_Click(object sender, EventArgs e)
        {
            string validar = string.Format("Select * FROM Usuarios ");
            DataSet ds = Biblioteca.Herramientas(validar);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 0)
            {
                this.Hide();
                Registrar registrar = new Registrar();
                registrar.Show();
            }
            else
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
