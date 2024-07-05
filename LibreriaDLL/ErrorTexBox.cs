using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL;

namespace LibreriaDLL
{
    public partial class ErrorTexBox : TextBox  
    {
        public ErrorTexBox()
        {
            InitializeComponent();
        }
        public Boolean Validar
        {
            get; set;
        }
        public Boolean ValidarNumeros
        {
            get; set;
        }
        public Boolean ValidarCorreo
        {
            get; set;
        }





    }
}
