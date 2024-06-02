using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class Pais
    {
        #region [Atributos]

        private string nombre;
        private List<Provincia> provincia;

        #endregion

        #region [Métodos get y set]

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Provincia> Provincia { get => provincia; set => provincia = value; }


        #endregion

        /// <summary>
        /// Constructor de la clase Pais
        /// </summary>
        /// <param name="nombre"></param>
        public Pais(string nombre)
        {
            Nombre = nombre;
            Provincia = new List<Provincia>();
        }

        #region [Métodos]

        private string getNombre()
        {
            return Nombre;
        }

        public void agregarProvincia(Provincia provincia)
        {
            Provincia.Add(provincia);
        }

        #endregion
    }
}
