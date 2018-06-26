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
    public partial class Form_RevisarProductos : Form
    {
        conexion cnx;
        consultas cons;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form_RevisarProductos()
        {
            InitializeComponent();
            cnx = new conexion();
            cons = new consultas();
            cmd = new SqlCommand();
        }

        private void Form_RevisarProductos_Load(object sender, EventArgs e)
        {
            llenar_DGV_INVENTARIO();
        }
        public void llenar_DGV_INVENTARIO()
        {
            try
            {
                //Cadena de conexión
                cmd.Connection = cnx.Con;

                //Query
                cmd.CommandText = cons.Query[6].ToString();

                //Abrir la conexión
                cnx.conectar();

                //Limpiar el DGV Inventario
                this.DGV_INVENTARIO.Rows.Clear();

                //Asignación del valor del SQLCommand al DataReader
                dr = cmd.ExecuteReader();

                //Ciclo que se ejecutará mientras lea registros en la tabla
                while (dr.Read())
                {
                    //Variable que enumera las filas del DGV
                    int fila1 = this.DGV_INVENTARIO.Rows.Add();

                    //Especificar en qué fila se mostrará cada registro
                    this.DGV_INVENTARIO.Rows[fila1].Cells["PRO_PRODUCTOS_CODIGODEBARRA"].Value = dr.GetString(dr.GetOrdinal("PRO_PRODUCTOS_CODIGODEBARRA"));
                    this.DGV_INVENTARIO.Rows[fila1].Cells["PRO_PRODUCTOS_NOMBRE"].Value = dr.GetString(dr.GetOrdinal("PRO_PRODUCTOS_NOMBRE"));
                    this.DGV_INVENTARIO.Rows[fila1].Cells["PRO_PRODUCTOS_STOCK"].Value = dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_STOCK"));
                    this.DGV_INVENTARIO.Rows[fila1].Cells["PRO_PRODUCTOS_MARCA"].Value = dr.GetString(dr.GetOrdinal("PRO_PRODUCTOS_MARCA"));
                    this.DGV_INVENTARIO.Rows[fila1].Cells["PRO_PRODUCTOS_PRECIOVENTA"].Value = ("$ " + dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_PRECIOVENTA")));
                    this.DGV_INVENTARIO.Rows[fila1].Cells["PRO_PRUDUCTOS_ULTIMAREPOSICION"].Value = (" ") + dr.GetDateTime(dr.GetOrdinal("PRO_PRUDUCTOS_ULTIMAREPOSICION"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron productos registrados");
            }
            finally
            {
                cnx.desconectar();
                this.DGV_INVENTARIO.ReadOnly = true;
            }
        }

    }
}
