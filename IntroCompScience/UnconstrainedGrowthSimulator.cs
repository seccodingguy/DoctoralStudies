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
    public partial class UnconstrainedGrowthSimulator : Form
    {
        private InitialParameters initialParams;
        private ModelResults results;
        private UnconstrainedGrowth unconstrainedGrowthModel;

        public UnconstrainedGrowthSimulator()
        {
            InitializeComponent();
        }

        private void RunSimulation_Click(object sender, EventArgs e)
        {
            this.initialParams = new InitialParameters();
            this.unconstrainedGrowthModel = new UnconstrainedGrowth();

            this.setInitialParameters();

            this.unconstrainedGrowthModel.StartModel();
            this.results = this.unconstrainedGrowthModel.ResultSet;

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

            unconstrainedGrowthModel.InitialModelParameters = initialParams;
        }

        private void populateGridViewWithSeriesData()
        {
            SimulationDataResults.Columns.Add("timeSeries", "Time Series");
            SimulationDataResults.Columns.Add("populationSeries", "Population Series");

            for (int iterator = 0; iterator < results.TimeSeries.Length; iterator++)
            {
                Object[] values = { results.TimeSeries.GetValue(iterator), results.PopulationGrowthOverTime.GetValue(iterator) };
                SimulationDataResults.Rows.Add(values);
            }

        }

        private void populateChartSeriesData()
        {
            SimulationVisualResults.Series.Add("Populate Change over Time").Points.DataBindXY(this.results.TimeSeries, this.results.PopulationGrowthOverTime);
            SimulationVisualResults.Show();
        }
    }
}
