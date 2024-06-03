using System.Collections.Generic;
using System.Linq;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace BonvinoApp.CapaNegocio.FabricaciónPura
{
    public class InterfazPdf
    {
        internal void generarPdf(Dictionary<Vino, float> data)
        {
            // Ruta del archivo PDF
            string filePath = "RankingVinos.pdf";

            // Crear un nuevo documento PDF
            PdfDocument document = new PdfDocument();

            // Añadir una página al documento
            PdfPage page = document.AddPage();

            // Obtener el objeto Graphics para la página
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Definir la fuente
            XFont font = new XFont("Verdana", 6);

            // Definir la posición inicial para dibujar
            XPoint point = new XPoint(40, 40);

            // Dibujar el título
            gfx.DrawString("Ranking de Vinos", font, XBrushes.Black, point);
            point.Y += 20;

            // Dibujar los datos de los vinos
            int i = 1;
            foreach (var vino in data)
            {
                // Verificar si hay suficiente espacio en la página para dibujar los datos del vino
                if (point.Y + 120 > page.Height)
                {
                    // Agregar una nueva página al documento
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    point = new XPoint(40, 40);
                    gfx.DrawString("Ranking de Vinos", font, XBrushes.Black, point);
                    point.Y += 20;
                }

                gfx.DrawString("Orden " + i, font, XBrushes.Black, point);
                point.Y += 20;
                gfx.DrawString("NombreVino: " + vino.Key.Nombre, font, XBrushes.Black, point);
                point.Y += 20;
                gfx.DrawString("CalificaciónSomelier: " + vino.Value, font, XBrushes.Black, point);
                point.Y += 20;
                gfx.DrawString("PrecioSugerido: $" + vino.Key.Precio, font, XBrushes.Black, point);
                point.Y += 20;
                gfx.DrawString("Bodega: " + vino.Key.Bodega.Nombre, font, XBrushes.Black, point);
                point.Y += 20;

                // Concatenar las descripciones de los varietales
                string varietales = string.Join(", ", vino.Key.Varietal.Select(varietal => varietal.Descripcion));
                gfx.DrawString("Varietal: " + varietales, font, XBrushes.Black, point);
                point.Y += 20;

                gfx.DrawString("RegiónVitivinicola: " + vino.Key.Bodega.RegionVitivinicola.Nombre, font, XBrushes.Black, point);
                point.Y += 20;
                gfx.DrawString("País: " + vino.Key.Bodega.RegionVitivinicola.Provincia.Pais.Nombre, font, XBrushes.Black, point);
                point.Y += 40;

                i++;
            }

            // Guardar el documento en el archivo PDF
            document.Save(filePath);
        }

    }
}
