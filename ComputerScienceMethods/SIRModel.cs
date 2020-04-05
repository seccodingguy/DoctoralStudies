using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class SIRModel
    {
        private InitialParameters susceptableIndividualsInitialParameters;
        private InitialParameters infectedIndividualsInitialParameters;
        private InitialParameters removedIndividualsInitialParameters;
        private ModelResults susceptableIndividualsResults;
        private ModelResults infectedIndividualsResults;
        private ModelResults removedIndividualsResults;
        private int numberofIterationsToRun;
        private float[] timeSeries;
        private float[] susceptablePopulationSizeOverTime;
        private float[] infectedPopulationSizeOverTime;
        private float[] removedPopulationSizeOverTime;

        private void initializeClassLevelVariables()
        {
            this.numberofIterationsToRun = this.numberOfIterations();
            this.timeSeries = new float[this.numberofIterationsToRun];
            this.susceptablePopulationSizeOverTime = new float[this.numberofIterationsToRun];
            this.infectedPopulationSizeOverTime = new float[this.numberofIterationsToRun];
            this.removedPopulationSizeOverTime = new float[this.numberofIterationsToRun];
            this.susceptableIndividualsResults = new ModelResults();
            this.infectedIndividualsResults = new ModelResults();
            this.removedIndividualsResults = new ModelResults();

        }

        public InitialParameters SusceptableIndividualsInitialParameters
        {
            set { this.susceptableIndividualsInitialParameters = value; }
        }

        public InitialParameters InfectedIndividualsInitialParameters
        {
            set { this.infectedIndividualsInitialParameters = value; }
        }

        public InitialParameters RemovedIndividualsInitialParameters
        {
            set { this.removedIndividualsInitialParameters = value; }
        }

        public ModelResults SusceptablePopulation
        {
            get { return this.susceptableIndividualsResults; }
        }

        public ModelResults InfectionPopulation
        {
            get { return this.infectedIndividualsResults; }
        }

        public ModelResults RemovedPopulation
        {
            get { return this.removedIndividualsResults; }
        }

        public void StartModel()
        {
            this.initializeClassLevelVariables();

            float populationsizeincrease = 0;

            timeSeries[0] = 0;
            this.susceptablePopulationSizeOverTime[0] = this.susceptableIndividualsInitialParameters.InitialPopulationSize;
            this.infectedPopulationSizeOverTime[0] = this.infectedIndividualsInitialParameters.InitialPopulationSize;
            this.removedPopulationSizeOverTime[0] = this.removedIndividualsInitialParameters.InitialPopulationSize;

            for (int interval = 1; interval < this.numberofIterationsToRun; interval++)
            {
                timeSeries[interval] = interval * this.susceptableIndividualsInitialParameters.TimeIncrement;

                populationsizeincrease = this.susceptableIndividuals(this.susceptablePopulationSizeOverTime[interval - 1], this.infectedPopulationSizeOverTime[interval - 1]) * this.susceptableIndividualsInitialParameters.TimeIncrement;
                this.susceptablePopulationSizeOverTime[interval] = this.returnzeroorgreater(this.susceptablePopulationSizeOverTime[interval - 1], populationsizeincrease);

                populationsizeincrease = this.infectedIndividuals(this.susceptablePopulationSizeOverTime[interval - 1], this.infectedPopulationSizeOverTime[interval - 1]) * this.susceptableIndividualsInitialParameters.TimeIncrement;
                this.infectedPopulationSizeOverTime[interval] = this.returnzeroorgreater(this.infectedPopulationSizeOverTime[interval - 1], populationsizeincrease);
                
                populationsizeincrease = this.removedIndividuals(this.infectedPopulationSizeOverTime[interval - 1]) * this.susceptableIndividualsInitialParameters.TimeIncrement;
                this.removedPopulationSizeOverTime[interval] = this.returnzeroorgreater(this.removedPopulationSizeOverTime[interval - 1], populationsizeincrease);
            }

            this.susceptableIndividualsResults.TimeSeries = timeSeries;
            this.infectedIndividualsResults.TimeSeries = timeSeries;
            this.removedIndividualsResults.TimeSeries = timeSeries;
            this.susceptableIndividualsResults.PopulationGrowthOverTime = this.susceptablePopulationSizeOverTime;
            this.infectedIndividualsResults.PopulationGrowthOverTime = this.infectedPopulationSizeOverTime;
            this.removedIndividualsResults.PopulationGrowthOverTime = this.removedPopulationSizeOverTime;

        }

        private float susceptableIndividuals(float susceptablePopulationSize, float infectedPopulationSize)
        {
            return -this.susceptableIndividualsInitialParameters.TransmissionConstant * susceptablePopulationSize * infectedPopulationSize;
        }

        private float infectedIndividuals(float susceptablePopulationSize, float infectedPopulationSize)
        {
            return (-susceptableIndividuals(susceptablePopulationSize, infectedPopulationSize)) - (this.infectedIndividualsInitialParameters.RecoveryRate * infectedPopulationSize);
        }

        private float removedIndividuals(float infectedPopulationSize)
        {
            return this.removedIndividualsInitialParameters.RecoveryRate * infectedPopulationSize;
        }

        private float returnzeroorgreater(float currentPopulation, float populationChange)
        {
            float returnValue = currentPopulation + populationChange;

            if (returnValue < 0)
            {
                returnValue = 0;
            }

            return returnValue;
        }

        private int numberOfIterations()
        {
            return System.Convert.ToInt32(this.susceptableIndividualsInitialParameters.LengthofSimulation / this.susceptableIndividualsInitialParameters.TimeIncrement) + 1;
        }
    }
}
