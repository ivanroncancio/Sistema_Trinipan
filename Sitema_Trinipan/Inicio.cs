using LibreriaDLL;
using Microsoft.Win32;
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

namespace Sitema_Trinipan
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);



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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
