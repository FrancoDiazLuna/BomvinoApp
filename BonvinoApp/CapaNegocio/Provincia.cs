using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class Provincia
    {
        #region [Atributos]

        private string nombre;
        private List<RegionVitivinicola> regionVitivinicola;
        private List<Provincia> provincia;
        private Pais pais;
        #endregion

        #region [Métodos get y set]

        public string Nombre { get => nombre; set => nombre = value; }
        public Pais Pais { get => pais; set => pais = value; }
        
#endregion

        /// <summary>
        /// Constructor de la clase Provincia
        /// </summary>
        /// <param name="nombre"></param>
        public Provincia(string nombre)
        {
            Nombre = nombre;
            Pais = pais;
        }



        #region [Métodos]

        //métodos propios de la clase
        private string obtenerPais() 
        {
            return Pais.Nombre;
        }

        #endregion
    }
}
