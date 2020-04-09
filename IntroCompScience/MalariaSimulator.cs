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
    public partial class MalariaSimulator : Form
    {
        private Malaria malariaModel;
        private MalariaInitialParameters initialParameters;
        private MalariaModelResults malariaResults;

        public MalariaSimulator()
        {
            InitializeComponent();
        }

        private void RunSimulation_Click(object sender, EventArgs e)
        {
            this.malariaModel = new Malaria();
            this.initialParameters = new MalariaInitialParameters();
            this.setInitialParameters();
            malariaModel.InitialParameters = this.initialParameters;

            this.malariaModel.StartModel();
            this.malariaResults = this.malariaModel.ModelRunDataResults;
            this.populateGridViewWithSeriesData();
            this.populateChartSeriesData();
        }

        private void setInitialParameters()
        {
            this.initialParameters.TimeIncrement = float.Parse(TimeIncrement.Text);
            this.initialParameters.LengthofSimulation = System.Convert.ToInt32(SimulationPeriod.Text);
            
            this.initialParameters.InitialPopulationSize = System.Convert.ToInt32(UninfectedHumans.Text);
            this.initialParameters.InitialHumanHostsPopulation = System.Convert.ToInt32(HumanHosts.Text);
            this.initialParameters.InitialImmunePopulation = System.Convert.ToInt32(Immune.Text);
            this.initialParameters.InitialUninfectedMosquitosPopulation = System.Convert.ToInt32(UninfectedMosquitos.Text);
            this.initialParameters.ProbabilityOfGettingBit = float.Parse(ProbabilityOfBiting.Text);
            this.initialParameters.MosquitoBirthRate = float.Parse(MosquitoBirthFraction.Text);
            this.initialParameters.MosquitoDeathRate = float.Parse(MosquitoDeathRate.Text);
            this.initialParameters.ImmunityRate = float.Parse(ImmunityRate.Text);
            this.initialParameters.RecoveryRate = float.Parse(RecoveryRate.Text);
            this.initialParameters.MalariaInducedDeathRate = float.Parse(MalariaInducedDeathRate.Text);
            this.initialParameters.ProbabilityToBiteAHuman = float.Parse(ProbabilityBit.Text);
            this.initialParameters.InitialNumberOfVectors = System.Convert.ToInt32(InitialVectors.Text);
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
                SimulationDataResults.Columns.Add("uninfectedhumanpopulationseries", "Uninfected Human Hosts Population Series");
                SimulationDataResults.Columns.Add("humanhostspopulationseries","Human Hosts Population Series");
                SimulationDataResults.Columns.Add("immunepopulationSeries", "Immune Population Series");
                SimulationDataResults.Columns.Add("uninfectedmosquitospopulationSeries", "Uninfected Mosquitos Population Series");
                SimulationDataResults.Columns.Add("vectorspopulationseries", "Vector Population Series");
                SimulationDataResults.Columns.Add("probhostpopulationseries", "Probability Hosts Population Series");
                SimulationDataResults.Columns.Add("probvectorpopulationseries", "Probability Vector Population Series");
            }

            Object[] values = new object[8];
            int numberofiterations = this.malariaResults.HumanHostsPopulation.TimeSeries.Length;

            for (int iterator = 0; iterator < numberofiterations; iterator++)
            {
                
                values[0] = this.malariaResults.HumanHostsPopulation.TimeSeries.GetValue(iterator);
                values[1] = this.malariaResults.UninfectedHumansPopulation.PopulationGrowthOverTime.GetValue(iterator);
                values[2] = this.malariaResults.HumanHostsPopulation.PopulationGrowthOverTime.GetValue(iterator);
                values[3] = this.malariaResults.ImmunePopulation.PopulationGrowthOverTime.GetValue(iterator);
                values[4] = this.malariaResults.UninfectedMosquitosPopulation.PopulationGrowthOverTime.GetValue(iterator);
                values[5] = this.malariaResults.VectorsPopulation.PopulationGrowthOverTime.GetValue(iterator);
                values[6] = this.malariaResults.ProbabilityHostPopulation.PopulationGrowthOverTime.GetValue(iterator);
                values[7] = this.malariaResults.ProbabilityVectorPopulation.PopulationGrowthOverTime.GetValue(iterator);
                SimulationDataResults.Rows.Add(values);
            }

        }

        private void populateChartSeriesData()
        {
            try
            {
                if (SimulationVisualResultsPopulation.Series.Count > 0)
                {
                    SimulationVisualResultsPopulation.Series.Clear();
                }

                if (SimulationVisualResultsProbability.Series.Count > 0)
                {
                    SimulationVisualResultsProbability.Series.Clear();
                }

                SimulationVisualResultsPopulation.Series.Add("Uninfected Humans").Points.DataBindXY(this.malariaResults.UninfectedHumansPopulation.TimeSeries, this.malariaResults.UninfectedHumansPopulation.PopulationGrowthOverTime);
                SimulationVisualResultsPopulation.Series.Add("Uninfected Mosquitos").Points.DataBindXY(this.malariaResults.UninfectedMosquitosPopulation.TimeSeries, this.malariaResults.UninfectedMosquitosPopulation.PopulationGrowthOverTime);

                SimulationVisualResultsProbability.Series.Add("Human Hosts").Points.DataBindXY(this.malariaResults.HumanHostsPopulation.TimeSeries, this.malariaResults.HumanHostsPopulation.PopulationGrowthOverTime);
                SimulationVisualResultsProbability.Series.Add("Immune").Points.DataBindXY(this.malariaResults.ImmunePopulation.TimeSeries, this.malariaResults.ImmunePopulation.PopulationGrowthOverTime);
                SimulationVisualResultsProbability.Series.Add("Vector").Points.DataBindXY(this.malariaResults.VectorsPopulation.TimeSeries, this.malariaResults.VectorsPopulation.PopulationGrowthOverTime);
                SimulationVisualResultsProbability.Series.Add("Probability Host").Points.DataBindXY(this.malariaResults.ProbabilityHostPopulation.TimeSeries, this.malariaResults.ProbabilityHostPopulation.PopulationGrowthOverTime);
                SimulationVisualResultsProbability.Series.Add("Probability Vector").Points.DataBindXY(this.malariaResults.ProbabilityVectorPopulation.TimeSeries, this.malariaResults.ProbabilityVectorPopulation.PopulationGrowthOverTime);
                
                
                foreach(System.Windows.Forms.DataVisualization.Charting.Series s in SimulationVisualResultsPopulation.Series)
                {
                    s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }

                foreach (System.Windows.Forms.DataVisualization.Charting.Series p in SimulationVisualResultsProbability.Series)
                {
                    p.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }

                SimulationVisualResultsPopulation.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MalariaSimulator_Load(object sender, EventArgs e)
        {

        }
    }
}
