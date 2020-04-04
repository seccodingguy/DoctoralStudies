using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class ConstrainedGrowth
    {
        private InitialParameters initialparams;
        private ModelResults results;
        private float growthRate;

        public InitialParameters InitialModelParameters
        {
            get { return this.initialparams; }
            set { this.initialparams = value; }
        }

        public ModelResults ResultSet
        {
            get { return this.results; }
        }

        public void StartModel()
        {
            this.results = new ModelResults();
            int numberofIterationsToRun = this.numberOfIterations();
            float[] timeSeries = new float[numberofIterationsToRun];
            float[] populationSizeOverTime = new float[numberofIterationsToRun];
            float[] deathRateOverTime = new float[numberofIterationsToRun];

            timeSeries[0] = 0;
            populationSizeOverTime[0] = this.initialparams.InitialPopulationSize;
            deathRateOverTime[0] = 0;

            for (int iteration = 1; iteration < numberofIterationsToRun; iteration++)
            {
                timeSeries[iteration] = iteration * this.initialparams.TimeIncrement;
                deathRateOverTime[iteration] = this.deathrate(populationSizeOverTime[iteration - 1]);
                populationSizeOverTime[iteration] = populationSizeOverTime[iteration - 1] + (deathRateOverTime[iteration]*populationSizeOverTime[iteration-1]);
            }

            this.results.TimeSeries = timeSeries;
            this.results.PopulationGrowthOverTime = populationSizeOverTime;
            this.results.DeathRateOverTime = deathRateOverTime;
        }

        private float deathrate(float populationSize)
        {
            return this.initialparams.GrowthRate * (1 - (populationSize / this.initialparams.CarryingCapacity));
        }

        private int numberOfIterations()
        {
            return System.Convert.ToInt32(initialparams.LengthofSimulation / initialparams.TimeIncrement) + 1;
        }

        private float growth(float populationSize)
        {
            return this.initialparams.GrowthRate * populationSize * this.initialparams.TimeIncrement;
        }
    }
}
