using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Comunidad
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

        private string pob;

        public string Pob
        {
            get { return pob; }
            set { pob = value; }
        }


        #endregion

        #region contructor

        public Comunidad(string id, string nombre, string pob)
        {
            this.id = id;
            this.nombre = nombre;
            this.pob = pob;
        }
        #endregion
    }
}
