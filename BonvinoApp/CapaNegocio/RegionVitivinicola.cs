using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class RegionVitivinicola
    {
        #region [Atributos]

        private string nombre;
        private string descripcion;

        #endregion

        #region [Métodos get y set]
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase RegionVitivinicola
        /// </summary>
        /// <param name="nombre"></param>
        public RegionVitivinicola(string nombre, string descripcion)
        {
            Nombre = nombre;
            this.descripcion = descripcion;
        }


        #region [Métodos]

        //métodos propios de la clase

        internal void obtenerPais()
        {
            Provincia.ObtenerProvinciaDeRegion(this);
        }

        #endregion
    }
}
