using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class Malaria
    {
        private MalariaInitialParameters initialParams;
        private MalariaModelResults modelResults;
        private int numberofIterationsToRun;
        private float[] timeSeries;
        private float[] uninfectedhumansPopulationSizeOverTime;
        private float[] humanhostsPopulationSizeOverTime;
        private float[] immunePopulationSizeOverTime;
        private float[] uninfectedmosquitosPopulationSizeOverTime;
        private float[] vectorsPopulationSizeOverTime;
        private float[] probabilityhostPopulationSizeOverTime;
        private float[] probabilityvectorPopulationSizeOverTime;

        private void initializeClassLevelVariables()
        {
            this.numberofIterationsToRun = this.numberOfIterations();
            this.modelResults = new MalariaModelResults();

            this.timeSeries = new float[this.numberofIterationsToRun];
            this.uninfectedhumansPopulationSizeOverTime = new float[this.numberofIterationsToRun];
            this.humanhostsPopulationSizeOverTime = new float[this.numberofIterationsToRun];
            this.immunePopulationSizeOverTime = new float[this.numberofIterationsToRun];
            this.uninfectedmosquitosPopulationSizeOverTime = new float[this.numberofIterationsToRun];
            this.vectorsPopulationSizeOverTime = new float[this.numberofIterationsToRun];
            this.probabilityhostPopulationSizeOverTime = new float[this.numberofIterationsToRun];
            this.probabilityvectorPopulationSizeOverTime = new float[this.numberofIterationsToRun];

            timeSeries[0] = 0;
            this.uninfectedhumansPopulationSizeOverTime[0] = this.initialParams.InitialPopulationSize;
            this.humanhostsPopulationSizeOverTime[0] = this.initialParams.InitialHumanHostsPopulation;
            this.immunePopulationSizeOverTime[0] = this.initialParams.InitialImmunePopulation;
            this.uninfectedmosquitosPopulationSizeOverTime[0] = this.initialParams.InitialUninfectedMosquitosPopulation;
            this.vectorsPopulationSizeOverTime[0] = this.initialParams.InitialNumberOfVectors;
            this.probabilityhostPopulationSizeOverTime[0] = this.probablityofHostInfection(0);
        }

        public MalariaInitialParameters InitialParameters
        {
            get { return this.initialParams; }
            set { this.initialParams = value; }
        }

        public MalariaModelResults ModelRunDataResults
        {
            get { return this.modelResults; }
        }
        
        public void StartModel()
        {
            this.initializeClassLevelVariables();

            float populationsizeincrease = 0;

            for(int iteration = 1; iteration < this.numberofIterationsToRun; iteration++)
            {
                timeSeries[iteration] = iteration * this.initialParams.TimeIncrement;

                populationsizeincrease = this.uninfectedHumansPopulation(iteration);
                this.uninfectedhumansPopulationSizeOverTime[iteration] = this.returnzeroorgreater(this.uninfectedhumansPopulationSizeOverTime[iteration - 1], populationsizeincrease);

                populationsizeincrease = this.humanHostsPopulation(iteration);
                this.humanhostsPopulationSizeOverTime[iteration] = this.returnzeroorgreater(this.humanhostsPopulationSizeOverTime[iteration-1],populationsizeincrease);
                
                populationsizeincrease = this.immunePopulation(iteration);
                this.immunePopulationSizeOverTime[iteration] = this.returnzeroorgreater(this.immunePopulationSizeOverTime[iteration - 1], populationsizeincrease);

                populationsizeincrease = this.uninfectedMosquitosPopulation(iteration);
                this.uninfectedmosquitosPopulationSizeOverTime[iteration] = this.returnzeroorgreater(this.uninfectedmosquitosPopulationSizeOverTime[iteration - 1], populationsizeincrease);
                
                populationsizeincrease = this.vectorsPopulation(iteration);
                this.vectorsPopulationSizeOverTime[iteration] = this.returnzeroorgreater(this.vectorsPopulationSizeOverTime[iteration - 1], populationsizeincrease);

                populationsizeincrease = this.probabilityvector(iteration);
                this.probabilityvectorPopulationSizeOverTime[iteration] = populationsizeincrease; // this.probabilityvectorPopulationSizeOverTime[iteration - 1] + populationsizeincrease;

                populationsizeincrease = this.probablityofHostInfection(iteration);
                this.probabilityhostPopulationSizeOverTime[iteration] = populationsizeincrease; // this.probabilityhostPopulationSizeOverTime[iteration - 1] + populationsizeincrease; 

            }

            this.modelResults.UninfectedHumansPopulation.TimeSeries = this.timeSeries;
            this.modelResults.UninfectedHumansPopulation.PopulationGrowthOverTime = this.uninfectedhumansPopulationSizeOverTime;

            this.modelResults.HumanHostsPopulation.TimeSeries = this.timeSeries;
            this.modelResults.HumanHostsPopulation.PopulationGrowthOverTime = this.humanhostsPopulationSizeOverTime;

            this.modelResults.ImmunePopulation.TimeSeries = this.timeSeries;
            this.modelResults.ImmunePopulation.PopulationGrowthOverTime = this.immunePopulationSizeOverTime;

            this.modelResults.UninfectedMosquitosPopulation.TimeSeries = this.timeSeries;
            this.modelResults.UninfectedMosquitosPopulation.PopulationGrowthOverTime = this.uninfectedmosquitosPopulationSizeOverTime;

            this.modelResults.VectorsPopulation.TimeSeries = this.timeSeries;
            this.modelResults.VectorsPopulation.PopulationGrowthOverTime = this.vectorsPopulationSizeOverTime;

            this.modelResults.ProbabilityVectorPopulation.TimeSeries = this.timeSeries;
            this.modelResults.ProbabilityVectorPopulation.PopulationGrowthOverTime = this.probabilityvectorPopulationSizeOverTime;
            
            this.modelResults.ProbabilityHostPopulation.TimeSeries = this.timeSeries;
            this.modelResults.ProbabilityHostPopulation.PopulationGrowthOverTime = this.probabilityhostPopulationSizeOverTime;

        }


        private float uninfectedHumansPopulation(int currentiteration)
        {

            float returnValue = 0;
            float a = this.initialParams.RecoveryRate * this.humanhostsPopulationSizeOverTime[currentiteration - 1];
            float b = this.initialParams.ProbabilityOfGettingBit * this.probabilityvectorPopulationSizeOverTime[currentiteration - 1] * this.uninfectedhumansPopulationSizeOverTime[currentiteration - 1];
            
            returnValue = (a) - (b);

            return returnValue;
        }

        
        private float humanHostsPopulation(int currentiteration)
        {
            float returnValue = 0;
            float a = this.initialParams.ProbabilityOfGettingBit * this.probabilityvectorPopulationSizeOverTime[currentiteration-1] * this.uninfectedhumansPopulationSizeOverTime[currentiteration-1];
            float b = this.initialParams.ImmunityRate * this.humanhostsPopulationSizeOverTime[currentiteration-1];
            float c = this.initialParams.RecoveryRate * this.humanhostsPopulationSizeOverTime[currentiteration - 1];
            float d = this.initialParams.MalariaInducedDeathRate * this.humanhostsPopulationSizeOverTime[currentiteration - 1];

            returnValue = (a) - (b) - (c) - (d);

            return returnValue;
        }

        private float immunePopulation(float humanhostpopulationsize)
        {
            float returnValue = 0;

            returnValue = this.initialParams.ImmunityRate * humanhostpopulationsize;

            return returnValue;
        }

        private float immunePopulation(int currentiteration)
        {
            float returnValue = 0;

            returnValue = this.initialParams.ImmunityRate * this.humanhostsPopulationSizeOverTime[currentiteration-1];

            return returnValue;
        }


        private float uninfectedMosquitosPopulation(int currentiteration)
        {
            float returnValue = 0;
            float a = this.initialParams.MosquitoBirthRate * this.uninfectedmosquitosPopulationSizeOverTime[currentiteration - 1];
            float b = this.initialParams.ProbabilityToBiteAHuman * this.uninfectedmosquitosPopulationSizeOverTime[currentiteration - 1] * this.probabilityhostPopulationSizeOverTime[currentiteration-1];
            float c = this.initialParams.MosquitoDeathRate * this.uninfectedmosquitosPopulationSizeOverTime[currentiteration - 1];
            
            returnValue = (a) - (b) - (c);

            return returnValue;
        }


        private float probablityofHostInfection(int currentiteration)
        {
            float a = this.humanhostsPopulationSizeOverTime[currentiteration];
            float b = this.uninfectedhumansPopulationSizeOverTime[currentiteration] + this.humanhostsPopulationSizeOverTime[currentiteration] + this.immunePopulationSizeOverTime[currentiteration];

            float probabilitofhostinfection = (a) / (b);

            return probabilitofhostinfection;
        }

        
        private float vectorsPopulation(int currentiteration)
        {
            float returnValue = 0;

            float a = this.initialParams.ProbabilityToBiteAHuman * this.probabilityhostPopulationSizeOverTime[currentiteration-1] * this.uninfectedmosquitosPopulationSizeOverTime[currentiteration - 1];
            float b = this.initialParams.MosquitoDeathRate * this.vectorsPopulationSizeOverTime[currentiteration - 1];
            
            returnValue = (a) - (b);

            return returnValue;
        }

        private float probabilityvector(int currentiteration)
        {
            float returnValue = 0;
            float a = this.vectorsPopulationSizeOverTime[currentiteration];
            float b = this.uninfectedmosquitosPopulationSizeOverTime[currentiteration] * this.vectorsPopulationSizeOverTime[currentiteration];
            returnValue = (a) / (b);

            return returnValue;
        }

        private float returnzeroorgreater(float currentPopulation, float populationChange)
        {
            float returnValue = currentPopulation + populationChange * this.initialParams.TimeIncrement;

            if (returnValue < 0)
            {
                returnValue = 0;
            }

            return returnValue;
        }

        private int numberOfIterations()
        {
            return System.Convert.ToInt32(this.initialParams.LengthofSimulation / this.initialParams.TimeIncrement) + 1;
        }


    }
}
