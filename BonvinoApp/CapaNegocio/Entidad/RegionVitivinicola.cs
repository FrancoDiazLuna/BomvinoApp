
namespace BonvinoApp.CapaNegocio
{
    class RegionVitivinicola
    {
        #region [Atributos]

        private string nombre;
        private string descripcion;
        private Provincia provincia;

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
        /// <param name="provincia"></param>
        /// <param name="descripcion"></param>
        public RegionVitivinicola(string nombre, Provincia provincia, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Provincia = provincia;
        }


        #region [Métodos]

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
