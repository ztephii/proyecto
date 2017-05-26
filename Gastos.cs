using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Gastos
    {
        #region Atributos y propiedades

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string tipr;

        public string Tipr
        {
            get { return tipr; }
            set { tipr = value; }
        }


        #endregion

        #region contructor

        public Gastos(string id, string nombre, string tipr)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipr = tipr;
        }
        #endregion

    }
}
