using CasaDiaz_V1._0.controller;
using CasaDiaz_V1._0.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDiaz_V1._0.view
{
    public partial class Form_Venta : Form
    {
        conexion cnx;
        consultas cons;
        SqlCommand cmd;
        SqlDataReader dr;
        Form_Nueva_Venta nuevaventa;
        public Form_Venta()
        {
            InitializeComponent();
            cnx = new conexion();
            cons = new consultas();
            cmd = new SqlCommand();
        }

        private void BTN_NUEVA_VENTA_Click(object sender, EventArgs e)
        {
            nuevaventa = new Form_Nueva_Venta();
            nuevaventa.Show();
            this.Close();
        }

        private void Form_Venta_Load(object sender, EventArgs e)
        {
        }
      
        }
    }