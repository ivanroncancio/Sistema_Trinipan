﻿using System;
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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        public virtual void Eliminar()
        {

        }
        public virtual void Nuevo()
        {

        }
        public virtual void Consultar()
        {

        }
        public virtual Boolean Guardar()
        {
            return false;
        }


    }
}
