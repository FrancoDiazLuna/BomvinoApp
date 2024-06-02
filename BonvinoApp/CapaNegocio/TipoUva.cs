using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    public class TipoUva
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
        /// Constructor de la clase TipoUva
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        public TipoUva(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}