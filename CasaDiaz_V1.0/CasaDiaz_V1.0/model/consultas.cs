using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CasaDiaz_V1._0.model
{
    class consultas
    {
        private ArrayList query = new ArrayList();
        private ArrayList insert = new ArrayList();
        private ArrayList update = new ArrayList();
        private ArrayList delete = new ArrayList();

        public ArrayList Delete
        {
            get { return delete; }
            set { delete = value; }
        }

        public ArrayList Query
        {
            get { return query; }
            set { query = value; }
        }

        public ArrayList Insert
        {
            get { return insert; }
            set { insert = value; }
        }

        public ArrayList Update
        {
            get { return update; }
            set { update = value; }
        }
        public consultas()
        {
            /* INI Query */
            //Query 0 Consulta si hay algun proveedor con ese rut 
            query.Add("SELECT   COUNT(*) " +
                      "FROM     PRO_PROVEEDORES " +
                      "WHERE    PRO_PROVEEDORES_RUT = @rol");
            //Query 1 Consulta los proveedores para llenar el DGV proveedores
            query.Add("SELECT  PRO_PROVEEDORES_RUT, PRO_PROVEEDORES_RAZONSOCIAL, PRO_PROVEEDORES_GIRO, PRO_PROVEEDORES_TELEFONO, PRO_PROVEEDORES_MOVIL " +
                      "FROM    PRO_PROVEEDORES ");
            //Query 2 Consulta para llenar el formulario detalles proveedor
            query.Add("SELECT   PRO_PROVEEDORES_RUT, PRO_PROVEEDORES_DV, PRO_PROVEEDORES_NOMBREFANTASIA, PRO_PROVEEDORES_RAZONSOCIAL, PRO_PROVEEDORES_GIRO, PRO_PROVEEDORES_DIRECCION, PRO_PROVEEDORES_CIUDAD, PRO_PROVEEDORES_REGION, PRO_PROVEEDORES_TELEFONO, PRO_PROVEEDORES_MOVIL, PRO_PROVEEDORES_EMAIL " +
                      "FROM     PRO_PROVEEDORES " +
                      "WHERE    PRO_PROVEEDORES_RUT = @rol");
            //Query 3 Consulta si hay algun Producto con ese codigo de barra
            query.Add("SELECT   COUNT(*) " +
                      "FROM     PRO_PRODUCTOS " +
                      "WHERE    PRO_PRODUCTOS_CODIGODEBARRA = @codigodebarra");
            //Query 4 Consulta los proveedores para llenar el DGV proveedores
            query.Add("SELECT  PRO_PROVEEDORES_NOMBREFANTASIA " +
                      "FROM    PRO_PROVEEDORES ");
            //Query 5 Consultar rut del proveedor con el nombre de fantasia
            query.Add("SELECT   PRO_PROVEEDORES_RUT, PRO_PROVEEDORES_DV, PRO_PROVEEDORES_ID " +
                      "FROM     PRO_PROVEEDORES " +
                      "WHERE    PRO_PROVEEDORES_NOMBREFANTASIA = @nombredefantasia");
            //Query 6 Consulta para llenar dgv proveedores
            query.Add("SELECT   PRO_PRODUCTOS_CODIGODEBARRA, PRO_PRODUCTOS_NOMBRE, PRO_PRODUCTOS_STOCK, PRO_PRODUCTOS_MARCA, PRO_PRODUCTOS_PRECIOVENTA, PRO_PRUDUCTOS_ULTIMAREPOSICION " +
                      "FROM     PRO_PRODUCTOS ");
            //Query 7 Consultar para llenar actualizar producto
            query.Add("SELECT   PRO_PRODUCTOS_NOMBRE, PRO_PRODUCTOS_MARCA, PRO_PRODUCTOS_STOCK, PRO_PRODUCTOS_ID " +
                      "FROM     PRO_PRODUCTOS " +
                      "WHERE    PRO_PRODUCTOS_CODIGODEBARRA = @codigodebarra");
            //Query 8 Consultar codigo de barra de producto para llenar dgv venta
            query.Add("SELECT   PRO_PRODUCTOS_NOMBRE, PRO_PRODUCTOS_PRECIOVENTA, PRO_PRODUCTOS_STOCK, PRO_PRODUCTOS_ID " +
                      "FROM     PRO_PRODUCTOS " +
                      "WHERE    PRO_PRODUCTOS_CODIGODEBARRA = @codigodebarra");
            //Query 9 Consulta el numero de ventas ya registradas
            query.Add("SELECT   COUNT(VE_VENTAS_ID) " +
                      "FROM     VE_VENTAS ");
            //Query 10 Consultar ID para guardar productos de la venta
            query.Add("SELECT   PRO_PRODUCTOS_ID " +
                      "FROM     PRO_PRODUCTOS " +
                      "WHERE    PRO_PRODUCTOS_CODIGODEBARRA = @codigodebarra");



            /* INI Insert */
            //0 -> Insertar Proveedor 
            insert.Add("INSERT INTO PRO_PROVEEDORES(" +
                              "PRO_PROVEEDORES_RUT," +
                              "PRO_PROVEEDORES_DV," +
                              "PRO_PROVEEDORES_NOMBREFANTASIA," +
                              "PRO_PROVEEDORES_RAZONSOCIAL," +
                              "PRO_PROVEEDORES_GIRO," +
                              "PRO_PROVEEDORES_DIRECCION," +
                              "PRO_PROVEEDORES_CIUDAD," +
                              "PRO_PROVEEDORES_REGION," +
                              "PRO_PROVEEDORES_TELEFONO," +
                              "PRO_PROVEEDORES_MOVIL," +
                              "PRO_PROVEEDORES_EMAIL" +
                              ")" +
                              "VALUES(" +
                                           "@par1,@par2,@par3,@par4,@par5,@par6,@par7,@par8,@par9,@par10,@par11" +
                                           ")");
            //1 -> Insertar Productos
            insert.Add("INSERT INTO PRO_PRODUCTOS(" +
                              "PRO_PROVEEDORES_ID," +
                              "PRO_PRODUCTOS_CODIGOPROVEEDOR," +
                              "PRO_PRODUCTOS_CODIGODEBARRA," +
                              "PRO_PRODUCTOS_NOMBRE," +
                              "PRO_PRODUCTOS_STOCK," +
                              "PRO_PRODUCTOS_MARCA," +
                              "PRO_PRODUCTOS_PRECIOCOMPRA," +
                              "PRO_PRODUCTOS_PRECIOVENTA," +
                              "PRO_PRUDUCTOS_ULTIMAREPOSICION" +
                              ")" +
                              "VALUES(" +
                                           "@par1,@par2,@par3,@par4,@par5,@par6,@par7,@par8,@par9" +
                                           ")");
            //2 -> Insertar Venta
            insert.Add("INSERT INTO VE_VENTAS(" +
                              "VE_VENTAS_TOTALVENTA," +
                              "VE_VENTAS_FECHA" +
                              ")" +
                              "VALUES(" +
                                           "@par1,@par2" +
                                           ")");
            //3 -> Insertar Productos de la venta
            insert.Add("INSERT INTO VENTA_PRODUCTOS(" +
                              "VENTA_PRODUCTOS_PRODUCTOID," +
                              "VENTA_PRODUCTOS_VENTAID," +
                              "VENTA_PRODUCTOS_CANTIDAD" +
                              ")" +
                              "VALUES(" +
                                           "@par1,@par2,@par3" +
                                           ")");


            /* INI Update */
            //0 Actualiza los datos de los proveedores
            update.Add("UPDATE PRO_PROVEEDORES " +
                        "SET PRO_PROVEEDORES_RUT = @par1, " +
                        "PRO_PROVEEDORES_DV = @par2, " +
                        "PRO_PROVEEDORES_NOMBREFANTASIA = @par3, " +
                        "PRO_PROVEEDORES_RAZONSOCIAL = @par4, " +
                        "PRO_PROVEEDORES_GIRO = @par5, " +
                        "PRO_PROVEEDORES_DIRECCION = @par6," +
                        "PRO_PROVEEDORES_CIUDAD = @par7, " +
                        "PRO_PROVEEDORES_REGION = @par8, " +
                        "PRO_PROVEEDORES_TELEFONO = @par9, " +
                        "PRO_PROVEEDORES_MOVIL = @par10, " +
                        "PRO_PROVEEDORES_EMAIL = @par11 " +
                        "WHERE PRO_PROVEEDORES_RUT = @rol");
            //1 Actualiza el stock de productos
            update.Add("UPDATE PRO_PRODUCTOS " +
                        "SET PRO_PRODUCTOS_STOCK = @par1, " +
                        "PRO_PRUDUCTOS_ULTIMAREPOSICION = @par2 " +
                        "WHERE PRO_PRODUCTOS_ID = @idproducto");
            //2 Actualiza el stock de productos desde la venta
            update.Add("UPDATE PRO_PRODUCTOS " +
                        "SET PRO_PRODUCTOS_STOCK = @par1 " +
                        "WHERE PRO_PRODUCTOS_ID = @idproducto");
            /* Fin Update */
            //0
            /* INI DELETE */
            //0 Eliminar un proveedor
            delete.Add("DELETE FROM PRO_PROVEEDORES " +
                       "WHERE PRO_PROVEEDORES_RUT = @rol");
           
            //1 Eliminar un proveedor
            delete.Add("DELETE FROM PRO_PRODUCTOS " +
                       "WHERE PRO_PRODUCTOS_CODIGODEBARRA = @codigodebarra");

        }
    }
}
