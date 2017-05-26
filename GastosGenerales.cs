using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class GastosGenerales
    {
        #region Atributos y propiedades

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        private string desc;

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        private string impor;

        public string Impor
        {
            get { return impor; }
            set { impor = value; }
        }

        private string tipzonare;

        public string Tipzonare
        {
            get { return tipzonare; }
            set { tipzonare = value; }
        }

        #endregion

        #region contructor

        public GastosGenerales(string id, string desc, string impor, string tipzonare)
        {
            this.id = id;
            this.desc = desc;
            this.impor = impor;
            this.tipzonare = tipzonare;
        }
        #endregion
    }
}
