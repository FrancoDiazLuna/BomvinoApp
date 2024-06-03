using System.Collections.Generic;
using ClosedXML.Excel;

namespace BonvinoApp.CapaNegocio.FabricaciónPura
{
    public class InterfazExcel
    { 

        internal void generarExcel(Dictionary<Vino, float> top10)
        {
            // Ruta del archivo Excel
            string filePath = "RankingVinos.xlsx";

            // Crear un nuevo libro de Excel
            using (var workbook = new XLWorkbook())
            {
                // Agregar una hoja al libro
                var worksheet = workbook.Worksheets.Add("Top 10");

                // Definir los encabezados de las columnas
                worksheet.Cell(1, 1).Value = "Orden";
                worksheet.Cell(1, 2).Value = "NombreVino";
                worksheet.Cell(1, 3).Value = "CalificacionSomelier";
                worksheet.Cell(1, 4).Value = "PrecioSugerido";
                worksheet.Cell(1, 5).Value = "Bodega";
                worksheet.Cell(1, 6).Value = "Varietal";
                worksheet.Cell(1, 7).Value = "RegionVitivinicola";
                worksheet.Cell(1, 8).Value = "Pais";

                // Llenar los datos de las filas
                int i = 0;
                string varietal = "";
                foreach (var item in top10)
                {
                    i++;
                    worksheet.Cell(i + 2, 1).Value = i;
                    worksheet.Cell(i + 2, 2).Value = item.Key.Nombre;
                    worksheet.Cell(i + 2, 3).Value = item.Value;
                    worksheet.Cell(i + 2, 4).Value = item.Key.Precio;
                    worksheet.Cell(i + 2, 5).Value = item.Key.Bodega.Nombre;
                    foreach (var nombreVarietal in item.Key.Varietal)
                    {
                        varietal += nombreVarietal.Descripcion + ",";
                    }
                    worksheet.Cell(i + 2, 6).Value = varietal;
                    varietal = "";
                    worksheet.Cell(i + 2, 7).Value = item.Key.Bodega.RegionVitivinicola.Nombre;
                    worksheet.Cell(i + 2, 8).Value = item.Key.Bodega.RegionVitivinicola.Provincia.Pais.Nombre;
                }

                // Guardar el libro en el archivo Excel
                workbook.SaveAs(filePath);
            }
        }
    }
}
