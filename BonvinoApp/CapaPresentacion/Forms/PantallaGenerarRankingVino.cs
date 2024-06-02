using BonvinoApp.CapaNegocio.Gestores;
using System;
using System.Windows.Forms;

namespace BonvinoApp.CapaPresentacion.Forms
{
    public partial class PantallaGenerarRankingVino : Form
    {
        #region [Atributos]

        private GestorGeneracionRankingVino gestorRankingVinos;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private int tipoReseñaSeleccionada;
        private int tipoVisualizacionSeleccionada;

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

            bool response = false;

            if (validarPeriodo(fechaDesde, fechaHasta))
            {
                response = gestorRankingVinos.tomarFechaDesdeHasta(fechaDesde, fechaHasta);

                if (!response)
                {
                    MessageBox.Show("No hay reseñas en el periodo seleccionado.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarCampos(true, true, true);
                }
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
            tipoReseñaSeleccionada = cmbTipoReseña.SelectedIndex;
            gestorRankingVinos.tomarTipoReseña(tipoReseñaSeleccionada);
        }

        public void solicitarSeleccionFormaVisualizacion()
        {
            gpbVisualización.Enabled = true;
        }

        private void btnTipoVisualizacion_Click(object sender, EventArgs e)
        {
            if (rbtExcel.Checked)
            {
                tipoVisualizacionSeleccionada = 1;//"Excel";
                MessageBox.Show("Seleccinado Excel.");
                gestorRankingVinos.tomarSeleccionFormaVisualizacion(tipoVisualizacionSeleccionada);
            }
            else if (rbtPDF.Checked)
            {
                tipoVisualizacionSeleccionada = 2;// "PDF";
                MessageBox.Show("Seleccinado PDF.");
                gestorRankingVinos.tomarSeleccionFormaVisualizacion(tipoVisualizacionSeleccionada);
            }
            else if (rbtPantalla.Checked)
            {
                tipoVisualizacionSeleccionada = 3;// "Pantalla";
                MessageBox.Show("Seleccinado Pantalla.");
                gestorRankingVinos.tomarSeleccionFormaVisualizacion(tipoVisualizacionSeleccionada);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un formato de visualización.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void solicitarConfirmacionGeneracionReporte()
        {
            btnConfirmar.Enabled = true;            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            gestorRankingVinos.tomarConfirmacionGeneracionReporte(true);
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
