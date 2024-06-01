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
        private Pais pais;
        #endregion

        #region [Métodos get y set]

        public string Nombre { get => nombre; set => nombre = value; }
        public Pais Pais { get => pais; set => pais = value; }
        public List<RegionVitivinicola> RegionVitivinicola { get => regionVitivinicola; set => regionVitivinicola = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Provincia
        /// </summary>
        /// <param name="nombre"></param>
        public Provincia(string nombre, Pais pais)
        {
            Nombre = nombre;
            Pais = pais;
            RegionVitivinicola = new List<RegionVitivinicola>() ;
        }



        #region [Métodos]

        //métodos propios de la clase
        private string obtenerPais() 
        {
            return Pais.Nombre;
        }

        public void agregarRegion(RegionVitivinicola region)
        {
            RegionVitivinicola.Add(region);
        }

        #endregion
    }
}
