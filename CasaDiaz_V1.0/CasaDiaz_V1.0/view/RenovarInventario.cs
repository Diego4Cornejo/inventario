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
    public partial class RenovarInventario : Form
    {
        string codigodebarras;
        conexion cnx;
        consultas cons;
        SqlCommand cmd;
        SqlParameter par;
        SqlDataReader dr;
        int idproductos;
        Form_Inventario inventario;
        public string Codigodebarras
        {
            get { return codigodebarras; }
            set { codigodebarras = value; }
        }
        public RenovarInventario()
        {
            InitializeComponent();
            cnx = new conexion();
            cons = new consultas();
            cmd = new SqlCommand();
            par = new SqlParameter();
        }

        private void LBL_PROVEEDOR_NUEVO_Click(object sender, EventArgs e)
        {

        }

        private void RenovarInventario_Load(object sender, EventArgs e)
        {
            obtenerDatosProductos(codigodebarras);
        }
        public void obtenerDatosProductos(string codigodebarra)
        {
            try
            {
                //pro = new (rut);
                //Cadena de conexión
                cmd.Connection = cnx.Con;


                //Abrir la conexión
                cnx.conectar();
                par.ParameterName = "@codigodebarra";
                par.SqlDbType = SqlDbType.VarChar;
                par.Value = codigodebarra;

                //Query

                cmd.CommandText = cons.Query[7].ToString();

                //Agregar el parametro a la consulta
                cmd.Parameters.Add(par);

                //Ejecutar la consulta

                dr = cmd.ExecuteReader();

                dr.Read();

                //Carga de valores obtenidos en la query a cada control

                this.TXT_RENOVAR_CODIGODEBARRA.Text = codigodebarra;
                this.TXT_NOMBRE_RENOVAR.Text = dr.GetString(dr.GetOrdinal("PRO_PRODUCTOS_NOMBRE"));
                this.TXT_MARCA_RENOVAR.Text = dr.GetString(dr.GetOrdinal("PRO_PRODUCTOS_MARCA"));
                this.NDW_CANTIDAD_ACTUAL.Value = dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_STOCK"));
                idproductos = dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_ID"));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                this.Close();

            }
            finally
            {
                //Cerrar la Conexion
                cnx.desconectar();
                cmd.Parameters.Clear();

            }
        }
        public void actualizarDatosProductos(int idproducto)
        {
            try
            {
                cmd.Connection = cnx.Con;
                cnx.conectar();
                DateTime fechaHoy = DateTime.Now;
                string fecha = fechaHoy.ToString("d");

                //Query

                cmd.CommandText = cons.Update[1].ToString();

                //Limpiar Parametros
                cmd.Parameters.Clear();

                //Actualizar Campo

                cmd.Parameters.AddWithValue("@idproducto", idproducto);
                cmd.Parameters.AddWithValue("par1", (int.Parse(this.NDW_AGREGAR_CANTIDAD.Text) + int.Parse(this.NDW_CANTIDAD_ACTUAL.Text)));
                cmd.Parameters.AddWithValue("par2", fecha);

                int Nfilas = cmd.ExecuteNonQuery();
                if (Nfilas > 0)
                {
                    MessageBox.Show("Stock Actualizado Correctamente");

                    //Solo Lectura
                    this.NDW_AGREGAR_CANTIDAD.Enabled = false;
                    this.BTN_GUARDAR_PRODUCTO.Enabled = false;


                }
                else
                {
                    MessageBox.Show("No se han podido actualizar el Stock");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado .");
                MessageBox.Show(ex.Message);

            }
            finally
            {
                //Cerrar la conexion
                cnx.desconectar();
                cmd.Parameters.Clear();
            }
        }

        private void BTN_GUARDAR_PRODUCTO_Click(object sender, EventArgs e)
        {
            actualizarDatosProductos(idproductos);
        }

        private void RenovarInventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            inventario = new Form_Inventario();
            inventario.Show();
        }

        private void NDW_CANTIDAD_ACTUAL_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
