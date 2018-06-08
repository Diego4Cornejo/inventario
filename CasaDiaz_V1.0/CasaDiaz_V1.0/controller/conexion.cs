using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace CasaDiaz_V1._0.controller
{
    class conexion
    {
        SqlConnection con = new SqlConnection();

        public SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }

        private string server = @"MATIAS\SQLEXPRESS";
        private string db = "DBCASADIAZ";
        private string psi = "True";
        private string user = "sa";
        private string pass = "pran123";
        private string pool = "False";

        public conexion()
        {
            Con.ConnectionString = @"Data Source = " + server + ";" +
                                    "Initial Catalog = " + db + ";" +
                                    "Persist Security Info = " + psi + ";" +
                                    "User ID = " + user + ";" +
                                    "Password = " + pass + ";" +
                                    "Pooling = " + pool;
        }

        public void conectar()
        {
            try
            {
                Con.Open();
                //MessageBox.Show("Conectado!!" + con.State);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar!!\n" + ex.Message);
            }
        }

        public void desconectar()
        {
            Con.Close();
            //MessageBox.Show("Desconectado!!" + con.State);
        }

    }
}
