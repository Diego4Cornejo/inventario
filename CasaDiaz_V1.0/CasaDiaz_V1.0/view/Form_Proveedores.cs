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
using CasaDiaz_V1._0.model;
using CasaDiaz_V1._0.controller;

namespace CasaDiaz_V1._0.view
{
    public partial class Form_Proveedores : Form
    {
        SqlCommand cmd;
        conexion cnx;
        consultas cons;
        SqlDataReader dr;
        Proveedores pro;
        public int xClick = 0, yClick = 0;
        Form_Nuevo_Proveedor nuevoproveedor;
        Form_Actualizar_Proveedor actualizarproveedor;
        Form_Revisar_Proveedores revisarproveedor;

        public Form_Proveedores()
        {
            InitializeComponent();
            cnx = new conexion();
            cons = new consultas();
            cmd = new SqlCommand();
            pro = new Proveedores();
        }

        private void BTN_CERRAR_INVENTARIO_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BTN_MINIMIZAR_INVENTARIO_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form_Proveedores_Load(object sender, EventArgs e)
        {
            llenar_DGV_PROVEEDORES();
            this.BTN_ELIMINAR_PROVEEDOR.Enabled = false;
            this.BTN_REVISAR_PROVEEDOR.Enabled = false;
            this.BTN_MODIFICAR_PROVEEDOR.Enabled = false;
            this.RB_PROVEEDOR_TODOS.Checked = true;
            DGV_PROVEEDORES.Rows[0].Selected = false;
        }

        private void Form_Proveedores_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void BTN_NUEVO_PROVEEDOR_Click(object sender, EventArgs e)
        {
            nuevoproveedor = new Form_Nuevo_Proveedor();
            nuevoproveedor.Show();
            this.Close();
        }

        private void DGV_PROVEEDORES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Asignacion del valor (RUT de la empresa) del seleccionado del data griw viw

            pro.Rutprove = int.Parse(this.DGV_PROVEEDORES.Rows[this.DGV_PROVEEDORES.CurrentRow.Index].Cells[0].Value.ToString());

            //Habilitar controles (buttons) 

            this.BTN_ELIMINAR_PROVEEDOR.Enabled = true;
            this.BTN_REVISAR_PROVEEDOR.Enabled = true;
            this.BTN_MODIFICAR_PROVEEDOR.Enabled = true;
        }

        private void BTN_ELIMINAR_PROVEEDOR_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialog = MessageBox.Show("Estas Seguro que desea eliminar al Proveedor?", "Eliminar Proveedor", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    cmd.Connection = cnx.Con;
                    cnx.conectar();
                    //Query
                    cmd.CommandText = cons.Delete[0].ToString();

                    //Limpiar los parametros
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@rol", pro.Rutprove);
                    int Nfilas = cmd.ExecuteNonQuery();

                    if (Nfilas > 0)
                    {
                        MessageBox.Show("Registro del proveedor eliminado con exito de la base de datos.");
                        cnx.desconectar();

                        //Refrescar la dgv realizando nueva consulta
                        llenar_DGV_PROVEEDORES();

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el registro.!!");
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

        private void BTN_MODIFICAR_PROVEEDOR_Click(object sender, EventArgs e)
        {
            actualizarproveedor = new Form_Actualizar_Proveedor();
            actualizarproveedor.Rutproveedor = pro.Rutprove;
            actualizarproveedor.Show();
        }

        private void BTN_REVISAR_PROVEEDOR_Click(object sender, EventArgs e)
        {
            revisarproveedor = new Form_Revisar_Proveedores();
            revisarproveedor.Rutproveedor = pro.Rutprove;
            revisarproveedor.Show();
        }

        public void llenar_DGV_PROVEEDORES()
        {
            try
            {
                //Cadena de conexión
                cmd.Connection = cnx.Con;

                //Query
                cmd.CommandText = cons.Query[1].ToString();

                //Abrir la conexión
                cnx.conectar();

                //Limpiar el DGV Clientes
                this.DGV_PROVEEDORES.Rows.Clear();

                //Asignación del valor del SQLCommand al DataReader
                dr = cmd.ExecuteReader();

                //Ciclo que se ejecutará mientras lea registros en la tabla
                while (dr.Read())
                {
                    //Variable que enumera las filas del DGV
                    int fila1 = this.DGV_PROVEEDORES.Rows.Add();

                    //Especificar en qué fila se mostrará cada registro
                    this.DGV_PROVEEDORES.Rows[fila1].Cells["PRO_PROVEEDORES_RUT"].Value = dr.GetInt32(dr.GetOrdinal("PRO_PROVEEDORES_RUT"));
                    this.DGV_PROVEEDORES.Rows[fila1].Cells["PRO_PROVEEDORES_RAZONSOCIAL"].Value = dr.GetString(dr.GetOrdinal("PRO_PROVEEDORES_RAZONSOCIAL"));
                    this.DGV_PROVEEDORES.Rows[fila1].Cells["PRO_PROVEEDORES_GIRO"].Value = dr.GetString(dr.GetOrdinal("PRO_PROVEEDORES_GIRO"));
                    this.DGV_PROVEEDORES.Rows[fila1].Cells["PRO_PROVEEDORES_TELEFONO"].Value = dr.GetInt32(dr.GetOrdinal("PRO_PROVEEDORES_MOVIL"));
                    this.DGV_PROVEEDORES.Rows[fila1].Cells["PRO_PROVEEDORES_MOVIL"].Value = dr.GetInt32(dr.GetOrdinal("PRO_PROVEEDORES_MOVIL"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado.\nPor favor, intente más tarde!!" + ex.ToString());
            }
            finally
            {
                cnx.desconectar();
                this.DGV_PROVEEDORES.ReadOnly = true;
            }

        }
    }
}
