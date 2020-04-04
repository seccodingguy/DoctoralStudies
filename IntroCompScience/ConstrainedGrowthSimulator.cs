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
    public partial class ConstrainedGrowthSimulator : Form
    {
        private InitialParameters initialParams;
        private ModelResults results;
        private ConstrainedGrowth constrainedGrowthModel;

        public ConstrainedGrowthSimulator()
        {
            InitializeComponent();
        }

        private void RunSimulation_Click(object sender, EventArgs e)
        {
            this.initialParams = new InitialParameters();
            this.constrainedGrowthModel = new ConstrainedGrowth();

            this.setInitialParameters();

            this.constrainedGrowthModel.StartModel();
            this.results = this.constrainedGrowthModel.ResultSet;

            this.populateGridViewWithSeriesData();
            this.populateChartSeriesData();

            MessageBox.Show("Simulation run is complete.", "Simulation complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void setInitialParameters()
        {
            initialParams.GrowthRate = float.Parse(GrowthRate.Text);
            initialParams.InitialPopulationSize = System.Convert.ToInt32(InitialPopulation.Text);
            initialParams.TimeIncrement = float.Parse(TimeIncrement.Text);
            initialParams.LengthofSimulation = System.Convert.ToInt32(SimulationPeriod.Text);
            initialParams.CarryingCapacity = System.Convert.ToInt32(CarryingCapacity.Text);

            constrainedGrowthModel.InitialModelParameters = initialParams;
        }

        private void populateGridViewWithSeriesData()
        {
            if(SimulationDataResults.Columns.Count > 0)
            {
                SimulationDataResults.Rows.Clear();
            }
            else 
            { 
                SimulationDataResults.Columns.Add("timeSeries", "Time Series");
                SimulationDataResults.Columns.Add("populationSeries", "Population Series");
                SimulationDataResults.Columns.Add("deathRateSeries", "Death Rate Series");
            }

            for (int iterator = 0; iterator < results.TimeSeries.Length; iterator++)
            {
                Object[] values = { results.TimeSeries.GetValue(iterator), results.PopulationGrowthOverTime.GetValue(iterator), results.DeathRateOverTime.GetValue(iterator) };
                SimulationDataResults.Rows.Add(values);
            }

        }

        private void populateChartSeriesData()
        {
            if(SimulationVisualResults.Series.Count > 0)
            {
                SimulationVisualResults.Series.Clear();
            }

            SimulationVisualResults.Series.Add("Population Change over Time").Points.DataBindXY(this.results.TimeSeries, this.results.PopulationGrowthOverTime);
            SimulationVisualResults.Series.Add("Death Rate Change over Time").Points.DataBindXY(this.results.TimeSeries, this.results.DeathRateOverTime);
            SimulationVisualResults.Series["Population Change over Time"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            SimulationVisualResults.Series["Death Rate Change over Time"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            SimulationVisualResults.Show();
        }
    }
}
