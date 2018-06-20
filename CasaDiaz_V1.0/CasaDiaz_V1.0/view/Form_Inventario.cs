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
    public partial class Form_Inventario : Form
    {
        public int xClick = 0, yClick = 0;
        public Form_Inventario()
        {
            InitializeComponent();
        }

        private void BTN_MINIMIZAR_INVENTARIO_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void inventario_form_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_CERRAR_INVENTARIO_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void inventario_form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
