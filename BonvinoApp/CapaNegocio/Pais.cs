using BonvinoApp.CapaDatos;
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
        private List<Provincia> provincias;

        #endregion

        #region [Métodos get y set]

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Provincia> Provincias { get => provincias; set => provincias = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Pais
        /// </summary>
        /// <param name="nombre"></param>
        public Pais(string nombre, List<Provincia> provincias)
        {
            Nombre = nombre;
            this.provincias = provincias;
        }

        #region [Métodos]

        //métodos propios de la clase

        public static string getNombre(Provincia provincia)
        {
            generalDAC general = new generalDAC();
            
        }

        #endregion
    }
}
