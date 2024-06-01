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
        private Bodega bodega;
        private Provincia provincia;
        private string descripcion;

        #endregion

        #region [Métodos get y set]
        public string Nombre { get => nombre; set => nombre = value; }
        public Provincia Provincia { get => provincia; set => provincia = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase RegionVitivinicola
        /// </summary>
        /// <param name="nombre"></param>
        public RegionVitivinicola(string nombre, Provincia provincia, string descripcion)
        {
            Nombre = nombre;
            Provincia = provincia;
            Descripcion = descripcion;
        }


        #region [Métodos]

        //métodos propios de la clase

        private string getNombre()
        {
            return Nombre;
        }


        private string obtenerPais(RegionVitivinicola region)
        { 
            return Provincia.Nombre; 
        }

        #endregion
    }
}
