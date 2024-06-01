using BonvinoApp.CapaPresentacion.Forms;
using System;
using System.Windows.Forms;

namespace BonvinoApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void generarRankingDeVinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaGenerarRankingVino pantallaGenerarRankingVino = new PantallaGenerarRankingVino();
            pantallaGenerarRankingVino.ShowDialog();
        }
    }
}
