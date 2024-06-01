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

        private string comentario;
        private bool esPremium;
        private DateTime fechaReseña;
        private float puntaje;
        private TipoReseña tipoReseña;
        private Vino vino;

        #endregion

        #region [Métodos get y set]

        public string Comentario { get => comentario; set => comentario = value; }
        public bool EsPremium { get => esPremium; set => esPremium = value; }
        public DateTime FechaReseña { get => fechaReseña; set => fechaReseña = value; }
        public float Puntaje { get => puntaje; set => puntaje = value; }
        internal TipoReseña TipoReseña { get => tipoReseña; set => tipoReseña = value; }

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

        //métodos propios de la clase
        private bool sosDePeriodo(DateTime fechaDesde, DateTime fechaHasta) {
            return FechaReseña >= fechaDesde && FechaReseña <= fechaHasta;
        }

    
        private bool sosDeSommelier() 
        {
            return esPremium
        }
        private float getPje() { }


        #endregion
    }

}
