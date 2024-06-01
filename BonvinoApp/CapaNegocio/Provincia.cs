using BonvinoApp.CapaDatos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class Provincia


    {
        #region [Atributos]

        private string nombre;
        private List<RegionVitivinicola> regionesVitivinicolas;

        #endregion

        #region [Métodos get y set]

        public string Nombre { get => nombre; set => nombre = value; }
        public List<RegionVitivinicola> RegionesVitivinicolas { get => regionesVitivinicolas; set => regionesVitivinicolas = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Provincia
        /// </summary>
        /// <param name="nombre"></param>
        public Provincia(string nombre, List<RegionVitivinicola> regionesVitivinicolas)
        {
            Nombre = nombre;
            this.regionesVitivinicolas = regionesVitivinicolas;
        }

        #region [Métodos]

        //métodos propios de la clase

        // Método para determinar a qué provincia pertenece una región vitivinícola
        public static Provincia ObtenerProvinciaDeRegion(RegionVitivinicola region)
        {
            foreach (RegionVitivinicola regionVitivinicola in regionesVitivinicolas)
            {
                if (regionVitivinicola == region)
                {
                    return this;
                }
            }
            return null; // Si no se encuentra la región en la lista, retorna null
        }

        #endregion
    }
}
