using System;
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
    public partial class Form_Nueva_Venta : Form
    {
        public Form_Nueva_Venta()
        {
            InitializeComponent();
        }

        private void LBL_VENTA_NUEVA_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CB_REGISTRARCLIENTE_VENTA_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CB_REGISTRARCLIENTE_VENTA.Checked == true)
            {
                this.TXT_NOMBRE_CLIENTE.Enabled = true;
                this.TXT_RUT_CLIENTE.Enabled = true;
                this.TXT_DV_CLIENTE.Enabled = true;
                this.TXT_EMAILCLIENTE_VENTA.Enabled = true;
            }
            else
            {
                this.TXT_NOMBRE_CLIENTE.Enabled = false;
                this.TXT_RUT_CLIENTE.Enabled = false;
                this.TXT_DV_CLIENTE.Enabled = false;
                this.TXT_EMAILCLIENTE_VENTA.Enabled = false;
            }
        }
    }
}
