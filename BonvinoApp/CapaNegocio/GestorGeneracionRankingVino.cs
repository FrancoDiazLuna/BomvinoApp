using BonvinoApp.CapaDatos;
using BonvinoApp.CapaPresentacion.Forms;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace BonvinoApp.CapaNegocio.Gestores
{
    class GestorGeneracionRankingVino
    {
        #region [Atributos]
        private PantallaGenerarRankingVino pantallaGenerarRankingVino;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        SeleccionResenasForm.TipoResena tipoReseña;
        SeleccionFormatoForm.FormatoSeleccion formatoSeleccionVisualizacion;
        List<Vino> listaVinos;
        List<Vino> listaVinosFiltradosPeriodoSomelier;

        //todos los demas atributos

        #endregion

        public GestorGeneracionRankingVino(PantallaGenerarRankingVino pantallaGenerarRankingVino)
        {
            this.pantallaGenerarRankingVino = pantallaGenerarRankingVino;
            generalDAC general = new generalDAC();

            listaVinos = general.returnVinos();
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

        internal void tomarSeleccionFormaVisualizacion(SeleccionFormatoForm.FormatoSeleccion formatoSeleccionado)
        {
            this.formatoSeleccionVisualizacion = formatoSeleccionado;
            pantallaGenerarRankingVino.solicitarConfirmacionGeneracionReporte();
        }

        public void buscarVinosConReseñaEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<string[]> datosVinos = new List<string[]>();

            foreach (var vino in listaVinos)
            {
                if (vino.TenesReseñasDeTipoEnPeriodo(fechaDesde, fechaHasta, vino))
                {
                    String bodega = vino.BuscarInfoBodega();
                    datosVinos.Add(new string[] { vino.Nombre, vino.Precio.ToString(), bodega });
                }
            }

            GenerarExcel(datosVinos);

        }

        public static void GenerarExcel(List<string[]> datos)
        {
            // Crear un nuevo archivo Excel
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Agregar una hoja al archivo Excel
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Vinos");

                // Escribir los datos en la hoja de Excel
                for (int i = 0; i < datos.Count; i++)
                {
                    for (int j = 0; j < datos[i].Length; j++)
                    {
                        worksheet.Cells[i + 1, j + 1].Value = datos[i][j];
                    }
                }

                // Guardar el archivo Excel
                FileInfo excelFile = new FileInfo("Vinos.xlsx");
                excelPackage.SaveAs(excelFile);
            }

            Console.WriteLine("Archivo Excel generado exitosamente.");
        }

        public void calcularPjeDeSommelierEnPeriodo() { }

        public void ordenarVinosSegunCalificacion() { }

        public void generarExcel() { }

        public void finCU() { }

        internal void tomarTipoReseñaSommelier(SeleccionResenasForm.TipoResena resenaSeleccionada)
        {
            this.tipoReseña = resenaSeleccionada;
            pantallaGenerarRankingVino.solicitarSeleccionFormaVisualizacion();
        }

        internal void tomarConfirmacionGeneracionReporte(bool confirmacion)
        {
            if (confirmacion)
            {
                buscarVinosConReseñaEnPeriodo(fechaDesde, fechaHasta);
            }
        }

        #endregion

    }
}
