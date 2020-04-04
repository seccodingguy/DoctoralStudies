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
    public partial class CompetitionSimulator : Form
    {
        private InitialParameters competitorOneInitialParams;
        private InitialParameters competitorTwoInitialParams;
        private ModelResults competitorOneResults;
        private ModelResults competitorTwoResults;
        private Competition competitionModel;

        public CompetitionSimulator()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RunSimulation_Click(object sender, EventArgs e)
        {
            this.competitorOneInitialParams = new InitialParameters();
            this.competitorTwoInitialParams = new InitialParameters();
            
            this.competitionModel = new Competition();

            this.setInitialParameters();

            this.competitionModel.StartModel();
            this.competitorOneResults = this.competitionModel.CompetitorOneResults;
            this.competitorTwoResults = this.competitionModel.CompetitorTwoResults;

            this.populateGridViewWithSeriesData();
            this.populateChartSeriesData();

            MessageBox.Show("Simulation run is complete.", "Simulation complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void setInitialParameters()
        {
            this.competitorOneInitialParams.TimeIncrement = float.Parse(TimeIncrement.Text);
            this.competitorOneInitialParams.LengthofSimulation = System.Convert.ToInt32(SimulationPeriod.Text);
            this.competitorTwoInitialParams.TimeIncrement = float.Parse(TimeIncrement.Text);
            this.competitorTwoInitialParams.LengthofSimulation = System.Convert.ToInt32(SimulationPeriod.Text);

            this.competitorOneInitialParams.InitialPopulationSize = System.Convert.ToInt32(CompetitorOneInitialPopulation.Text);
            this.competitorTwoInitialParams.InitialPopulationSize = System.Convert.ToInt32(CompetitorTwoInitialPopulation.Text);

            this.competitorOneInitialParams.CarryingCapacity = System.Convert.ToInt32(CompetitorOneCarryingCapacity.Text);
            this.competitorTwoInitialParams.CarryingCapacity = System.Convert.ToInt32(CompetitorTwoCarryingCapacity.Text);

            this.competitorOneInitialParams.BirthFraction = float.Parse(CompetitorOneBirthFraction.Text);
            this.competitorTwoInitialParams.BirthFraction = float.Parse(CompetitorTwoBirthFraction.Text);

            this.competitorOneInitialParams.DeathPropotionalityScore = float.Parse(CompetitorOneDeathProportionalityRate.Text);
            this.competitorTwoInitialParams.DeathPropotionalityScore = float.Parse(CompetitorTwoDeathProportionalityRate.Text);

            this.competitionModel.CompetitorOneInitialParameters = this.competitorOneInitialParams;
            this.competitionModel.CompetitorTwoInitialParameters = this.competitorTwoInitialParams;
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
                SimulationDataResults.Columns.Add("competitoronepopulationSeries", "Competitor One Population Series");
                SimulationDataResults.Columns.Add("competitortwopopulationSeries", "Competitor Two Population Series");
            }

            for (int iterator = 0; iterator < competitorOneResults.TimeSeries.Length; iterator++)
            {
                Object[] values = { competitorOneResults.TimeSeries.GetValue(iterator), competitorOneResults.PopulationGrowthOverTime.GetValue(iterator), competitorTwoResults.PopulationGrowthOverTime.GetValue(iterator) };
                SimulationDataResults.Rows.Add(values);
            }

        }

        private void populateChartSeriesData()
        {
            if (SimulationVisualResults.Series.Count > 0)
            {
                SimulationVisualResults.Series.Clear();
            }

            SimulationVisualResults.Series.Add("Competitor One Population Change over Time").Points.DataBindXY(this.competitorOneResults.TimeSeries, this.competitorOneResults.PopulationGrowthOverTime);
            SimulationVisualResults.Series.Add("Competitor Two Population Change over Time").Points.DataBindXY(this.competitorTwoResults.TimeSeries, this.competitorTwoResults.PopulationGrowthOverTime);
            SimulationVisualResults.Series["Competitor One Population Change over Time"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            SimulationVisualResults.Series["Competitor Two Population Change over Time"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            SimulationVisualResults.Show();
        }
    }
}
