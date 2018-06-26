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
            llenar_DGV_VENTAS();
        }
        public void llenar_DGV_VENTAS()
        {
            try
            {
                //Cadena de conexión
                cmd.Connection = cnx.Con;

                //Query
                cmd.CommandText = cons.Query[11].ToString();

                //Abrir la conexión
                cnx.conectar();

                //Limpiar el DGV Inventario
                this.DGV_VENTAS.Rows.Clear();

                //Asignación del valor del SQLCommand al DataReader
                dr = cmd.ExecuteReader();

                //Ciclo que se ejecutará mientras lea registros en la tabla
                while (dr.Read())
                {
                    //Variable que enumera las filas del DGV
                    int fila1 = this.DGV_VENTAS.Rows.Add();

                    //Especificar en qué fila se mostrará cada registro
                    this.DGV_VENTAS.Rows[fila1].Cells["VE_VENTAS_ID"].Value = dr.GetInt32(dr.GetOrdinal("VE_VENTAS_ID"));
                    this.DGV_VENTAS.Rows[fila1].Cells["VE_VENTAS_FECHA"].Value = dr.GetDateTime(dr.GetOrdinal("VE_VENTAS_FECHA")).ToString("dd/MM/yyyy");
                    this.DGV_VENTAS.Rows[fila1].Cells["VE_VENTAS_TOTALVENTA"].Value = ("$ " + dr.GetInt32(dr.GetOrdinal("VE_VENTAS_TOTALVENTA")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron ventas registradas" + ex.ToString());
            }
            finally
            {
                cnx.desconectar();
                this.DGV_VENTAS.ReadOnly = true;
            }
        }
    }
}