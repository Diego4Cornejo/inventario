﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDiaz_V1._0.view
{
    public partial class Form_Venta : Form
    {
        Form_Nueva_Venta nuevaventa;
        public Form_Venta()
        {
            InitializeComponent();
        }

        private void BTN_NUEVA_VENTA_Click(object sender, EventArgs e)
        {
            nuevaventa = new Form_Nueva_Venta();
            nuevaventa.Show();
        }
    }
}
