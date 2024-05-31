using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class Reseña
    {
        #region [Atributos]

        private string _comentario;
        private bool _esPremium;
        private DateTime _fechaReseña;
        private float _puntaje;

        #endregion

        #region [Métodos get y set]

        public string Comentario { get => _comentario; set => _comentario = value; }
        public bool EsPremium { get => _esPremium; set => _esPremium = value; }
        public DateTime FechaReseña { get => _fechaReseña; set => _fechaReseña = value; }
        public float Puntaje { get => _puntaje; set => _puntaje = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase TipoReseña
        /// </summary>
        /// <param name="comentario"></param>
        /// <param name="esPremium"></param>
        /// <param name="fechaReseña"></param>
        /// <param name="puntaje"></param>
        public Reseña(string comentario, bool esPremium, DateTime fechaReseña, float puntaje)
        {
            Comentario = comentario;
            EsPremium = esPremium;
            FechaReseña = fechaReseña;
            Puntaje = puntaje;
        }

        #region [Métodos]

        public bool sosDePeriodo(DateTime fechaDesde, DateTime fechaHasta) {
            return FechaReseña >= fechaDesde && FechaReseña <= fechaHasta;
        }
    
        public bool sosDeSommelier() 
        {
            return EsPremium;
        }

        #endregion
    }

}
