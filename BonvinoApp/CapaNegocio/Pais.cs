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
        private List<Pais> pais;
        private Provincia provincia;

        #endregion

        #region [Métodos get y set]

        public string Nombre { get => nombre; set => nombre = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Pais
        /// </summary>
        /// <param name="nombre"></param>
        public Pais(string nombre)
        {
            Nombre = nombre;
        }

        #region [Métodos]

        //métodos propios de la clase

        private string getNombre()
        {
            return Nombre;
        }

        #endregion
    }
}
