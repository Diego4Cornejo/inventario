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
    public partial class Form_Revisar_Proveedores : Form
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
        public Form_Revisar_Proveedores()
        {
            InitializeComponent();
            cnx = new conexion();
            cons = new consultas();
            cmd = new SqlCommand();
            par = new SqlParameter();
            proveedor = new Proveedores();
        }

        private void Form_Revisar_Proveedores_Load(object sender, EventArgs e)
        {
            obtenerDatosProveedor(rutproveedor);
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
    }
}
