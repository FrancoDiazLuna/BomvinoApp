using BonvinoApp.CapaDatos;
using BonvinoApp.CapaPresentacion.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BonvinoApp.CapaNegocio.Gestores
{
    class GestorGeneracionRankingVino
    {
        #region [Atributos]

        private PantallaGenerarRankingVino pantallaGenerarRankingVino;
        private List<Vino> listaVinos;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private string tipoReseñaSeleccionada;
        private string tipoVisualizacionSeleccionada;
        private List<Vino> listaVinosFiltradosPeriodoSomelier;
        
        private List<DatosVisualizacion> datos = new List<DatosVisualizacion>();

        #endregion

        #region [Métodos get y set]

        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }

        #endregion

        public GestorGeneracionRankingVino(PantallaGenerarRankingVino pantallaGenerarRankingVino)
        {
            this.pantallaGenerarRankingVino = pantallaGenerarRankingVino;
            listaVinos = generalDAC.listarVinos();
        }

        #region [Métodos]

        public void generarRankingVinos()
        {
            pantallaGenerarRankingVino.solicitarFechaDesdeHasta();
        }

        public bool tomarFechaDesdeHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;

            pantallaGenerarRankingVino.solicitarTipoReseña();

            return true;
        }

        public void tomarTipoReseña(int tipoReseñaSeleccionada)
        {
            var formatos = new Dictionary<int, string>
            {
                { 0, "Normal" },
                { 1, "Sommelier" },
                { 2, "Amigos" }
            };

            if (formatos.TryGetValue(tipoReseñaSeleccionada, out var formato))
            {
                this.tipoReseñaSeleccionada = formato;
                pantallaGenerarRankingVino.solicitarSeleccionFormaVisualizacion();
            }
            else
            {
                // Manejar el caso de formato no válido si es necesario
                throw new ArgumentOutOfRangeException(nameof(tipoReseñaSeleccionada), "Tipo de Reseña no válido.");
            }
        }

        public void tomarSeleccionFormaVisualizacion(int formatoSeleccionado)
        {
            var formatos = new Dictionary<int, string>
            {
                { 0, "Excel" },
                { 1, "PDF" },
                { 2, "Pantalla" }
            };

            if (formatos.TryGetValue(formatoSeleccionado, out var formato))
            {
                tipoVisualizacionSeleccionada = formato;
                pantallaGenerarRankingVino.solicitarConfirmacionGeneracionReporte();
            } else
            {
                // Manejar el caso de formato no válido si es necesario
                throw new ArgumentOutOfRangeException(nameof(formatoSeleccionado), "Formato de Visualización no válido.");
            }
        }

        public void tomarConfirmacionGeneracionReporte(bool confirmacion)
        {
            if (confirmacion)
            {
                buscarVinosConReseñaEnPeriodo(FechaDesde, FechaHasta);
                calcularPromedioCalificacion();
                List<DatosVisualizacion> datos = ordenarVinosSegunCalificacion();
                generarVisualizacionDeReporte(tipoVisualizacionSeleccionada,datos);
            }
        }

        private void buscarVinosConReseñaEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            foreach (Vino vino in listaVinos)
            {
                if (vino.tenesReseñasDeTipoEnPeriodo(fechaDesde, fechaHasta))
                {
                    listaVinosFiltradosPeriodoSomelier.Add(vino);
                }
            }
        }

        private void calcularPromedioCalificacion()
        {
            foreach (Vino vino in listaVinosFiltradosPeriodoSomelier)
            {
                float puntaje = vino.calcularPromedioCalificacion(FechaDesde, FechaHasta);

                datos.Add(new DatosVisualizacion(vino, puntaje));
            }
        }

        private List<DatosVisualizacion> ordenarVinosSegunCalificacion()
        {
            datos.OrderByDescending(vino => vino.CalificacionSommelier);

            List<DatosVisualizacion> top10 = datos.Take(10).ToList();

            foreach (DatosVisualizacion dato in top10)
            {
                dato.Nombre = dato.Vino.Nombre;
                dato.PrecioSugerido = dato.Vino.Precio;
                dato.Bodega = dato.Vino.Bodega.Nombre;
                //dato.Variertal = dato.Vino.Varietal.Nombre;
                //dato.Region = dato.Vino.Bodega.RegionVitivinicola.Nombre;
                //dato.Pais = dato.Vino.Bodega.RegionVitivinicola.Provincia.Pais.Nombre;
            }
            
            return top10;
        }

        private void generarVisualizacionDeReporte(string visualizacion, List<DatosVisualizacion> datos)
        {
            switch (visualizacion)
            {
                case "Excel":
                    generarExcel(datos);
                    break;
                case "PDF":
                    generarPDF(datos);
                    break;
                case "Pantalla":
                    generarPantalla(datos);
                    break;                
            }

            pantallaGenerarRankingVino.informarGeneracionExitosaDeReporte();
        }
        private void generarExcel(List<DatosVisualizacion> datos) 
        {
            //implementar esto
            //generarExcel
        }
        private void generarPDF(List<DatosVisualizacion> datos)
        {
            //implementar esto
            //generar el PDF
        }
        private void generarPantalla(List<DatosVisualizacion> datos)
        {
            //implementar esto
            //generar una instancia del Form VisualizacionPantalla
        }

        public void finCU()
        {
            pantallaGenerarRankingVino.Close();
        }

        #endregion

    }
}
