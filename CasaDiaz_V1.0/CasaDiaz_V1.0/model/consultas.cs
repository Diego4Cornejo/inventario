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
            //Query 0
            query.Add("SELECT   COUNT(*) " +
                      "FROM     PRO_PROVEEDORES " +
                      "WHERE    PRO_PROVEEDORES_RUT = @rol");
            //Query 1
            query.Add("SELECT  PRO_PROVEEDORES_RUT, PRO_PROVEEDORES_RAZONSOCIAL, PRO_PROVEEDORES_GIRO, PRO_PROVEEDORES_TELEFONO, PRO_PROVEEDORES_MOVIL " +
                      "FROM    PRO_PROVEEDORES ");
            //Query 2
            query.Add("SELECT   PRO_PROVEEDORES_RUT, PRO_PROVEEDORES_DV, PRO_PROVEEDORES_NOMBREFANTASIA, PRO_PROVEEDORES_RAZONSOCIAL, PRO_PROVEEDORES_GIRO, PRO_PROVEEDORES_DIRECCION, PRO_PROVEEDORES_CIUDAD, PRO_PROVEEDORES_REGION, PRO_PROVEEDORES_TELEFONO, PRO_PROVEEDORES_MOVIL, PRO_PROVEEDORES_EMAIL " +
                      "FROM     PRO_PROVEEDORES " +
                      "WHERE    PRO_PROVEEDORES_RUT = @rol");


            /* INI Insert */
            //0 -> Proveedor
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


            /* INI Update */
            //0
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
            /* Fin Update */
            //0
            /* INI DELETE */
            //0
            delete.Add("DELETE FROM PRO_PROVEEDORES " +
                       "WHERE PRO_PROVEEDORES_RUT = @rol");

        }
    }
}
