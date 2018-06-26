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
        int resultado;
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
        private ArrayList Stock = new ArrayList();

        Form_RevisarProductos revisar;
        Form_Venta venta;
        bool norepe;
        bool agregar;

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
        }

        private void Form_Nueva_Venta_Load(object sender, EventArgs e)
        {
            this.RB_NOREGISTRAR.Checked = true;
            this.TXT_NOMBRE_CLIENTE.Visible = false;
            this.TXT_RUT_CLIENTE.Visible = false;
            this.TXT_DV_CLIENTE.Visible = false;
            this.LBL_RUT_CLIENTE.Visible = false;
            this.LBL_GUION_CLIENTE.Visible = false;
            this.LBL_NOMBRE_CLIENTE.Visible = false;

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
            norepe = true;
            for (int i = 0; i < DGV_VENTA.Rows.Count; i++)
            {
                if (DGV_VENTA.Rows[i].Cells["PRO_PRODUCTOS_CODIGODEBARRA"].Value.ToString() == codigodebarra)
                {
                    norepe = false ;
                }
            }
            if (TXT_CODIGODEBARRA.Text.Length > 3)
            {
                if (norepe == true)
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
                        this.DGV_VENTA.Rows[fila1].Cells["PRO_PRODUCTOS_CODIGODEBARRA"].Value = dr.GetString(dr.GetOrdinal("PRO_PRODUCTOS_CODIGODEBARRA"));
                        this.DGV_VENTA.Rows[fila1].Cells["PRO_PRODUCTOS_NOMBRE"].Value = dr.GetString(dr.GetOrdinal("PRO_PRODUCTOS_NOMBRE"));
                        this.DGV_VENTA.Rows[fila1].Cells["PRO_PRODUCTOS_STOCK"].Value = dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_STOCK"));
                        this.DGV_VENTA.Rows[fila1].Cells["PRO_PRODUCTOS_PRECIOVENTA"].Value = (dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_PRECIOVENTA")));
                        preciodeproducto = dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_PRECIOVENTA"));
                        barralist.Add(dr.GetInt32(dr.GetOrdinal("PRO_PRODUCTOS_ID")));

                        agregar = true;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se encontro Producto con ese codigo de barras");
                        agregar = false;
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
                    MessageBox.Show("Ya existe producto con ese codigo de barra agregado a la lista de productos");
                    this.TXT_CODIGODEBARRA.Text = "";
                    this.NDW_CANTIDAD.Value = 1;
                    this.TXT_CODIGODEBARRA.Focus();
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
            if (agregar == true)
            {
                this.DGV_VENTA.Rows[fila1].Cells["VENTA_PRODUCTOS_CANTIDAD"].Value = this.NDW_CANTIDAD.Text;
                Stock.Add(int.Parse(DGV_VENTA.Rows[fila1].Cells["PRO_PRODUCTOS_STOCK"].Value.ToString()));
                cantidaddeproducto = int.Parse(this.NDW_CANTIDAD.Text);
                this.TXT_CODIGODEBARRA.Clear();
                this.NDW_CANTIDAD.Value = 1;
                totalventa = totalventa + (preciodeproducto * cantidaddeproducto);
                this.TXT_TOTAL_VENTA.Text = totalventa.ToString();
                this.TXT_CODIGODEBARRA.Focus();
                Cantidades.Add(cantidaddeproducto);
                
            }
            else
            {
                MessageBox.Show("Verifique que el codigo de barra este ingresado correctamente");
                this.TXT_CODIGODEBARRA.Focus();
                this.NDW_CANTIDAD.Value = 1;
            }


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
            revisar = new Form_RevisarProductos();
            revisar.Show();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            if (RB_NOREGISTRAR.Checked == true)
            {
                Registrarventa();
                Registrarproductos();
                actualizarDatosProductos();

                if ((resultado > 0))
                {
                    MessageBox.Show("Se ha registrado exitosamente la Venta");
                    this.BTN_GUARDAR.Enabled = false;
                    this.GB_PRODUCTOS_VENTA.Enabled = false;
                    this.GB_DATOS_CLIENTES.Enabled = false;
                    this.GB_TOTALVENTA.Enabled = false;
            

                }
                else
                {
                    MessageBox.Show("NO se ha podido registrar le La venta");
                }
            }
            }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void actualizarDatosProductos()
        {
            try
            {
                cmd.Connection = cnx.Con;
                cnx.conectar();

                //Query

                cmd.CommandText = cons.Update[2].ToString();


                //Actualizar Campo
                for (int i = 0; i < DGV_VENTA.Rows.Count; i++)
                {
                    //Limpiar las variables de los parámetros creados.
                    cmd.Parameters.Clear();

                    //Obtener datos del formulario inventario
                    cmd.Parameters.AddWithValue("@idproducto", barralist[i]);
                    cmd.Parameters.AddWithValue("par1", int.Parse(Stock[i].ToString()) - int.Parse(Cantidades[i].ToString()));
                    cmd.ExecuteNonQuery();

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

        private void DGV_VENTA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celda = this.DGV_VENTA.CurrentRow.Index;
            this.BTN_BORRAR_PRODUCTO.Enabled = true;
        }

        private void BTN_BORRAR_PRODUCTO_Click(object sender, EventArgs e)
        {

                totalventa = totalventa - (int.Parse(DGV_VENTA.Rows[celda].Cells["VENTA_PRODUCTOS_CANTIDAD"].Value.ToString()) * int.Parse(DGV_VENTA.Rows[celda].Cells["PRO_PRODUCTOS_PRECIOVENTA"].Value.ToString()));
                TXT_TOTAL_VENTA.Text = totalventa.ToString();
                barralist.RemoveAt(celda);
                Cantidades.RemoveAt(celda);
                Stock.RemoveAt(celda);
                DGV_VENTA.Rows.RemoveAt(celda);

            
        }
        public void Registrarventa()
        {

            try
            {
                //Instanzacion de la clase Venta

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


                resultado = cmd.ExecuteNonQuery();


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
                    resultado = resultado + cmd.ExecuteNonQuery();
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

        private void Form_Nueva_Venta_FormClosed(object sender, FormClosedEventArgs e)
        {
            venta = new Form_Venta();
            venta.Show();
        }
    }
    }
