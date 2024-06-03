using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BonvinoApp.CapaNegocio;

namespace BonvinoApp.CapaPresentacion.Forms
{
    public partial class VisualizacionPantalla : Form
    {

        public VisualizacionPantalla()
        {
            InitializeComponent();
            dgvRankingVinos.Rows.Clear();
        }

        public void cargarDatosEnPantalla(string order, string nombre, string calificacionSommelier, string precioSugerido, string bodega, string varietal, string region, string pais)
        {
            dgvRankingVinos.Rows.Add(order, nombre, calificacionSommelier, precioSugerido, bodega, varietal, region, pais);
        }
    }
}
