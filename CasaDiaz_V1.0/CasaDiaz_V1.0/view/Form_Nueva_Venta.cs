using CasaDiaz_V1._0.controller;
using CasaDiaz_V1._0.model;
using System;
using System.Collections;
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
    public partial class Form_Nueva_Venta : Form
    {
        conexion cnx;
        consultas cons;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlParameter par;
        string codigosdebarras;
        int totalventa;
        int cantidaddeproducto;
        int preciodeproducto;
        int fila1;
        int totalvuelto;
        int pago;
        int celda;
        private ArrayList barralist = new ArrayList();
        private ArrayList Cantidades = new ArrayList();

        public Form_Nueva_Venta()
        {
            InitializeComponent();
            cnx = new conexion();
            cons = new consultas();
            cmd = new SqlCommand();
            par = new SqlParameter();
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

        private void Form_Nueva_Venta_Load(object sender, EventArgs e)
        {
            obtenernumerodeventa();
        }
        public void obtenernumerodeventa()
        {
            try
            {
                //Inicializar la conexion
                cmd.Connection = cnx.Con;
                cnx.conectar();
                //Query
                cmd.CommandText = (cons.Query[9].ToString());

                //Ejecutar la consulta
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    this.LBL_NUMERODEVENTA.Text = "1";
                }
                else
                {

                    this.LBL_NUMERODEVENTA.Text = (count + 1).ToString();
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
        public void obtenerDatosProductos(string codigodebarra)
        {
            if (this.TXT_CODIGODEBARRA.Text.Length > 5)
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

                    cmd.CommandText = cons.Query[8].ToString();

                    //Agregar el parametro a la consulta
                    cmd.Parameters.Add(par);

                    //Ejecutar la consulta

                    dr = cmd.ExecuteReader();

                    dr.Read();

                    //Carga de valores obtenidos en la query a cada control
                    fila1 = this.DGV_VENTA.Rows.Add();

                    //Especificar en qué fila se mostrará cada registro
                    this.DGV_VENTA.Rows[fila1].Cells["PRO_PRODUCTOS_CODIGODEBARRA"].Value = codigodebarra;
                    this.DGV_VENTA.Rows[fila1].Cells["PRO_PRODUCTOS_NOMBRE"].Value = dr.GetString(dr.GetOrdinal("PRO_PRODUCTOS_NOMBRE"));
                    this.DGV_VENTA.Rows[fila1].Cells["PRO_PRODUCTOS_STOCK"].Value = dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_STOCK"));
                    this.DGV_VENTA.Rows[fila1].Cells["PRO_PRODUCTOS_PRECIOVENTA"].Value = ("$ " + dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_PRECIOVENTA")));
                    preciodeproducto = dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_PRECIOVENTA"));
                    barralist.Add(dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_ID")));
                    

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
            else
            {

            }
        }

        private void TXT_CODIGODEBARRA_Leave(object sender, EventArgs e)
        {
            codigosdebarras = TXT_CODIGODEBARRA.Text;
            obtenerDatosProductos(codigosdebarras);
 
        }

        private void BTN_AGREGAR_PRODUCTO_Click(object sender, EventArgs e)
        {
            this.DGV_VENTA.Rows[fila1].Cells["VENTA_PRODUCTOS_CANTIDAD"].Value = this.NDW_CANTIDAD.Text;
            cantidaddeproducto = int.Parse(this.NDW_CANTIDAD.Text);
            this.TXT_CODIGODEBARRA.Clear();
            this.NDW_CANTIDAD.Value = 1;
            totalventa = totalventa + (preciodeproducto * cantidaddeproducto);
            this.TXT_TOTAL_VENTA.Text = totalventa.ToString();
            this.TXT_CODIGODEBARRA.Focus();
            Cantidades.Add(cantidaddeproducto);


        }

        private void TXT_CODIGODEBARRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_PAGO_VENTA_Leave(object sender, EventArgs e)
        {
            pago = int.Parse(TXT_PAGO_VENTA.Text);
            totalvuelto = pago - totalventa;
            this.TXT_VUELTO.Text = totalvuelto.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            if (CB_REGISTRARCLIENTE_VENTA.Checked == false)
            {
                Registrarventa();
                Registrarproductos();
            }
            }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DGV_VENTA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celda = this.DGV_VENTA.CurrentRow.Index;
            this.BTN_BORRAR_PRODUCTO.Enabled = true;
        }

        private void BTN_BORRAR_PRODUCTO_Click(object sender, EventArgs e)
        {
            DGV_VENTA.Rows.RemoveAt(celda);
        }
        public void Registrarventa()
        {

            try
            {
                //Instanzacion de la clase Venta
                int NFilas1 = 0;

                cmd.Connection = cnx.Con;
                cnx.conectar();

                DateTime fechaHoy = DateTime.Now;
                string fecha = fechaHoy.ToString("d");

                //Insert 2 -> Venta
                cmd.CommandText = (cons.Insert[2].ToString());

                //Limpiar las variables de los parámetros creados.
                cmd.Parameters.Clear();

                //Obtener datos del formulario proveedores
                cmd.Parameters.AddWithValue("par1", int.Parse(this.TXT_TOTAL_VENTA.Text));
                cmd.Parameters.AddWithValue("par2", fecha);


                NFilas1 = cmd.ExecuteNonQuery();

                if ((NFilas1 > 0))
                {
                    MessageBox.Show("Se ha registrado exitosamente  la venta");

                }
                else
                {
                    MessageBox.Show("NO se ha podido registrar le La venta");
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
        public void Registrarproductos() {
            try
            {
                //Instanzacion de la clase Venta
                int NFilas1 = 0;

                cmd.Connection = cnx.Con;
                cnx.conectar();

                DateTime fechaHoy = DateTime.Now;
                string fecha = fechaHoy.ToString("d");

                //Insert 2 -> Venta
                cmd.CommandText = (cons.Insert[3].ToString());



                for (int i = 0; i < DGV_VENTA.Rows.Count; i++)
                {
                    //Limpiar las variables de los parámetros creados.
                    cmd.Parameters.Clear();

                    //Obtener datos del formulario inventario
                    cmd.Parameters.AddWithValue("par1", barralist[i]);
                    cmd.Parameters.AddWithValue("par2", int.Parse(this.LBL_NUMERODEVENTA.Text));
                    cmd.Parameters.AddWithValue("par3", Cantidades[i]);

                }

                NFilas1 = cmd.ExecuteNonQuery();

                if ((NFilas1 > 0))
                {
                    MessageBox.Show("Se ha registrado exitosamente  la venta");

                }
                else
                {
                    MessageBox.Show("NO se ha podido registrar le La venta");
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
    }
    }
