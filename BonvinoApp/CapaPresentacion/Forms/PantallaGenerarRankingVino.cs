using System;
using System.Windows.Forms;
using BonvinoApp.CapaNegocio.FabricaciónPura;

namespace BonvinoApp.CapaPresentacion.Forms
{
    public partial class PantallaGenerarRankingVino : Form
    {
        #region [Atributos]

        private GestorGeneracionRankingVino gestorRankingVinos;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private TipoReseña tipoReseñaSeleccionada;
        private TipoVisualizacion tipoVisualizacionSeleccionada;

        #endregion

        public PantallaGenerarRankingVino()
        {
            habilitarPantalla();
            gestorRankingVinos = new GestorGeneracionRankingVino(this);
        }

        #region [Métodos]

        /// <summary>
        /// Renderiza todos los componentes de la pantalla
        /// </summary>
        public void habilitarPantalla()
        {
            InitializeComponent();
            DateTime date = DateTime.Today;
            dtpFechaDesde.Value = date;
            dtpFechaHasta.Value = date;
        }

        public void solicitarFechaDesdeHasta()
        {
            gpbFiltroFechas.Enabled = true;
        }

        private void btnSeleccionarFechas_Click(object sender, EventArgs e)
        {
            fechaDesde = dtpFechaDesde.Value;
            fechaHasta = dtpFechaHasta.Value;

            if (validarPeriodo(fechaDesde, fechaHasta))
            {
                gestorRankingVinos.tomarFechaDesdeHasta(fechaDesde, fechaHasta);                
            }
            else
            {
                MessageBox.Show("Debe seleccionar una periodo de fechas válido.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarCampos(true, true, true);
            }
        }

        /// <summary>
        /// Valida dos fechas para asegurar que la fecha desde no sea posterior a la fecha hasta
        /// y que ninguna de las fechas sea futura en relación a la fecha actual.
        /// </summary>
        /// <param name="fechaDesde">La fecha de inicio a validar.</param>
        /// <param name="fechaHasta">La fecha de fin a validar.</param>
        /// <returns>
        /// True si la fecha está dentro de un período válido, False en caso contrario.
        /// </returns>
        private bool validarPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            DateTime fechaActual = DateTime.Now;

            return (fechaDesde <= fechaActual && fechaHasta >= fechaDesde) ? true : false;
        }

        public void solicitarTipoReseña()
        {
            gpbTipoReseña.Enabled = true;
        }

        private void btnTipoReseña_Click(object sender, EventArgs e)
        {   
            int tipoReseñaSeleccionadaIndex = cmbTipoReseña.SelectedIndex;

            if (tipoReseñaSeleccionadaIndex >= 0 && tipoReseñaSeleccionadaIndex < Enum.GetNames(typeof(TipoReseña)).Length)
            {
                var tipoReseña = (TipoReseña)(tipoReseñaSeleccionadaIndex + 1);
                gestorRankingVinos.tomarTipoReseña(tipoReseña);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un formato de visualización.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarCampos(false, false, true);
            }
        }

        public void solicitarSeleccionFormaVisualizacion()
        {
            gpbVisualización.Enabled = true;
        }

        private void btnTipoVisualizacion_Click(object sender, EventArgs e)
        {
            if (rbtExcel.Checked)
            {
                tipoVisualizacionSeleccionada = TipoVisualizacion.Excel;
                MessageBox.Show("Seleccionado Excel.");
            }
            else if (rbtPDF.Checked)
            {
                tipoVisualizacionSeleccionada = TipoVisualizacion.PDF;
                MessageBox.Show("Seleccionado PDF.");
            }
            else if (rbtPantalla.Checked)
            {
                tipoVisualizacionSeleccionada = TipoVisualizacion.Pantalla;
                MessageBox.Show("Seleccionado Pantalla.");
            }

            gestorRankingVinos.tomarSeleccionFormaVisualizacion(tipoVisualizacionSeleccionada);
        }

        public void solicitarConfirmacionGeneracionReporte()
        {
            btnConfirmar.Enabled = true;            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool response = gestorRankingVinos.tomarConfirmacionGeneracionReporte();

            if (!response)
            {
                MessageBox.Show("No hay reseñas en el periodo seleccionado.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarCampos(true, true, true);
            }
        }

        public void informarGeneracionExitosaDeReporte()
        {
            MessageBox.Show("Se ha generado exitosamente su reporte.");
            gestorRankingVinos.finCU();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gestorRankingVinos.finCU();
        }

        /// <summary>
        /// Método para limpiar campos
        /// </summary>
        public void limpiarCampos(bool fechas, bool tipoReseña, bool visualizacion)
        {
            if (fechas)
            {
                DateTime date = DateTime.Today;
                dtpFechaDesde.Value = date;
                dtpFechaHasta.Value = date;
            }

            if (tipoReseña)
            {
                cmbTipoReseña.SelectedItem = null;
                gpbTipoReseña.Enabled = false;
            }

            if (visualizacion)
            {
                gpbVisualización.Enabled = false;
                rbtExcel.Checked = false;
                rbtPDF.Checked = false;
                rbtPantalla.Checked = false;
            }
            
            btnConfirmar.Enabled = false;
            
        }

        private void cmbTipoReseña_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarCampos(false, false, true);
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            limpiarCampos(false, true, true);
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            limpiarCampos(false, true, true);
        }


        #endregion
    }
}
