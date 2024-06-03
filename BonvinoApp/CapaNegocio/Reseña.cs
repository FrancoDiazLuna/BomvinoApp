using System;

namespace BonvinoApp.CapaNegocio
{
    class Reseña
    {
        #region [Atributos]

        private string comentario;
        private bool esPremium;
        private DateTime fechaReseña;
        private float puntaje;
        private Vino vino;

        #endregion

        #region [Métodos get y set]

        public string Comentario { get => comentario; set => comentario = value; }
        public bool EsPremium { get => esPremium; set => esPremium = value; }
        public DateTime FechaReseña { get => fechaReseña; set => fechaReseña = value; }
        public float Puntaje { get => puntaje; set => puntaje = value; }
        internal Vino Vino { get => vino; set => vino = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Reseña
        /// </summary>
        /// <param name="comentario"></param>
        /// <param name="esPremium"></param>
        /// <param name="fechaReseña"></param>
        /// <param name="puntaje"></param>
        /// <param name="vino"></param>
        public Reseña(string comentario, bool esPremium, DateTime fechaReseña, float puntaje, Vino vino)
        {
            Comentario = comentario;
            EsPremium = esPremium;
            FechaReseña = fechaReseña;
            Puntaje = puntaje;
            Vino = vino;
        }

        #region [Métodos]

        public bool sosDePeriodo(DateTime fechaDesde, DateTime fechaHasta) {
            return FechaReseña >= fechaDesde && FechaReseña <= fechaHasta;
        }

        public bool sosDeSommelier() 
        {
            return esPremium;
        }

        #endregion
    }

}
