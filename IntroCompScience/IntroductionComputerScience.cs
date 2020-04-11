using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroCompScience
{
    public partial class IntroCompScience : Form
    {
        private int childFormNumber = 0;

        public IntroCompScience()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form unconstrainedgrowthsimulator = new UnconstrainedGrowthSimulator();
            unconstrainedgrowthsimulator.MdiParent = this;
            unconstrainedgrowthsimulator.Text = "Unconstrained Growth Simulator " + childFormNumber++;
            unconstrainedgrowthsimulator.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            Form constrainedgrowthsimulator = new ConstrainedGrowthSimulator();
            constrainedgrowthsimulator.MdiParent = this;
            constrainedgrowthsimulator.Text = "Constrained Growth Simulator " + childFormNumber++;
            constrainedgrowthsimulator.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form competitionsimulator = new CompetitionSimulator();
            competitionsimulator.MdiParent = this;
            competitionsimulator.Text = "Competition Simulator " + childFormNumber++;
            competitionsimulator.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form predatorpreysimulator = new PredatorPreySimulation();
            predatorpreysimulator.MdiParent = this;
            predatorpreysimulator.Text = "Predator-Prey Simulator " + childFormNumber++;
            predatorpreysimulator.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sirsimulator = new SIRSimulator();
            sirsimulator.MdiParent = this;
            sirsimulator.Text = "SIR Simulator " + childFormNumber++;
            sirsimulator.Show();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form malariasimulator = new MalariaSimulator();
            malariasimulator.MdiParent = this;
            malariasimulator.Text = "Malaria Simulator " + childFormNumber++;
            malariasimulator.Show();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form computationalerrors = new ComputationErrorSimulator();
            computationalerrors.MdiParent = this;
            computationalerrors.Text = "Computation Errors " + childFormNumber;
            computationalerrors.Show();
        }
    }
}
