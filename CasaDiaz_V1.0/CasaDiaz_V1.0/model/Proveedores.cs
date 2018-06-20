using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDiaz_V1._0.model
{
    class Proveedores
    {
        int rutprove;

        public int Rutprove
        {
            get { return rutprove; }
            set { rutprove = value; }
        }
        String nombrefantasia;

        public String Nombrefantasia
        {
            get { return nombrefantasia; }
            set { nombrefantasia = value; }
        }
        String razonsocial;

        public String Razonsocial
        {
            get { return razonsocial; }
            set { razonsocial = value; }
        }

        String giro;

        public String Giro
        {
            get { return giro; }
            set { giro = value; }
        }
        public Proveedores()
        {


        }
        public Proveedores(int rutpr)
        {
            rutprove = rutpr;
        }
    }
}
