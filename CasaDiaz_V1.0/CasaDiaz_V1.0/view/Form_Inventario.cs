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
    public partial class Form_Inventario : Form
    {
        public int xClick = 0, yClick = 0;
        Form_NuevoProducto producto;
        RenovarInventario renovarinventario;
        conexion cnx;
        consultas cons;
        SqlCommand cmd;
        SqlDataReader dr;
        string codigodebarra;
        public Form_Inventario()
        {
            InitializeComponent();
            cnx = new conexion();
            cons = new consultas();
            cmd = new SqlCommand();
        }

        private void BTN_MINIMIZAR_INVENTARIO_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void inventario_form_Load(object sender, EventArgs e)
        {
            llenar_DGV_INVENTARIO();
            this.BTN_RENOVAR_PRODUCTO.Enabled = false;
            this.BTN_ELIMINAR_PRODUCTO.Enabled = false;
            this.BTN_REVISAR_PRODUCTO.Enabled = false;
            this.RB_INVENTARIO_TODOS.Checked = true;
            DGV_INVENTARIO.Rows[0].Selected = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialog = MessageBox.Show("Estas Seguro que desea eliminar El Producto del inventario?", "Eliminar Producto", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    cmd.Connection = cnx.Con;
                    cnx.conectar();
                    //Query
                    cmd.CommandText = cons.Delete[1].ToString();

                    //Limpiar los parametros
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codigodebarra", codigodebarra);
                    int Nfilas = cmd.ExecuteNonQuery();

                    if (Nfilas > 0)
                    {
                        MessageBox.Show("Registro del producto eliminado con exito de la base de datos.");
                        cnx.desconectar();

                        //Refrescar la dgv realizando nueva consulta
                        llenar_DGV_INVENTARIO();

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el Producto!!");
                        this.Close();
                    }

                }
                else
                {

                    MessageBox.Show("Se ha producido un error inesperado \n porfavor, intente nuevamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());

            }
            finally
            {
                cnx.desconectar();
            }
        }

        private void BTN_CERRAR_INVENTARIO_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BTN_NUEVO_PRODUCTO_Click(object sender, EventArgs e)
        {
            producto = new Form_NuevoProducto();
            producto.Show();
            this.Close();
        }

        private void BTN_RENOVAR_PRODUCTO_Click(object sender, EventArgs e)
        {
            renovarinventario = new RenovarInventario();
            renovarinventario.Codigodebarras = codigodebarra;
            renovarinventario.Show();
            this.Close();
        }

        private void inventario_form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void LBL_INVENTARIO_INVENTARIO_Click(object sender, EventArgs e)
        {

        }

        private void DGV_INVENTARIO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Asignacion del valor (RUT de la empresa) del seleccionado del data griw viw

            codigodebarra = this.DGV_INVENTARIO.Rows[this.DGV_INVENTARIO.CurrentRow.Index].Cells[0].Value.ToString();

            //Habilitar controles (buttons) 

            this.BTN_RENOVAR_PRODUCTO.Enabled = true;
            this.BTN_ELIMINAR_PRODUCTO.Enabled = true;
            this.BTN_REVISAR_PRODUCTO.Enabled = true;
        }

        private void DGV_INVENTARIO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_REVISAR_PRODUCTO_Click(object sender, EventArgs e)
        {

        }

        private void Form_Inventario_ChangeUICues(object sender, UICuesEventArgs e)
        {
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
                    this.DGV_INVENTARIO.Rows[fila1].Cells["PRO_PRUDUCTOS_ULTIMAREPOSICION"].Value =(" ") + dr.GetDateTime(dr.GetOrdinal("PRO_PRUDUCTOS_ULTIMAREPOSICION"));
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
