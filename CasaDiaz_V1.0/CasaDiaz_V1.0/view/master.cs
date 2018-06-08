using CasaDiaz_V1._0.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDiaz_V1._0
{
    public partial class Form1 : Form
    {
        inventario_form INVENTARIO;
        public int xClick = 0, yClick = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BTN_CERRAR_MASTER.Focus();
        }

        private void BTN_INVENTARIO_MASTER_Click(object sender, EventArgs e)
        {
            INVENTARIO = new inventario_form();
            INVENTARIO.Show();
        }

        private void BTN_MINIMIZAR_MENU_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void BTN_CERRAR_MASTER_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
