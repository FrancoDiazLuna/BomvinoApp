using BonvinoApp.CapaDatos;
using BonvinoApp.CapaPresentacion.Forms;
using System;
using System.Collections.Generic;

namespace BonvinoApp.CapaNegocio.Gestores
{
    class GestorGeneracionRankingVino
    {
        #region [Atributos]

        private PantallaGenerarRankingVino _pantallaGenerarRankingVino;
        private List<Vino> _listaVinos;
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;
        private string _tipoReseñaSeleccionada;
        private string _tipoVisualizacionSeleccionada;
        private List<Vino> _listaVinosFiltradosPeriodoSomelier;

        #endregion

        #region [Métodos get y set]

        public DateTime FechaDesde { get => _fechaDesde; set => _fechaDesde = value; }
        public DateTime FechaHasta { get => _fechaHasta; set => _fechaHasta = value; }

        #endregion

        public GestorGeneracionRankingVino(PantallaGenerarRankingVino pantallaGenerarRankingVino)
        {
            this._pantallaGenerarRankingVino = pantallaGenerarRankingVino;
            generalDAC general = new generalDAC();

            _listaVinos = general.returnVinos();
        }

        #region [Métodos]

        public void generarRankingVinos()
        {
            _pantallaGenerarRankingVino.solicitarFechaDesdeHasta();
        }

        public bool tomarFechaDesdeHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            this._fechaDesde = fechaDesde;
            this._fechaHasta = fechaHasta;

            _pantallaGenerarRankingVino.solicitarTipoReseña();

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
                _tipoReseñaSeleccionada = formato;
                _pantallaGenerarRankingVino.solicitarSeleccionFormaVisualizacion();
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
                _tipoVisualizacionSeleccionada = formato;
                _pantallaGenerarRankingVino.solicitarConfirmacionGeneracionReporte();
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
                ordenarVinosSegunCalificacion();
                //generarVisualizacion();
            }
        }

        private void buscarVinosConReseñaEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            foreach (Vino vino in _listaVinos)
            {
                if (vino.tenesReseñasDeTipoEnPeriodo(fechaDesde, fechaHasta))
                {
                    _listaVinosFiltradosPeriodoSomelier.Add(vino);
                }

                //Segun el diagrama, tenemos que buscar esta informacion de cada vino que cumpla con
                //el filtro anterior:
                //
                //var nombre = vino.Nombre;
                //var precio = vino.Precio;
                //var bodega = vino.buscarInfoBodega();
                //var varietal = vino.BuscarVarietal();
                //
                // si hacemos esto aca, como en el 1er diagrama de secuencia, tenemos que implementar 
                // un tipo de dato para almacenar toda esta informacion de cada uno de los vinos
            }
        }

        //A este metodo le falta guardar el puntaje objetino de cada uno de los vinos en alguna
        //estructura de datos, que podria ser la misma en la que guardamos los datos (nombre, precio, etc)
        //de cada vino.
        private void calcularPromedioCalificacion()
        {
            float puntaje;
            foreach (Vino vino in _listaVinosFiltradosPeriodoSomelier)
            {
                puntaje = vino.calcularPromedioCalificacion(FechaDesde, FechaHasta);
            }
        }

        private void ordenarVinosSegunCalificacion()
        {
            //implementar un metodo de ordenamiento para ordenar todos los vinos segun el puntaje obtenido
        }

        //Acá hay que implementar un patron de creacion/generación de visualizacion
        //por ej:
        //private void generarVisualizacion(){
        //  segun que se haya seleccionado, ejecuta alguno de los metodos de abajo
        //  pero se puede mejorar implementado algun patro de diseño
        //
        //  _pantallaGenerarRankingVino.informarGeneracionExitosaDeReporte()
        //}
        //private void generarExcel() { }
        //private void generarPDF() { }
        //private void generarPantalla() { }

        public void finCU()
        {
            _pantallaGenerarRankingVino.Close();
        }

        #endregion

    }
}
