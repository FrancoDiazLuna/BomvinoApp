namespace BonvinoApp.CapaPresentacion.Forms
{
    partial class VisualizacionPantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizacionPantalla));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordenRanking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreVino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionSommelier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioSugerido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varietal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.región = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordenRanking,
            this.nombreVino,
            this.calificacionSommelier,
            this.calificacionGeneral,
            this.precioSugerido,
            this.bodega,
            this.varietal,
            this.región,
            this.pais});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 737);
            this.dataGridView1.TabIndex = 0;
            // 
            // ordenRanking
            // 
            this.ordenRanking.HeaderText = "Orden";
            this.ordenRanking.Name = "ordenRanking";
            this.ordenRanking.ReadOnly = true;
            // 
            // nombreVino
            // 
            this.nombreVino.HeaderText = "Nombre";
            this.nombreVino.Name = "nombreVino";
            this.nombreVino.ReadOnly = true;
            // 
            // calificacionSommelier
            // 
            this.calificacionSommelier.HeaderText = "Calificación de Sommelier";
            this.calificacionSommelier.Name = "calificacionSommelier";
            this.calificacionSommelier.ReadOnly = true;
            // 
            // calificacionGeneral
            // 
            this.calificacionGeneral.HeaderText = "Calificación General";
            this.calificacionGeneral.Name = "calificacionGeneral";
            this.calificacionGeneral.ReadOnly = true;
            // 
            // precioSugerido
            // 
            this.precioSugerido.HeaderText = "Precio Sugerido";
            this.precioSugerido.Name = "precioSugerido";
            this.precioSugerido.ReadOnly = true;
            // 
            // bodega
            // 
            this.bodega.HeaderText = "Bodega";
            this.bodega.Name = "bodega";
            this.bodega.ReadOnly = true;
            // 
            // varietal
            // 
            this.varietal.HeaderText = "Varietal";
            this.varietal.Name = "varietal";
            this.varietal.ReadOnly = true;
            // 
            // región
            // 
            this.región.HeaderText = "Región";
            this.región.Name = "región";
            this.región.ReadOnly = true;
            // 
            // pais
            // 
            this.pais.HeaderText = "Pais";
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            // 
            // VisualizacionPantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisualizacionPantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ranking de Vinos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreVino;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionSommelier;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioSugerido;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn varietal;
        private System.Windows.Forms.DataGridViewTextBoxColumn región;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
    }
}