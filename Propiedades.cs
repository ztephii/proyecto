using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Propiedades
    {
        #region Atributos y propiedades

        private string tipop;

        public string Tipop
        {
            get { return tipop; }
            set { tipop = value; }
        }


        private string cpropiedad;

        public string Cpropiedad
        {
            get { return cpropiedad; }
            set { cpropiedad = value; }
        }

        private string mc;

        public string Mc
        {
            get { return mc; }
            set { mc = value; }
        }

        private string nitpro;

        public string Nitpro
        {
            get { return nitpro; }
            set { nitpro = value; }
        }

        private string listpor;

        public string Listpor
        {
            get { return listpor; }
            set { listpor = value; }
        }

        #endregion

        #region contructor

        public Propiedades(string tipop, string cpropiedad, string mc, string nitpro, string listpor)
        {
            this.tipop = tipop;
            this.cpropiedad = cpropiedad;
            this.mc = mc;
            this.nitpro = nitpro;
            this.listpor = listpor;
        }
        #endregion
    }
}
