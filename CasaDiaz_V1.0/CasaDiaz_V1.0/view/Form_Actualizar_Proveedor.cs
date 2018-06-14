using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CasaDiaz_V1._0.controller;
using CasaDiaz_V1._0.model;

namespace CasaDiaz_V1._0.view
{
    public partial class Form_Actualizar_Proveedor : Form
    {
        conexion cnx;
        consultas cons;
        SqlCommand cmd;
        SqlParameter par;
        SqlDataReader dr;
        int rutproveedor;
        Proveedores proveedor;
        public int Rutproveedor
        {
            get { return rutproveedor; }
            set { rutproveedor = value; }
        }
        public Form_Actualizar_Proveedor()
        {
            InitializeComponent();
            cnx = new conexion();
            cons = new consultas();
            cmd = new SqlCommand();
            par = new SqlParameter();
            proveedor = new Proveedores();
        }

        private void Form_Actualizar_Proveedor_Load(object sender, EventArgs e)
        {

            obtenerDatosProveedor(rutproveedor);
            this.TXT_PROVEEDOR_RUT.Enabled = false;
            this.TXT_PROVEEDOR_DV.Enabled = false;
        }
        public void obtenerDatosProveedor(int rut)
        {
            try
            {
                //pro = new (rut);
                //Cadena de conexión
                cmd.Connection = cnx.Con;


                //Abrir la conexión
                cnx.conectar();
                par.ParameterName = "@rol";
                par.SqlDbType = SqlDbType.Int;
                par.Value = rut;

                //Query

                cmd.CommandText = cons.Query[2].ToString();

                //Agregar el parametro a la consulta
                cmd.Parameters.Add(par);

                //Ejecutar la consulta

                dr = cmd.ExecuteReader();

                dr.Read();

                //Carga de valores obtenidos en la query a cada control

                this.TXT_PROVEEDOR_RUT.Text = dr.GetInt32(dr.GetOrdinal("PRO_PROVEEDORES_RUT")).ToString();
                this.TXT_PROVEEDOR_DV.Text = dr.GetString(dr.GetOrdinal("PRO_PROVEEDORES_DV"));
                this.TXT_NOMBREFANTASIA_PROVEEDOR.Text = dr.GetString(dr.GetOrdinal("PRO_PROVEEDORES_NOMBREFANTASIA"));
                this.TXT_RAZONSOCIAL_PROVEEDOR.Text = dr.GetString(dr.GetOrdinal("PRO_PROVEEDORES_RAZONSOCIAL"));
                this.TXT_GIRO_PROVEEDOR.Text = dr.GetString(dr.GetOrdinal("PRO_PROVEEDORES_GIRO"));
                this.TXT_DIRECCION_PROVEEDOR.Text = dr.GetString(dr.GetOrdinal("PRO_PROVEEDORES_DIRECCION"));
                this.TXT_CIUDAD_PROVEEDOR.Text = dr.GetString(dr.GetOrdinal("PRO_PROVEEDORES_CIUDAD"));
                this.DDL_REGION_PROVEEDOR.Text = dr.GetString(dr.GetOrdinal("PRO_PROVEEDORES_REGION"));
                this.TXT_TELEFONO_PROVEEDOR.Text = dr.GetInt32(dr.GetOrdinal("PRO_PROVEEDORES_TELEFONO")).ToString();
                this.TXT_MOVIL_PROVEEDOR.Text = dr.GetInt32(dr.GetOrdinal("PRO_PROVEEDORES_MOVIL")).ToString();
                this.TXT_EMAIL_PROVEEDOR.Text = dr.GetString(dr.GetOrdinal("PRO_PROVEEDORES_EMAIL"));


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

        public void actualizarDatosProveedor(int rut)
        {
            try
            {
                cmd.Connection = cnx.Con;
                cnx.conectar();

                //Query

                cmd.CommandText = cons.Update[0].ToString();

                //Limpiar Parametros
                cmd.Parameters.Clear();

                //Actualizar Campo

                cmd.Parameters.AddWithValue("@rol", rut);
                cmd.Parameters.AddWithValue("par1", int.Parse(this.TXT_PROVEEDOR_RUT.Text));
                cmd.Parameters.AddWithValue("par2", this.TXT_PROVEEDOR_DV.Text);
                cmd.Parameters.AddWithValue("par3", this.TXT_NOMBREFANTASIA_PROVEEDOR.Text);
                cmd.Parameters.AddWithValue("par4", this.TXT_RAZONSOCIAL_PROVEEDOR.Text);
                cmd.Parameters.AddWithValue("par5", this.TXT_GIRO_PROVEEDOR.Text);
                cmd.Parameters.AddWithValue("par6", this.TXT_DIRECCION_PROVEEDOR.Text);
                cmd.Parameters.AddWithValue("par7", this.TXT_CIUDAD_PROVEEDOR.Text);
                cmd.Parameters.AddWithValue("par8", this.DDL_REGION_PROVEEDOR.Text);
                cmd.Parameters.AddWithValue("par9", int.Parse(this.TXT_TELEFONO_PROVEEDOR.Text));
                cmd.Parameters.AddWithValue("par10", int.Parse(this.TXT_MOVIL_PROVEEDOR.Text));
                cmd.Parameters.AddWithValue("par11", this.TXT_EMAIL_PROVEEDOR.Text);

                int Nfilas = cmd.ExecuteNonQuery();
                if (Nfilas > 0)
                {
                    MessageBox.Show("Datos del Cliente actualizados Correctamente");

                    //Solo Lectura
                    this.TXT_PROVEEDOR_RUT.ReadOnly = true;
                    this.TXT_PROVEEDOR_DV.ReadOnly = true;
                    this.TXT_NOMBREFANTASIA_PROVEEDOR.ReadOnly = true;
                    this.TXT_RAZONSOCIAL_PROVEEDOR.ReadOnly = true;
                    this.TXT_GIRO_PROVEEDOR.ReadOnly = true;
                    this.TXT_DIRECCION_PROVEEDOR.ReadOnly = true;
                    this.TXT_CIUDAD_PROVEEDOR.ReadOnly = true;
                    this.DDL_REGION_PROVEEDOR.Enabled = false;
                    this.TXT_MOVIL_PROVEEDOR.ReadOnly = true;
                    this.TXT_TELEFONO_PROVEEDOR.ReadOnly = true;
                    this.TXT_EMAIL_PROVEEDOR.ReadOnly = true;
                    this.BTN_GUARDAR_PROVEEDOR.Enabled = false;
                    this.BTN_LIMPIAR_PROVEEDOR.Enabled = false;


                }
                else
                {
                    MessageBox.Show("No se han podido actualizar los datos del cliente.!");

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

        private void BTN_GUARDAR_PROVEEDOR_Click(object sender, EventArgs e)
        {
            actualizarDatosProveedor(rutproveedor);
        }
    }
}
