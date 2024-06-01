using System;
using System.Collections.Generic;

namespace BonvinoApp.CapaNegocio
{
    class Vino
    {
        #region [Atributos]

        private int _añada;
        private string _imagenEtiqueta;
        private string _nombre;
        private string _notaDeCataBodega; //esto es una descripcion
        private float _precioARS;
        private List<Varietal> _varietal;
        private Bodega _bodega;
        private List<Reseña> _reseñas;

        private List<Reseña> _reseñasFiltradas;

        #endregion

        #region [Métodos get y set]

        public int Añada { get => _añada; set => _añada = value; }
        public string ImagenEtiqueta { get => _imagenEtiqueta; set => _imagenEtiqueta = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string NotaDeCataBodega { get => _notaDeCataBodega; set => _notaDeCataBodega = value; }
        public float Precio { get => _precioARS; set => _precioARS = value; }
        public List<Reseña> Reseñas { get => _reseñas; set => _reseñas = value; }
        public List<Varietal> Varietal { get => _varietal; set => _varietal = value; }
        public Bodega Bodega { get => _bodega; set => _bodega = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Vino
        /// </summary>
        /// <param name="añadaImagenEtiqueta"></param>
        /// <param name="nombre"></param>
        /// <param name="notaDeCataBodega"></param>
        /// <param name="precio"></param>
        public Vino(int añada, string imagenEtiqueta, string nombre, string notaDeCataBodega, float precio, List<Varietal> varietales, List<Reseña> reseñas, Bodega bodega)
        {
            Añada = añada;
            ImagenEtiqueta = imagenEtiqueta;
            Nombre = nombre;
            NotaDeCataBodega = notaDeCataBodega;
            Precio = precio;
            Varietal = varietales;
            Bodega = bodega;
            Reseñas = reseñas;
        }


        #region [Métodos]


        public bool tenesReseñasDeTipoEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            bool response = false;

            foreach (Reseña reseña in _reseñas)
            {
                if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier())
                {
                    response = true;
                    break; // Salir del bucle interno ya que encontramos una reseña que cumple con las condiciones
                }
            }           

            return response;
        }

        /// <summary>
        /// Obtiene el nombre del vino.
        /// </summary>
        /// <returns>Nombre del vino</returns>
        public string getNombre()
        {
            return Nombre;
        }

        /// <summary>
        /// Obtiene el precio del vino.
        /// </summary>
        /// <returns>Precio del vino</returns>
        public float getPrecio()
        {
            return Precio;
        }

        /// <summary>
        /// Busca información del varietal.
        /// </summary>
        public void buscarVarietal()
        {
            // Lógica para buscar información del varietal
        }

        /// <summary>
        /// Calcula el puntaje promedio de las reseñas de sommelier en un período determinado.
        /// </summary>
        public float calcularPromedioCalificacion(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<float> puntajes = new List<float>();

            foreach (Reseña reseña in _reseñas)
            {
                if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier())
                {
                    puntajes.Add(reseña.Puntaje);
                }
            }

            return calcularPuntajePromedio(puntajes);
        }

        private float calcularPuntajePromedio(List<float> puntajes)
        {
            int cantidad = 0;
            float suma = 0;
            foreach (float puntaje in puntajes)
            {
                suma += puntaje;
                cantidad++;
            }

            if (cantidad != 0)
            {
                return (suma / cantidad);
            }

            return 0;
        }

        #endregion
    }
}
