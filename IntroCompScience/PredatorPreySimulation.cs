using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerScienceMethods;
using Microsoft.Office.Interop;

namespace IntroCompScience
{
    public partial class PredatorPreySimulation : Form
    {
        private InitialParameters preyInitialParams;
        private InitialParameters predatorInitialParams;
        private ModelResults preyResults;
        private ModelResults predatorResults;
        private PredatorPrey predatorpreyModel;

        public PredatorPreySimulation()
        {
            InitializeComponent();
        }

        private void RunSimulation_Click(object sender, EventArgs e)
        {
            try
            {
                this.preyInitialParams = new InitialParameters();
                this.predatorInitialParams = new InitialParameters();

                this.predatorpreyModel = new PredatorPrey();

                this.setInitialParameters();

                //this.predatorpreyModel.StartModel();
                this.SelectModelToRun();
                this.preyResults = this.predatorpreyModel.PreyResults;
                this.predatorResults = this.predatorpreyModel.PredatorResults;

                this.populateGridViewWithSeriesData();
                this.populateChartSeriesData();

                MessageBox.Show("Simulation run is complete.", "Simulation complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectModelToRun()
        {
            if(this.PreyOnly.Checked)
            {
                this.predatorpreyModel.StartModelPreyOnly();
            }
            else if(this.PredatorOnly.Checked)
            {
                this.predatorpreyModel.StartModelPredatoryOnly();
            }
            else 
            {
                this.predatorpreyModel.StartModel();
            }
        }

        private void setInitialParameters()
        {
            this.preyInitialParams.TimeIncrement = float.Parse(TimeIncrement.Text);
            this.preyInitialParams.LengthofSimulation = System.Convert.ToInt32(SimulationPeriod.Text);
            this.predatorInitialParams.TimeIncrement = float.Parse(TimeIncrement.Text);
            this.predatorInitialParams.LengthofSimulation = System.Convert.ToInt32(SimulationPeriod.Text);

            this.preyInitialParams.InitialPopulationSize = System.Convert.ToInt32(PreyInitialPopulation.Text);
            this.predatorInitialParams.InitialPopulationSize = System.Convert.ToInt32(PredatorInitialPopulation.Text);

            this.preyInitialParams.CarryingCapacity = System.Convert.ToInt32(PreyCarryingCapacity.Text);
            this.predatorInitialParams.CarryingCapacity = System.Convert.ToInt32(PredatorCarryingCapacity.Text);

            this.preyInitialParams.BirthFraction = float.Parse(PreyBirthFraction.Text);
            this.predatorInitialParams.BirthFraction = float.Parse(PredatorBirthFraction.Text);

            this.preyInitialParams.DeathPropotionalityScore = float.Parse(PreyDeathProportionalityRate.Text);
            this.predatorInitialParams.DeathPropotionalityScore = float.Parse(PredatorDeathProportionalityRate.Text);

            this.predatorpreyModel.PreyInitialParameters = this.preyInitialParams;
            this.predatorpreyModel.PredatorInitialParameters = this.predatorInitialParams;

            this.preyInitialParams.CarryingCapacity = System.Convert.ToInt32(PreyCarryingCapacity.Text);
            this.predatorInitialParams.CarryingCapacity = System.Convert.ToInt32(PredatorCarryingCapacity.Text);

            this.preyInitialParams.GrowthRate = System.Convert.ToInt32(PreyCarryingCapacity.Text);
            this.predatorInitialParams.GrowthRate = System.Convert.ToInt32(PredatorCarryingCapacity.Text);

            if(this.predatorInitialParams.CarryingCapacity > 0)
            {

                this.predatorInitialParams.AlphaPN = float.Parse(AlphaPN.Text);
                this.preyInitialParams.AlphaNP = float.Parse(AlphaNP.Text);
            }

        }

        private void populateGridViewWithSeriesData()
        {
            if (SimulationDataResults.Columns.Count > 0)
            {
                SimulationDataResults.Rows.Clear();
            }
            else
            {
                SimulationDataResults.Columns.Add("timeSeries", "Time Series");
                SimulationDataResults.Columns.Add("preypopulationSeries", "Prey Population Series");
                SimulationDataResults.Columns.Add("predatorpopulationSeries", "Predator Population Series");
                SimulationDataResults.Columns.Add("preygrowthRateSeries", "Prey Growth Rate Series");
                SimulationDataResults.Columns.Add("preygrowthRateSeries", "Predator Growth Rate Series");
            }

            for (int iterator = 0; iterator < this.preyResults.TimeSeries.Length; iterator++)
            {
                Object[] values = { this.preyResults.TimeSeries.GetValue(iterator), this.preyResults.PopulationGrowthOverTime.GetValue(iterator), this.predatorResults.PopulationGrowthOverTime.GetValue(iterator), this.preyResults.GrowthRateOverTime.GetValue(iterator), this.predatorResults.GrowthRateOverTime.GetValue(iterator) };
                SimulationDataResults.Rows.Add(values);
            }

        }

        private void populateChartSeriesData()
        {
            try
            {
                if (SimulationVisualResults.Series.Count > 0)
                {
                    SimulationVisualResults.Series.Clear();
                }

                SimulationVisualResults.Series.Add("Prey Population Change over Time").Points.DataBindXY(this.preyResults.TimeSeries, this.preyResults.PopulationGrowthOverTime);
                SimulationVisualResults.Series.Add("Predator Population Change over Time").Points.DataBindXY(this.predatorResults.TimeSeries, this.predatorResults.PopulationGrowthOverTime);
                SimulationVisualResults.Series["Prey Population Change over Time"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                SimulationVisualResults.Series["Predator Population Change over Time"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                SimulationVisualResults.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog chartexportfilelocation = new SaveFileDialog();
            chartexportfilelocation.Filter = "PNG File(*.png)|*.png|All files(*.*)|*.*";

            if (chartexportfilelocation.ShowDialog(this) == DialogResult.OK)
            {
                SimulationVisualResults.SaveImage(chartexportfilelocation.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void copyAlltoClipboard()
        {
            SimulationDataResults.SelectAll();
            DataObject dataObj = SimulationDataResults.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dataexportfilelocation = new SaveFileDialog();
            dataexportfilelocation.Filter = "CSV File(*.csv)|*.csv|All Files(*.*)|*.*";

            StringBuilder simulationresultdata = new StringBuilder();

            for(int columniterator = 0; columniterator < SimulationDataResults.Columns.Count; columniterator++)
            {
                simulationresultdata.Append(SimulationDataResults.Columns[columniterator].HeaderText + ",");
                
            }

            simulationresultdata.Append(",");

            foreach (TextBox textBoxControl in Controls.OfType<TextBox>())
            { 
                simulationresultdata.Append(textBoxControl.Name);
                simulationresultdata.Append(",");
            }

            foreach(GroupBox groupBoxControl in Controls.OfType<GroupBox>())
            {
                foreach(TextBox textBoxControl in groupBoxControl.Controls.OfType<TextBox>())
                {
                    simulationresultdata.Append(textBoxControl.Name);
                    simulationresultdata.Append(",");
                }
            }

            simulationresultdata.Remove(simulationresultdata.Length - 1, 1);
            simulationresultdata.AppendLine();

            for (int celliterator = 0; celliterator < SimulationDataResults.Rows[0].Cells.Count; celliterator++)
            {
                simulationresultdata.Append(SimulationDataResults.Rows[0].Cells[celliterator].Value);
                simulationresultdata.Append(",");
            }

            simulationresultdata.Append(",");

            foreach (TextBox textBoxControl in Controls.OfType<TextBox>())
            {
                simulationresultdata.Append(textBoxControl.Text);
                simulationresultdata.Append(",");
            }

            foreach (GroupBox groupBoxControl in Controls.OfType<GroupBox>())
            {
                foreach (TextBox textBoxControl in groupBoxControl.Controls.OfType<TextBox>())
                {
                    simulationresultdata.Append(textBoxControl.Text);
                    simulationresultdata.Append(",");
                }
            }

            simulationresultdata.Remove(simulationresultdata.Length - 1, 1);
            simulationresultdata.AppendLine();

            for (int rowiterator = 1; rowiterator < SimulationDataResults.Rows.Count; rowiterator++)
            {
                for(int celliterator = 0; celliterator < SimulationDataResults.Rows[rowiterator].Cells.Count; celliterator++)
                {
                    simulationresultdata.Append(SimulationDataResults.Rows[rowiterator].Cells[celliterator].Value);
                    simulationresultdata.Append(",");
                }

               
                simulationresultdata.Remove(simulationresultdata.Length - 1, 1);
                simulationresultdata.AppendLine();
                
            }

            

            if (dataexportfilelocation.ShowDialog(this) == DialogResult.OK)
            {
                string filename = dataexportfilelocation.FileName;

                System.IO.StreamWriter dataresultsfile = new System.IO.StreamWriter(filename);
                dataresultsfile.WriteLine(simulationresultdata.ToString());
                dataresultsfile.Flush();
                dataresultsfile.Close();
            }
        }

        private void PredatorPreySimulation_Load(object sender, EventArgs e)
        {

        }

        private void PreyOnly_CheckedChanged(object sender, EventArgs e)
        {
            if(this.PreyOnly.Checked)
            {
                this.PredatorOnly.Checked = false;
            }
        }

        private void PredatorOnly_CheckedChanged(object sender, EventArgs e)
        {
            if(this.PredatorOnly.Checked)
            {
                this.PreyOnly.Checked = false;
            }
        }
    }
}
