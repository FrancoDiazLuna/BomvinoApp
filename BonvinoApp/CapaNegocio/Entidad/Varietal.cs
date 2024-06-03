
namespace BonvinoApp.CapaNegocio
{
    class Varietal
    {
        #region [Atributos]

        private string descripcion;
        private float porcentaje;
        private TipoUva tipoUva;

        #endregion

        #region [Métodos get y set]

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Porcentaje { get => porcentaje; set => porcentaje = value; }
        public TipoUva TipoUva { get => tipoUva; set => tipoUva = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Varietal
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="porcentaje"></param>
        public Varietal(string descripcion, float porcentaje, TipoUva tipoUva)
        {
            Descripcion = descripcion;
            Porcentaje = porcentaje;
            TipoUva = tipoUva;
        }


        #region [Métodos]

        public string getDescripcion() { return Descripcion; }

        #endregion
    }
}
