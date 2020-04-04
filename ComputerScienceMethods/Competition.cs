using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class Competition
    {
        private InitialParameters competitorOneInitialParameters;
        private InitialParameters competitorTwoInitialParameters;
        private ModelResults competitorOneResults;
        private ModelResults competitorTwoResults;
        

        public InitialParameters CompetitorOneInitialParameters
        {
            set { this.competitorOneInitialParameters = value; }
        }

        public ModelResults CompetitorOneResults
        {
            get { return this.competitorOneResults; }
        }

        public InitialParameters CompetitorTwoInitialParameters
        {
            set { this.competitorTwoInitialParameters = value; }
        }

        public ModelResults CompetitorTwoResults
        {
            get { return this.competitorTwoResults; }
        }

        public void StartModel()
        {
            this.competitorOneResults = new ModelResults();
            this.competitorTwoResults = new ModelResults();
            float competitorOneDeaths;
            float competitorTwoDeaths;
            float competitorOneBirths;
            float competitorTwoBirths;

            int numberofIterationsToRun = this.numberOfIterations();
            float[] timeSeries = new float[numberofIterationsToRun];
            float[] competitorOnePopulationSizeOverTime = new float[numberofIterationsToRun];
            float[] competitorTwoPopulationSizeOverTime = new float[numberofIterationsToRun];
            
            timeSeries[0] = 0;
            competitorOnePopulationSizeOverTime[0] = this.competitorOneInitialParameters.InitialPopulationSize;
            competitorTwoPopulationSizeOverTime[0] = this.competitorTwoInitialParameters.InitialPopulationSize;
            
            for (int iteration = 1; iteration < numberofIterationsToRun; iteration++)
            {
                timeSeries[iteration] = iteration * this.competitorOneInitialParameters.TimeIncrement;
                
                competitorOneDeaths = this.deaths(competitorTwoPopulationSizeOverTime[iteration - 1], this.competitorOneInitialParameters) * competitorOnePopulationSizeOverTime[iteration-1];
                competitorTwoDeaths = this.deaths(competitorOnePopulationSizeOverTime[iteration - 1], this.competitorTwoInitialParameters) * competitorTwoPopulationSizeOverTime[iteration - 1];
                
                competitorOneBirths = this.births(competitorOnePopulationSizeOverTime[iteration - 1], competitorOneInitialParameters);
                competitorTwoBirths = this.births(competitorTwoPopulationSizeOverTime[iteration - 1], competitorTwoInitialParameters);

                competitorOnePopulationSizeOverTime[iteration] = competitorOnePopulationSizeOverTime[iteration - 1] + ((competitorOneBirths - competitorOneDeaths) * this.competitorOneInitialParameters.TimeIncrement);
                competitorTwoPopulationSizeOverTime[iteration] = competitorTwoPopulationSizeOverTime[iteration - 1] + ((competitorTwoBirths - competitorTwoDeaths) * this.competitorOneInitialParameters.TimeIncrement);
            }

            this.competitorOneResults.TimeSeries = timeSeries;
            this.competitorOneResults.PopulationGrowthOverTime = competitorOnePopulationSizeOverTime;
            this.competitorTwoResults.TimeSeries = timeSeries;
            this.competitorTwoResults.PopulationGrowthOverTime = competitorTwoPopulationSizeOverTime;
            
        }

        private float births(float populationSize, InitialParameters initialparams)
        {
            return populationSize * initialparams.BirthFraction;
        }

        private float deaths(float populationSize, InitialParameters initialparams)
        {
            return populationSize * initialparams.DeathPropotionalityScore;
        }

        private int numberOfIterations()
        {
            return System.Convert.ToInt32(this.competitorOneInitialParameters.LengthofSimulation / this.competitorOneInitialParameters.TimeIncrement) + 1;
        }

    }
}
