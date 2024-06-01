namespace BonvinoApp.CapaPresentacion.Forms
{
    partial class PantallaGenerarRankingVino
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaGenerarRankingVino));
            this.gpbFiltroFechas = new System.Windows.Forms.GroupBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechas = new System.Windows.Forms.Label();
            this.btnSeleccionarFechas = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.gpbTipoReseña = new System.Windows.Forms.GroupBox();
            this.cmbTipoReseña = new System.Windows.Forms.ComboBox();
            this.btnTipoReseña = new System.Windows.Forms.Button();
            this.lblTipoReseña = new System.Windows.Forms.Label();
            this.gpbVisualización = new System.Windows.Forms.GroupBox();
            this.rbtPantalla = new System.Windows.Forms.RadioButton();
            this.rbtExcel = new System.Windows.Forms.RadioButton();
            this.rbtPDF = new System.Windows.Forms.RadioButton();
            this.btnTipoVisualizacion = new System.Windows.Forms.Button();
            this.lblVisualizacion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gpbFiltroFechas.SuspendLayout();
            this.gpbTipoReseña.SuspendLayout();
            this.gpbVisualización.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltroFechas
            // 
            this.gpbFiltroFechas.Controls.Add(this.dtpFechaHasta);
            this.gpbFiltroFechas.Controls.Add(this.dtpFechaDesde);
            this.gpbFiltroFechas.Controls.Add(this.lblFechas);
            this.gpbFiltroFechas.Controls.Add(this.btnSeleccionarFechas);
            this.gpbFiltroFechas.Controls.Add(this.lblFechaHasta);
            this.gpbFiltroFechas.Controls.Add(this.lblFechaDesde);
            this.gpbFiltroFechas.Location = new System.Drawing.Point(12, 12);
            this.gpbFiltroFechas.Name = "gpbFiltroFechas";
            this.gpbFiltroFechas.Size = new System.Drawing.Size(530, 178);
            this.gpbFiltroFechas.TabIndex = 0;
            this.gpbFiltroFechas.TabStop = false;
            this.gpbFiltroFechas.Text = "Filtro de fechas:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(144, 101);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 4;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(144, 64);
            this.dtpFechaDesde.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 3;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // lblFechas
            // 
            this.lblFechas.AutoSize = true;
            this.lblFechas.Location = new System.Drawing.Point(30, 33);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(314, 13);
            this.lblFechas.TabIndex = 0;
            this.lblFechas.Text = "Selecciones la fecha desde y hasta de consideración de reseñas";
            // 
            // btnSeleccionarFechas
            // 
            this.btnSeleccionarFechas.Location = new System.Drawing.Point(373, 137);
            this.btnSeleccionarFechas.Name = "btnSeleccionarFechas";
            this.btnSeleccionarFechas.Size = new System.Drawing.Size(121, 23);
            this.btnSeleccionarFechas.TabIndex = 2;
            this.btnSeleccionarFechas.Text = "Seleccionar fechas";
            this.btnSeleccionarFechas.UseVisualStyleBackColor = true;
            this.btnSeleccionarFechas.Click += new System.EventHandler(this.btnSeleccionarFechas_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(51, 108);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(71, 13);
            this.lblFechaHasta.TabIndex = 1;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(48, 70);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(74, 13);
            this.lblFechaDesde.TabIndex = 0;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // gpbTipoReseña
            // 
            this.gpbTipoReseña.Controls.Add(this.cmbTipoReseña);
            this.gpbTipoReseña.Controls.Add(this.btnTipoReseña);
            this.gpbTipoReseña.Controls.Add(this.lblTipoReseña);
            this.gpbTipoReseña.Enabled = false;
            this.gpbTipoReseña.Location = new System.Drawing.Point(12, 209);
            this.gpbTipoReseña.Name = "gpbTipoReseña";
            this.gpbTipoReseña.Size = new System.Drawing.Size(530, 147);
            this.gpbTipoReseña.TabIndex = 1;
            this.gpbTipoReseña.TabStop = false;
            this.gpbTipoReseña.Text = "Tipo de Reseña";
            // 
            // cmbTipoReseña
            // 
            this.cmbTipoReseña.FormattingEnabled = true;
            this.cmbTipoReseña.Items.AddRange(new object[] {
            "Reseñas normales",
            "Reseñas de Sommelier",
            "Reseñas de Amigos"});
            this.cmbTipoReseña.Location = new System.Drawing.Point(144, 68);
            this.cmbTipoReseña.Name = "cmbTipoReseña";
            this.cmbTipoReseña.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoReseña.TabIndex = 3;
            this.cmbTipoReseña.SelectedIndexChanged += new System.EventHandler(this.cmbTipoReseña_SelectedIndexChanged);
            // 
            // btnTipoReseña
            // 
            this.btnTipoReseña.Location = new System.Drawing.Point(373, 102);
            this.btnTipoReseña.Name = "btnTipoReseña";
            this.btnTipoReseña.Size = new System.Drawing.Size(121, 23);
            this.btnTipoReseña.TabIndex = 2;
            this.btnTipoReseña.Text = "Seleccionar Tipo";
            this.btnTipoReseña.UseVisualStyleBackColor = true;
            this.btnTipoReseña.Click += new System.EventHandler(this.btnTipoReseña_Click);
            // 
            // lblTipoReseña
            // 
            this.lblTipoReseña.AutoSize = true;
            this.lblTipoReseña.Location = new System.Drawing.Point(30, 37);
            this.lblTipoReseña.Name = "lblTipoReseña";
            this.lblTipoReseña.Size = new System.Drawing.Size(202, 13);
            this.lblTipoReseña.TabIndex = 0;
            this.lblTipoReseña.Text = "Seleccione el tipo de reseña a considerar";
            // 
            // gpbVisualización
            // 
            this.gpbVisualización.Controls.Add(this.rbtPantalla);
            this.gpbVisualización.Controls.Add(this.rbtExcel);
            this.gpbVisualización.Controls.Add(this.rbtPDF);
            this.gpbVisualización.Controls.Add(this.btnTipoVisualizacion);
            this.gpbVisualización.Controls.Add(this.lblVisualizacion);
            this.gpbVisualización.Enabled = false;
            this.gpbVisualización.Location = new System.Drawing.Point(12, 375);
            this.gpbVisualización.Name = "gpbVisualización";
            this.gpbVisualización.Size = new System.Drawing.Size(530, 174);
            this.gpbVisualización.TabIndex = 2;
            this.gpbVisualización.TabStop = false;
            this.gpbVisualización.Text = "Formatos:";
            // 
            // rbtPantalla
            // 
            this.rbtPantalla.AutoSize = true;
            this.rbtPantalla.Location = new System.Drawing.Point(51, 112);
            this.rbtPantalla.Name = "rbtPantalla";
            this.rbtPantalla.Size = new System.Drawing.Size(63, 17);
            this.rbtPantalla.TabIndex = 5;
            this.rbtPantalla.TabStop = true;
            this.rbtPantalla.Text = "Pantalla";
            this.rbtPantalla.UseVisualStyleBackColor = true;
            // 
            // rbtExcel
            // 
            this.rbtExcel.AutoSize = true;
            this.rbtExcel.Location = new System.Drawing.Point(51, 88);
            this.rbtExcel.Name = "rbtExcel";
            this.rbtExcel.Size = new System.Drawing.Size(51, 17);
            this.rbtExcel.TabIndex = 4;
            this.rbtExcel.TabStop = true;
            this.rbtExcel.Text = "Excel";
            this.rbtExcel.UseVisualStyleBackColor = true;
            // 
            // rbtPDF
            // 
            this.rbtPDF.AutoSize = true;
            this.rbtPDF.Location = new System.Drawing.Point(51, 65);
            this.rbtPDF.Name = "rbtPDF";
            this.rbtPDF.Size = new System.Drawing.Size(46, 17);
            this.rbtPDF.TabIndex = 3;
            this.rbtPDF.TabStop = true;
            this.rbtPDF.Text = "PDF";
            this.rbtPDF.UseVisualStyleBackColor = true;
            // 
            // btnTipoVisualizacion
            // 
            this.btnTipoVisualizacion.Location = new System.Drawing.Point(373, 130);
            this.btnTipoVisualizacion.Name = "btnTipoVisualizacion";
            this.btnTipoVisualizacion.Size = new System.Drawing.Size(121, 23);
            this.btnTipoVisualizacion.TabIndex = 2;
            this.btnTipoVisualizacion.Text = "Seleccionar formato";
            this.btnTipoVisualizacion.UseVisualStyleBackColor = true;
            this.btnTipoVisualizacion.Click += new System.EventHandler(this.btnTipoVisualizacion_Click);
            // 
            // lblVisualizacion
            // 
            this.lblVisualizacion.AutoSize = true;
            this.lblVisualizacion.Location = new System.Drawing.Point(30, 30);
            this.lblVisualizacion.Name = "lblVisualizacion";
            this.lblVisualizacion.Size = new System.Drawing.Size(170, 13);
            this.lblVisualizacion.TabIndex = 0;
            this.lblVisualizacion.Text = "Seleccione forma de visualización:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(203, 576);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(385, 576);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Generar Reporte";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // PantallaGenerarRankingVino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(554, 611);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbVisualización);
            this.Controls.Add(this.gpbTipoReseña);
            this.Controls.Add(this.gpbFiltroFechas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(570, 650);
            this.Name = "PantallaGenerarRankingVino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Ranking de Vinos";
            this.gpbFiltroFechas.ResumeLayout(false);
            this.gpbFiltroFechas.PerformLayout();
            this.gpbTipoReseña.ResumeLayout(false);
            this.gpbTipoReseña.PerformLayout();
            this.gpbVisualización.ResumeLayout(false);
            this.gpbVisualización.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFiltroFechas;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnSeleccionarFechas;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.GroupBox gpbTipoReseña;
        private System.Windows.Forms.ComboBox cmbTipoReseña;
        private System.Windows.Forms.Button btnTipoReseña;
        private System.Windows.Forms.Label lblTipoReseña;
        private System.Windows.Forms.GroupBox gpbVisualización;
        private System.Windows.Forms.RadioButton rbtPantalla;
        private System.Windows.Forms.RadioButton rbtExcel;
        private System.Windows.Forms.RadioButton rbtPDF;
        private System.Windows.Forms.Button btnTipoVisualizacion;
        private System.Windows.Forms.Label lblVisualizacion;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}