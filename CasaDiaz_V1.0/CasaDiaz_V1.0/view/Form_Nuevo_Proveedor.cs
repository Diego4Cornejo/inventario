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

    public partial class Form_Nuevo_Proveedor : Form
    {
        conexion cnx;
        consultas cons;
        SqlCommand cmd;
        Proveedores pro;
        public Form_Nuevo_Proveedor()
        {
            InitializeComponent();
            cnx = new conexion();
            cons = new consultas();
            cmd = new SqlCommand();
        }

        private void LBL_CIUDAD_PROVEEDOR_Click(object sender, EventArgs e)
        {

        }

        private void BTN_GUARDAR_PROVEEDOR_Click(object sender, EventArgs e)
        {
            try
            {
                int rutproveedor = int.Parse(this.TXT_PROVEEDOR_RUT.Text);
                //Instantazacion de la clase proveedor
                int NFilas1 = 0;

                pro = new Proveedores(rutproveedor);


                cmd.Connection = cnx.Con;
                cnx.conectar();

                /*
                 * INI Ingreso de un nuevo Proveedor
                 * Previamente se verifica si este existe
                 */

                //Query
                cmd.CommandText = (cons.Query[0].ToString());
                //Agregar el parámetro a la consulta
                cmd.Parameters.AddWithValue("@rol", pro.Rutprove);

                //Ejecutar la consulta
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    //Insert 0 -> Cliente
                    cmd.CommandText = (cons.Insert[0].ToString());

                    //Limpiar las variables de los parámetros creados.
                    cmd.Parameters.Clear();

                    //Obtener datos del formulario proveedores
                    cmd.Parameters.AddWithValue("par1", pro.Rutprove);
                    cmd.Parameters.AddWithValue("par2", this.TXT_PROVEEDOR_DV.Text);
                    cmd.Parameters.AddWithValue("par3", this.TXT_NOMBREFANTASIA_PROVEEDOR.Text);
                    cmd.Parameters.AddWithValue("par4", this.TXT_RAZONSOCIAL_PROVEEDOR.Text);
                    cmd.Parameters.AddWithValue("par5", this.TXT_GIRO_PROVEEDOR.Text);
                    cmd.Parameters.AddWithValue("par6", this.TXT_GIRO_PROVEEDOR.Text);
                    cmd.Parameters.AddWithValue("par7", this.TXT_CIUDAD_PROVEEDOR.Text);
                    cmd.Parameters.AddWithValue("par8", this.DDL_REGION_PROVEEDOR.Text);
                    cmd.Parameters.AddWithValue("par9", int.Parse(this.TXT_TELEFONO_PROVEEDOR.Text));
                    cmd.Parameters.AddWithValue("par10", int.Parse(this.TXT_MOVIL_PROVEEDOR.Text));
                    cmd.Parameters.AddWithValue("par11", this.TXT_EMAIL_PROVEEDOR.Text);

                    

                    NFilas1 = cmd.ExecuteNonQuery();

                    if ((NFilas1 > 0))
                    {
                        MessageBox.Show("Se ha registrado exitosamente al Proveedor");
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
                    }
                    else
                    {
                        MessageBox.Show("NO se ha podido registrar al Proveedor");
                    }
                }
                else
                {
                    MessageBox.Show("Hay registros con ese ROL, NO se puede insertar!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally{
                cnx.desconectar();
            }

        }

        private void BTN_CERRAR_NUEVOPROVEEDOR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BTN_MINIMIZAR_NUEVOPROVEEDOR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_Nuevo_Proveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
