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
    public partial class Form_NuevoProducto : Form
    {
        SqlCommand cmd;
        conexion cnx;
        consultas cons;
        SqlDataReader dr;
        int idproveedor;
        Form_Inventario inventario;
        public Form_NuevoProducto()
        {
            InitializeComponent();
            cnx = new conexion();
            cons = new consultas();
            cmd = new SqlCommand();
        }

        private void LBL_PROVEEDOR_NUEVO_Click(object sender, EventArgs e)
        {

        }
        public void CargarddlNombres()
        {
            try
            {
                cnx.conectar();

                cmd.Connection = cnx.Con;
                cmd.CommandText = cons.Query[4].ToString();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.DDL_PROVEEDOR_PRODUCTO.Items.Add(dr["PRO_PROVEEDORES_NOMBREFANTASIA"].ToString());
                    //IDTRABAJADOR.Add(dr["TRA_TRABAJADOR_ID".ToString()]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cnx.desconectar();
            }

        }

        private void Form_NuevoProducto_Load(object sender, EventArgs e)
        {
            this.DDL_PROVEEDOR_PRODUCTO.SelectedIndex = 0;
            CargarddlNombres();
        }

        private void DDL_PROVEEDOR_PRODUCTO_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                cnx.conectar();

                cmd.Connection = cnx.Con;
                cmd.CommandText = cons.Query[5].ToString();
                cmd.Parameters.Clear();
                string nombreproveedor = DDL_PROVEEDOR_PRODUCTO.Text;
                cmd.Parameters.AddWithValue("@nombredefantasia", nombreproveedor);
                //Ejecutar la consulta
                dr = cmd.ExecuteReader();
                dr.Read();

                //Carga de valores obtenidos en la query a cada control
                this.TXT_RUT_PROVEEDOR.Text = dr.GetInt32(dr.GetOrdinal("PRO_PROVEEDORES_RUT")).ToString() + dr.GetString(dr.GetOrdinal("PRO_PROVEEDORES_DV"));

                idproveedor = dr.GetInt32(dr.GetOrdinal("PRO_PROVEEDORES_ID"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cnx.desconectar();
            }
        }

        private void BTN_GUARDAR_PRODUCTO_Click(object sender, EventArgs e)
        {
            try
            {
                //Instantazacion de la clase proveedor
                int NFilas1 = 0;

                cmd.Connection = cnx.Con;
                cnx.conectar();

                DateTime fechaHoy = DateTime.Now;
                string fecha = fechaHoy.ToString("d");

                /*
                 * INI Ingreso de un nuevo Proveedor
                 * Previamente se verifica si este existe
                 */

                //Query
                cmd.CommandText = (cons.Query[3].ToString());
                //Agregar el parámetro a la consulta
                cmd.Parameters.AddWithValue("@codigodebarra", this.TXT_INVENTARIO_CODIGODEBARRA.Text);

                //Ejecutar la consulta
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    //Insert 0 -> Cliente
                    cmd.CommandText = (cons.Insert[1].ToString());

                    //Limpiar las variables de los parámetros creados.
                    cmd.Parameters.Clear();

                    //Obtener datos del formulario proveedores
                    cmd.Parameters.AddWithValue("par1", idproveedor);
                    cmd.Parameters.AddWithValue("par2", this.TXT_CODIGO_PROVEEDOR.Text);
                    cmd.Parameters.AddWithValue("par3", this.TXT_INVENTARIO_CODIGODEBARRA.Text);
                    cmd.Parameters.AddWithValue("par4", this.TXT_NOMBRE_INVENTARIO.Text);
                    cmd.Parameters.AddWithValue("par5", 0);
                    cmd.Parameters.AddWithValue("par6", this.TXT_MARCA_PRODUCTO.Text);
                    cmd.Parameters.AddWithValue("par7", int.Parse(this.TXT_PRECIO_COMPRA.Text));
                    cmd.Parameters.AddWithValue("par8", int.Parse(this.TXT_PRECIOVENTA.Text));
                    cmd.Parameters.AddWithValue("par9", fecha);




                    NFilas1 = cmd.ExecuteNonQuery();

                    if ((NFilas1 > 0))
                    {
                        MessageBox.Show("Se ha registrado exitosamente el producto");
                        this.TXT_INVENTARIO_CODIGODEBARRA.ReadOnly = true;
                        this.TXT_CODIGO_PROVEEDOR.ReadOnly = true;
                        this.TXT_NOMBRE_INVENTARIO.ReadOnly = true;
                        this.TXT_MARCA_PRODUCTO.ReadOnly = true;
                        this.TXT_PRECIOVENTA.ReadOnly = true;
                        this.TXT_PRECIO_COMPRA.ReadOnly = true;
                        this.TXT_RUT_PROVEEDOR.ReadOnly = true;
                        this.DDL_PROVEEDOR_PRODUCTO.Enabled = false;
                        this.BTN_GUARDAR_PRODUCTO.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("NO se ha podido registrar le producto");
                    }
                }
                else
                {
                    MessageBox.Show("Hay registros con ese codigo de barras, NO se puede insertar!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cnx.desconectar();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_NuevoProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            inventario = new Form_Inventario();
            inventario.Show();
        }
    }
}
