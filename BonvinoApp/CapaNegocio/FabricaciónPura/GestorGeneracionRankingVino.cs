using BonvinoApp.CapaDatos;
using BonvinoApp.CapaPresentacion.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BonvinoApp.CapaNegocio.FabricaciónPura
{
    class GestorGeneracionRankingVino
    {
        #region [Atributos]

        private PantallaGenerarRankingVino pantallaGenerarRankingVino;
        private List<Vino> listaVinos;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private TipoReseña tipoReseñaSeleccionada;
        private TipoVisualizacion tipoVisualizacionSeleccionada;
        private List<Vino> listaVinosFiltradosPeriodoSomelier;

        private Dictionary<Vino, float> vinosConPuntajes = new Dictionary<Vino, float>();
        private InterfazExcel interfazExcel;
        private InterfazPdf interfazPdf;

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

        public void tomarFechaDesdeHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;

            pantallaGenerarRankingVino.solicitarTipoReseña();
        }

        public void tomarTipoReseña(TipoReseña tipoReseñaSeleccionada)
        {
            this.tipoReseñaSeleccionada = tipoReseñaSeleccionada;
            pantallaGenerarRankingVino.solicitarSeleccionFormaVisualizacion();
        }

        public void tomarSeleccionFormaVisualizacion(TipoVisualizacion tipoVisualizacionSeleccionada)
        {
            this.tipoVisualizacionSeleccionada = tipoVisualizacionSeleccionada;
            pantallaGenerarRankingVino.solicitarConfirmacionGeneracionReporte();
        }

        public bool tomarConfirmacionGeneracionReporte()
        {
            if (!buscarVinosConReseñaEnPeriodo(FechaDesde, FechaHasta))
            {
                return false;
            }

            calcularPromedioCalificacion();
            ordenarVinosSegunCalificacion();
            generarVisualizacionDeReporte(tipoVisualizacionSeleccionada);

            return true;
        }

        private bool buscarVinosConReseñaEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            listaVinosFiltradosPeriodoSomelier = new List<Vino>();

            foreach (Vino vino in listaVinos)
            {
                if (vino.tenesReseñasDeTipoEnPeriodo(fechaDesde, fechaHasta))
                {
                    listaVinosFiltradosPeriodoSomelier.Add(vino);
                }
            }

            return listaVinosFiltradosPeriodoSomelier.Any();
        }

        private void calcularPromedioCalificacion()
        {
            foreach (Vino vino in listaVinosFiltradosPeriodoSomelier)
            {
                float puntaje = vino.calcularPromedioCalificacion(FechaDesde, FechaHasta);
                vinosConPuntajes[vino] = puntaje;
            }
        }

        private void ordenarVinosSegunCalificacion()
        {
            int top = 10;

            vinosConPuntajes = vinosConPuntajes
                        .OrderByDescending(vino => vino.Value)
                        .Take(top)
                        .ToDictionary(v => v.Key, v => v.Value);
        }

        private void generarVisualizacionDeReporte(TipoVisualizacion visualizacion)
        {
            switch (visualizacion)
            {
                case TipoVisualizacion.Excel:
                    generarExcel(vinosConPuntajes);
                    break;
                case TipoVisualizacion.PDF:
                    generarPDF(vinosConPuntajes);
                    break;
                case TipoVisualizacion.Pantalla:
                    generarPantalla(vinosConPuntajes);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(visualizacion), "Tipo de Visualización no válido.");
            }

            pantallaGenerarRankingVino.informarGeneracionExitosaDeReporte();
        }
        private void generarExcel(Dictionary<Vino, float> top10)
        {
            interfazExcel = new InterfazExcel();
            interfazExcel.generarExcel(top10);
        }
        private void generarPDF(Dictionary<Vino, float> top10)
        {
            interfazPdf = new InterfazPdf();
            interfazPdf.generarPdf(top10);
        }
        private void generarPantalla(Dictionary<Vino, float> top10)
        {
            VisualizacionPantalla visualizacionPantalla = new VisualizacionPantalla();
            int orden = 1;
            string varietal = "";
            foreach (var vino in top10)
            {
                string nombreVino = vino.Key.Nombre;
                string calificacionSomelier = vino.Value.ToString();
                string precioSugerido = vino.Key.Precio.ToString();
                string bodega = vino.Key.Bodega.Nombre.ToString();
                foreach (var nombreVarietal in vino.Key.Varietal)
                {
                    varietal += nombreVarietal.Descripcion + ",";
                }
                string regionVitivinicola = vino.Key.Bodega.RegionVitivinicola.Nombre;
                string pais = vino.Key.Bodega.RegionVitivinicola.Provincia.Pais.Nombre;
                visualizacionPantalla.cargarDatosEnPantalla(orden.ToString(), nombreVino, calificacionSomelier, precioSugerido, bodega, varietal, regionVitivinicola, pais);
                orden++;
                varietal = "";
            }
            visualizacionPantalla.Show();
        }

        public void finCU()
        {
            pantallaGenerarRankingVino.Close();
        }

        #endregion

    }   
}
