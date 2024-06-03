using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace BonvinoApp.CapaNegocio
{
    class Vino
    {
        #region [Atributos]

        private string imagenEtiqueta;
        private int añada;
        private string nombre;
        private string notaDeCataBodega;
        private float precio;
        private List<Varietal> varietal;
        private Bodega bodega;
        private List<Reseña> reseñas;

        private List<Reseña> reseñasFiltradas;

        #endregion

        #region [Métodos get y set]

        public string ImagenEtiqueta { get => imagenEtiqueta; set => imagenEtiqueta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
        public float Precio { get => precio; set => precio = value; }
        public List<Reseña> Reseñas { get => reseñas; set => reseñas = value; }
        public List<Varietal> Varietal { get => varietal; set => varietal = value; }
        public Bodega Bodega { get => bodega; set => bodega = value; }
        public int Añada { get => añada; set => añada = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Vino
        /// </summary>
        /// <param name="imagenEtiqueta"></param>
        /// <param name="nombre"></param>
        /// <param name="notaDeCataBodega"></param>
        /// <param name="precio"></param>
        public Vino(string imagenEtiqueta, int añada, string nombre, string notaDeCataBodega, float precio, List<Varietal> varietales, List<Reseña> reseñas, Bodega bodega)
        {
            ImagenEtiqueta = imagenEtiqueta;
            Añada = añada;
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

            foreach (Reseña reseña in reseñas)
            {
                if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier())
                {
                    response = true;
                    break;
                }
            }           

            return response;
        }

        /// <summary>
        /// Busca información del varietal.
        /// </summary>
        public List<string> buscarVarietal()
        {
            List<string> descripcionVarietales = new List<string>();
            foreach (Varietal varietal in varietal)
            {
                descripcionVarietales.Add(varietal.Descripcion);
            }

            return descripcionVarietales;
        }

        /// <summary>
        /// Calcula el puntaje promedio de las reseñas de sommelier en un período determinado.
        /// </summary>
        public float calcularPromedioCalificacion(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<float> puntajes = new List<float>();

            foreach (Reseña reseña in reseñas)
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
