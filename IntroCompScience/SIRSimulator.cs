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

namespace IntroCompScience
{
    public partial class SIRSimulator : Form
    {
        private InitialParameters susceptableInitialParams;
        private InitialParameters infectedInitialParams;
        private InitialParameters removedInitialParams;
        private ModelResults susceptableResults;
        private ModelResults infectedResults;
        private ModelResults removedResults;
        private SIRModel SIR;

        public SIRSimulator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RunSimulation_Click(object sender, EventArgs e)
        {
            //try
            //{
                this.susceptableInitialParams = new InitialParameters();
                this.infectedInitialParams = new InitialParameters();
                this.removedInitialParams = new InitialParameters();

                this.SIR = new SIRModel();

                this.setInitialParameters();

                this.SIR.InfectedIndividualsInitialParameters = this.infectedInitialParams;
                this.SIR.SusceptableIndividualsInitialParameters = this.susceptableInitialParams;
                this.SIR.RemovedIndividualsInitialParameters = this.removedInitialParams;

                //this.predatorpreyModel.StartModel();
                this.SIR.StartModel();
                this.susceptableResults = this.SIR.SusceptablePopulation;
                this.infectedResults = this.SIR.InfectionPopulation;
                this.removedResults = this.SIR.RemovedPopulation;

                this.populateGridViewWithSeriesData();
                this.populateChartSeriesData();

                MessageBox.Show("Simulation run is complete.", "Simulation complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
        }

        private void setInitialParameters()
        {
            this.susceptableInitialParams.TimeIncrement = float.Parse(TimeIncrement.Text);
            this.infectedInitialParams.TimeIncrement = float.Parse(TimeIncrement.Text);
            this.removedInitialParams.TimeIncrement = float.Parse(TimeIncrement.Text);

            this.susceptableInitialParams.LengthofSimulation = System.Convert.ToInt32(SimulationPeriod.Text);
            this.infectedInitialParams.LengthofSimulation = System.Convert.ToInt32(SimulationPeriod.Text);
            this.removedInitialParams.TimeIncrement = System.Convert.ToInt32(SimulationPeriod.Text);

            this.susceptableInitialParams.InitialPopulationSize = System.Convert.ToInt32(this.SusceptableInitialPopulation.Text);
            this.infectedInitialParams.InitialPopulationSize = System.Convert.ToInt32(this.InfectedInitialPopulation.Text);
            this.removedInitialParams.InitialPopulationSize = System.Convert.ToInt32(this.RemovedInitialPopulation.Text);

            this.susceptableInitialParams.TransmissionConstant = float.Parse(this.TransmissionRate.Text);
            this.infectedInitialParams.TransmissionConstant = float.Parse(this.TransmissionRate.Text);

            this.susceptableInitialParams.RecoveryRate = float.Parse(this.RecoveryRate.Text);
            this.infectedInitialParams.RecoveryRate = float.Parse(this.RecoveryRate.Text);
            this.removedInitialParams.RecoveryRate = float.Parse(this.RecoveryRate.Text);

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
                SimulationDataResults.Columns.Add("susceptablepopulationSeries", "Susceptable Population Series");
                SimulationDataResults.Columns.Add("infectedpopulationSeries", "Infected Population Series");
                SimulationDataResults.Columns.Add("removedpopulationSeries", "Removed Population Series");
                SimulationDataResults.Columns.Add("durationofinfection", "Duration of Infection");
            }

            for (int iterator = 0; iterator < this.susceptableResults.TimeSeries.Length; iterator++)
            {
                Object[] values = { this.susceptableResults.TimeSeries.GetValue(iterator), this.susceptableResults.PopulationGrowthOverTime.GetValue(iterator), this.infectedResults.PopulationGrowthOverTime.GetValue(iterator), this.removedResults.PopulationGrowthOverTime.GetValue(iterator), (1/float.Parse(this.RecoveryRate.Text)) };
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

                SimulationVisualResults.Series.Add("Susceptable Population Change over Time").Points.DataBindXY(this.susceptableResults.TimeSeries, this.susceptableResults.PopulationGrowthOverTime);
                SimulationVisualResults.Series.Add("Infected Population Change over Time").Points.DataBindXY(this.infectedResults.TimeSeries, this.infectedResults.PopulationGrowthOverTime);
                SimulationVisualResults.Series.Add("Removed Population Change over Time").Points.DataBindXY(this.removedResults.TimeSeries, this.removedResults.PopulationGrowthOverTime);
                SimulationVisualResults.Series["Susceptable Population Change over Time"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                SimulationVisualResults.Series["Infected Population Change over Time"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                SimulationVisualResults.Series["Removed Population Change over Time"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                SimulationVisualResults.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
