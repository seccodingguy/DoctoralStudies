using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class Malaria: PredatorPrey
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
            this.uninfectedhumansPopulationSizeOverTime[0] = this.initialParams.InitialUninfectedMosquitosPopulation;
            this.humanhostsPopulationSizeOverTime[0] = this.initialParams.InitialPopulationSize;
            this.immunePopulationSizeOverTime[0] = this.initialParams.InitialImmunePopulation;
            this.uninfectedmosquitosPopulationSizeOverTime[0] = this.initialParams.InitialUninfectedMosquitosPopulation;
            this.vectorsPopulationSizeOverTime[0] = this.initialParams.InitialNumberOfVectors;
            this.probabilityhostPopulationSizeOverTime[0] = this.probablityofHostInfection(this.humanhostsPopulationSizeOverTime[0], this.uninfectedhumansPopulationSizeOverTime[0], this.immunePopulationSizeOverTime[0]);
        }

        public MalariaInitialParameters InitialParameters
        {
            get { return this.initialParams; }
            set { this.initialParams = value; }
        }

        private void StartModel()
        {
            this.initializeClassLevelVariables();

            float populationsizeincrease = 0;

            for(int iteration = 0; iteration < this.numberofIterationsToRun; iteration++)
            {
                timeSeries[iteration] = iteration * this.initialParams.TimeIncrement;

                populationsizeincrease = this.uninfectedHumansPopulation(this.uninfectedhumansPopulationSizeOverTime[iteration - 1], this.humanhostsPopulationSizeOverTime[iteration - 1], this.probabilityvectorPopulationSizeOverTime[iteration - 1])*this.initialParams.TimeIncrement;
                this.uninfectedhumansPopulationSizeOverTime[iteration] = this.returnzeroorgreater(this.uninfectedhumansPopulationSizeOverTime[iteration - 1], populationsizeincrease);

                populationsizeincrease = this.humanHostsPopulation(this.probabilityvectorPopulationSizeOverTime[iteration - 1], this.humanhostsPopulationSizeOverTime[iteration - 1]) * this.initialParams.TimeIncrement;
                this.humanhostsPopulationSizeOverTime[iteration] = populationsizeincrease;
            }



        }


        private float uninfectedHumansPopulation(float uninfectedhumanspopulationsize, float humanhostspopulationsize, float probabilityvector)
        {
            
            float returnValue = 0;

            returnValue = (this.initialParams.RecoveryRate * humanhostspopulationsize) - (this.initialParams.ProbabilityToBiteAHuman * probabilityvector * uninfectedhumanspopulationsize);

            return returnValue;
        }

        private float humanHostsPopulation(float probabilityvector, float humanhostpopulationsize)
        {
            float returnValue = 0;

            returnValue = (this.initialParams.ProbabilityToBiteAHuman * probabilityvector * humanhostpopulationsize) - (this.initialParams.ImmunityRate * humanhostpopulationsize) - (this.initialParams.RecoveryRate * humanhostpopulationsize) - (this.initialParams.MalariaInducedDeathRate*humanhostpopulationsize);

            return returnValue;
        }

        private float immunePopulation(float humanhostpopulationsize)
        {
            float returnValue = 0;

            returnValue = this.initialParams.ImmunityRate * humanhostpopulationsize;

            return returnValue;
        }

        private float uninfectedMosquitosPopulation(float uninfectedmosquitopopulationsize, float uninfectedhumanspopulationsize, float humanhostspopulationsize, float immunepopulationsize)
        {
            float returnValue = 0;
            float probabilitofhostinfection = this.probablityofHostInfection(humanhostspopulationsize, uninfectedhumanspopulationsize,immunepopulationsize);
            returnValue = (this.initialParams.MosquitoBirthRate * uninfectedmosquitopopulationsize) - (this.initialParams.ProbabilityToBiteAHuman * uninfectedmosquitopopulationsize * probabilitofhostinfection) - (this.initialParams.MosquitoDeathRate*uninfectedmosquitopopulationsize); - ();

            return returnValue;
        }

        private float probablityofHostInfection(float humanhostspopulationsize, float uninfectedhumanspopulationsize, float immunepopulationsize)
        {
            float probabilitofhostinfection = humanhostspopulationsize / (uninfectedhumanspopulationsize + humanhostspopulationsize + immunepopulationsize);
            
            return probabilitofhostinfection;
        }

        private float vectorsPopulation(float vectorpopulationsize, float uninfectedmosquitopopulationsize, float uninfectedhumanspopulationsize, float humanhostspopulationsize, float immunepopulationsize)
        {
            float returnValue = 0;
            
            float probabilitofhostinfection = humanhostspopulationsize / (uninfectedhumanspopulationsize + humanhostspopulationsize + immunepopulationsize);

            returnValue = (this.initialParams.ProbabilityToBiteAHuman * probabilitofhostinfection * uninfectedhumanspopulationsize) - (this.initialParams.MosquitoDeathRate * vectorpopulationsize);

            return returnValue;
        }

        private float probabilityvector(float vectorpopulationsize, float uninfectedmosquitospopulationsize)
        {
            float returnValue = 0;

            returnValue = vectorpopulationsize / (uninfectedmosquitospopulationsize+vectorpopulationsize);

            return returnValue;
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
            return System.Convert.ToInt32(this.initialParams.LengthofSimulation / this.initialParams.TimeIncrement) + 1;
        }


    }
}
