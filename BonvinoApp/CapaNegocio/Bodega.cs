using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class Bodega
    {
        #region [Atributos]

        private string coordenadasUbicacion;
        private string descripcion;
        private string historia;
        private string nombre;
        private RegionVitivinicola region;
        private int periodoActualizacion; //no tengo idea que es esto, le mande int

        #endregion

        #region [Métodos get y set]
        public string CoordenadasUbicacion { get => coordenadasUbicacion; set => coordenadasUbicacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Historia { get => historia; set => historia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PeriodoActualizacion { get => periodoActualizacion; set => periodoActualizacion = value; }
        internal RegionVitivinicola Region { get => region; set => region = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Bodega
        /// </summary>
        /// <param name="coordenadasUbicacion"></param>
        /// <param name="descripcion"></param>
        /// <param name="historia"></param>
        /// <param name="nombre"></param>
        /// <param name="periodoActualizacion"></param>
        public Bodega(string coordenadasUbicacion, string descripcion, string historia, string nombre, int periodoActualizacion, RegionVitivinicola region)
        {
            CoordenadasUbicacion = coordenadasUbicacion;
            Descripcion = descripcion;
            Historia = historia;
            Nombre = nombre;
            PeriodoActualizacion = periodoActualizacion;
            this.region = region;
        }

        internal string obtenerRegionYPais()
        {
            region.obtenerPais();
            return region.Nombre;
        }

        #region [Métodos]

        //métodos propios de la clase

        #endregion
    }
}
