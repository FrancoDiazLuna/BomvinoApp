using BonvinoApp.CapaDatos;
using BonvinoApp.CapaPresentacion;
using BonvinoApp.CapaPresentacion.Forms;
using System;
using System.Collections.Generic;
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
        private InterfazExcel interfazExcel;

        private Dictionary<Vino, float> vinosConPuntajes = new Dictionary<Vino, float>();
        private List<String> top10Vino = new List<string>();
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

        public void tomarTipoReseña(int tipoReseñaSeleccionada)
        {
            var formatos = new Dictionary<int, string>
            {
                { 1, "Normal" },
                { 2, "Sommelier" },
                { 3, "Amigos" }
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
                { 1, "Excel" },
                { 2, "PDF" },
                { 3, "Pantalla" }
            };

            if (formatos.TryGetValue(formatoSeleccionado, out var formato))
            {
                tipoVisualizacionSeleccionada = formato;
                pantallaGenerarRankingVino.solicitarConfirmacionGeneracionReporte();
            }
            else
            {
                // Manejar el caso de formato no válido si es necesario
                throw new ArgumentOutOfRangeException(nameof(formatoSeleccionado), "Formato de Visualización no válido.");
            }
        }

        public bool tomarConfirmacionGeneracionReporte()
        {
            bool hayVinosConReseña = buscarVinosConReseñaEnPeriodo(FechaDesde, FechaHasta);
            if (!hayVinosConReseña)
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

            if (listaVinosFiltradosPeriodoSomelier == null || !listaVinosFiltradosPeriodoSomelier.Any())
            {
                return false;
            }

            return true;
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

            var topVinos = vinosConPuntajes.OrderByDescending(vino => vino.Value).Take(top).ToList();

            vinosConPuntajes.Clear();
            foreach (var vino in topVinos)
            {
                vinosConPuntajes[vino.Key] = vino.Value;
            }
        }

        private void generarVisualizacionDeReporte(string visualizacion)
        {
            switch (visualizacion)
            {
                case "Excel":
                    generarExcel(vinosConPuntajes);
                    break;
                case "PDF":
                    generarPDF(vinosConPuntajes);
                    break;
                case "Pantalla":
                    generarPantalla(vinosConPuntajes);
                    break;
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
            int orden = 0;
            string varietal = "";
            foreach (var vino in top10)
            {
                orden++;
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
