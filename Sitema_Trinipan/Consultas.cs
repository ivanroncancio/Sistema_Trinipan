using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL;
using Microsoft.Reporting.WinForms;

namespace Sitema_Trinipan
{
    public partial class Consultas : FormBase   
    {
        public Consultas()
        {
            InitializeComponent();
        }
        public DataSet MostrarInformacio(string tabla)
        {
            string cmd = string.Format("Select * from " + tabla);
            DataSet ds = Biblioteca.Herramientas(cmd);
            return ds;
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count ==  0)
            {
                
                return;
            }
            else
            {                
                DialogResult = DialogResult.OK;
                Close();
            }
            
        }
    }
    
}
