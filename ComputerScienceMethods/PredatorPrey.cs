using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class PredatorPrey
    {
        private InitialParameters predatorInitialParameters;
        private InitialParameters preyInitialParameters;
        private ModelResults predatorResults;
        private ModelResults preyResults;
        private ModelResults predatorDeathRateResults;
        private ModelResults preyDeathRateResults;
        private int numberofIterationsToRun;
        private float[] timeSeries;
        private float[] predatorPopulationSizeOverTime;
        private float[] preyPopulationSizeOverTime;
        private float[] predatorGrowthRateOverTime;
        private float[] preyGrowthRateOverTime;

        private void initializeClassVariables()
        {
            this.numberofIterationsToRun = this.numberOfIterations();
            this.timeSeries = new float[numberofIterationsToRun];
            this.predatorPopulationSizeOverTime = new float[numberofIterationsToRun];
            this.preyPopulationSizeOverTime = new float[numberofIterationsToRun];
            this.predatorGrowthRateOverTime = new float[numberofIterationsToRun];
            this.preyGrowthRateOverTime = new float[numberofIterationsToRun];
        }

        public InitialParameters PredatorInitialParameters
        {
            set { this.predatorInitialParameters = value; }
        }

        public ModelResults PredatorResults
        {
            get { return this.predatorResults; }
        }

        public InitialParameters PreyInitialParameters
        {
            set { this.preyInitialParameters = value; }
        }

        public ModelResults PreyResults
        {
            get { return this.preyResults; }
        }

        public ModelResults PredatorDeathResults
        {
            get { return this.predatorDeathRateResults; }
        }

        public ModelResults PreyDeathResults
        {
            get { return this.preyDeathRateResults; }
        }

        public void StartModelPreyOnly()
        {
            this.initializeClassVariables();
            this.predatorResults = new ModelResults();
            this.preyResults = new ModelResults();

            float preyLotkaVolterra = 0;
            float changeInPopulation = 0;
            
            timeSeries[0] = 0;
            preyPopulationSizeOverTime[0] = this.preyInitialParameters.InitialPopulationSize;
            predatorPopulationSizeOverTime[0] = this.predatorInitialParameters.InitialPopulationSize;
            preyGrowthRateOverTime[0] = 0;
            predatorGrowthRateOverTime[0] = 0;

            for (int iteration = 1; iteration < numberofIterationsToRun; iteration++)
            {
                timeSeries[iteration] = iteration * this.preyInitialParameters.TimeIncrement;
                timeSeries[iteration] = iteration * this.predatorInitialParameters.TimeIncrement;
                System.Collections.Hashtable lotkavolterra = new System.Collections.Hashtable();

                lotkavolterra.Add("preybirthrate", this.preyInitialParameters.BirthFraction);
                lotkavolterra.Add("preypopulation", preyPopulationSizeOverTime[iteration - 1]);
                lotkavolterra.Add("preydeathrate", this.preyInitialParameters.DeathPropotionalityScore);
                lotkavolterra.Add("predatorpopulation", predatorPopulationSizeOverTime[iteration - 1]);
                lotkavolterra.Add("predatorbirthrate", this.predatorInitialParameters.BirthFraction);
                lotkavolterra.Add("predatordeathrate", this.predatorInitialParameters.DeathPropotionalityScore);

                preyLotkaVolterra = this.preyChangeInPopulationWithCarryingCapacity(this.preyInitialParameters, lotkavolterra);
                changeInPopulation = preyPopulationSizeOverTime[iteration - 1] + (preyLotkaVolterra * this.preyInitialParameters.TimeIncrement);
                
                if (changeInPopulation < (float)0)
                {
                    preyPopulationSizeOverTime[iteration] = (float)0;
                }
                else
                {
                    preyPopulationSizeOverTime[iteration] = changeInPopulation;
                }

                preyGrowthRateOverTime[iteration] = this.growthRate(preyPopulationSizeOverTime, iteration);

                predatorPopulationSizeOverTime[iteration] = this.predatorInitialParameters.InitialPopulationSize;

                predatorGrowthRateOverTime[iteration] = this.growthRate(predatorPopulationSizeOverTime, iteration);
            }

            this.preyResults.TimeSeries = timeSeries;
            this.preyResults.PopulationGrowthOverTime = preyPopulationSizeOverTime;
            this.preyResults.GrowthRateOverTime = preyGrowthRateOverTime;
            this.predatorResults.TimeSeries = timeSeries;
            this.predatorResults.PopulationGrowthOverTime = predatorPopulationSizeOverTime;
            this.predatorResults.GrowthRateOverTime = predatorGrowthRateOverTime;

        }

        public void StartModelPredatoryOnly()
        {
            this.initializeClassVariables();
            this.predatorResults = new ModelResults();
            this.preyResults = new ModelResults();

            float preyLotkaVolterra = 0;

            timeSeries[0] = 0;
            preyPopulationSizeOverTime[0] = this.preyInitialParameters.InitialPopulationSize;
            predatorPopulationSizeOverTime[0] = this.predatorInitialParameters.InitialPopulationSize;
            preyGrowthRateOverTime[0] = 0;
            predatorGrowthRateOverTime[0] = 0;

            for (int iteration = 1; iteration < numberofIterationsToRun; iteration++)
            {
                timeSeries[iteration] = iteration * this.preyInitialParameters.TimeIncrement;
                timeSeries[iteration] = iteration * this.predatorInitialParameters.TimeIncrement;
                System.Collections.Hashtable lotkavolterra = new System.Collections.Hashtable();

                lotkavolterra.Add("preybirthrate", this.preyInitialParameters.BirthFraction);
                lotkavolterra.Add("preypopulation", preyPopulationSizeOverTime[iteration - 1]);
                lotkavolterra.Add("preydeathrate", this.preyInitialParameters.DeathPropotionalityScore);
                lotkavolterra.Add("predatorpopulation", predatorPopulationSizeOverTime[iteration - 1]);
                lotkavolterra.Add("predatorbirthrate", this.predatorInitialParameters.BirthFraction);
                lotkavolterra.Add("predatordeathrate", this.predatorInitialParameters.DeathPropotionalityScore);

                preyLotkaVolterra = this.predatorChangeInPopulationWithCarryingCapacity(this.predatorInitialParameters, lotkavolterra);

                if ((predatorPopulationSizeOverTime[iteration - 1] + (preyLotkaVolterra * this.preyInitialParameters.TimeIncrement)) < 0)
                {
                    predatorPopulationSizeOverTime[iteration] = 0;
                }
                else
                {
                    predatorPopulationSizeOverTime[iteration] = predatorPopulationSizeOverTime[iteration - 1] + (preyLotkaVolterra * this.preyInitialParameters.TimeIncrement);
                }
                
                predatorGrowthRateOverTime[iteration] = this.growthRate(predatorPopulationSizeOverTime, iteration);

                preyPopulationSizeOverTime[iteration] = this.preyInitialParameters.InitialPopulationSize;
                predatorGrowthRateOverTime[iteration] = this.growthRate(predatorPopulationSizeOverTime, iteration);
            }

            this.preyResults.TimeSeries = timeSeries;
            this.preyResults.PopulationGrowthOverTime = preyPopulationSizeOverTime;
            this.preyResults.GrowthRateOverTime = preyGrowthRateOverTime;
            this.predatorResults.TimeSeries = timeSeries;
            this.predatorResults.PopulationGrowthOverTime = predatorPopulationSizeOverTime;
            this.predatorResults.GrowthRateOverTime = predatorGrowthRateOverTime;
        }

        public void StartModelCarryingCapacity()
        {

        }

        public void StartModel()
        {
            this.initializeClassVariables();
            this.predatorResults = new ModelResults();
            this.preyResults = new ModelResults();
            
            float preyLotkaVolterra = 0;
            float predatorLotkaVolterra = 0;

            timeSeries[0] = 0;
            preyPopulationSizeOverTime[0] = this.preyInitialParameters.InitialPopulationSize;
            predatorPopulationSizeOverTime[0] = this.predatorInitialParameters.InitialPopulationSize;
            preyGrowthRateOverTime[0] = 0;
            predatorGrowthRateOverTime[0] = 0;

            for (int iteration = 1; iteration < numberofIterationsToRun; iteration++)
            {
                timeSeries[iteration] = iteration * this.preyInitialParameters.TimeIncrement;
                timeSeries[iteration] = iteration * this.predatorInitialParameters.TimeIncrement;
                System.Collections.Hashtable lotkavolterra = new System.Collections.Hashtable();

                lotkavolterra.Add("preybirthrate", this.preyInitialParameters.BirthFraction);
                lotkavolterra.Add("preypopulation", preyPopulationSizeOverTime[iteration - 1]);
                lotkavolterra.Add("preydeathrate", this.preyInitialParameters.DeathPropotionalityScore);
                lotkavolterra.Add("predatorpopulation", predatorPopulationSizeOverTime[iteration - 1]);
                lotkavolterra.Add("predatorbirthrate", this.predatorInitialParameters.BirthFraction);
                lotkavolterra.Add("predatordeathrate", this.predatorInitialParameters.DeathPropotionalityScore);

                if (this.preyInitialParameters.CarryingCapacity < 1)
                {
                    preyLotkaVolterra = this.preyChangeInPopulation(lotkavolterra);
                    //preyPopulationSizeOverTime[iteration] = preyPopulationSizeOverTime[iteration - 1] + (preyLotkaVolterra * this.preyInitialParameters.TimeIncrement);
                    preyPopulationSizeOverTime[iteration] = this.returnzeroorgreater(preyPopulationSizeOverTime[iteration - 1],(preyLotkaVolterra * this.preyInitialParameters.TimeIncrement));
                }
                else
                {
                    preyLotkaVolterra = this.preyChangeInPopulationWithCarryingCapacity(this.preyInitialParameters, lotkavolterra);
                    //preyPopulationSizeOverTime[iteration] = preyPopulationSizeOverTime[iteration - 1] + (preyLotkaVolterra * this.preyInitialParameters.TimeIncrement);
                    preyPopulationSizeOverTime[iteration] = this.returnzeroorgreater(preyPopulationSizeOverTime[iteration - 1],(preyLotkaVolterra * this.preyInitialParameters.TimeIncrement));
                }

                preyGrowthRateOverTime[iteration] = this.growthRate(preyPopulationSizeOverTime,iteration);


                if(this.predatorInitialParameters.CarryingCapacity < 1)
                {
                    predatorLotkaVolterra = this.predatorChangeInPopulation(lotkavolterra);
                    //predatorPopulationSizeOverTime[iteration] = predatorPopulationSizeOverTime[iteration - 1] + (predatorLotkaVolterra * this.predatorInitialParameters.TimeIncrement);
                    predatorPopulationSizeOverTime[iteration] = this.returnzeroorgreater(predatorPopulationSizeOverTime[iteration - 1], (predatorLotkaVolterra * this.predatorInitialParameters.TimeIncrement));
                }
                else
                {
                    predatorLotkaVolterra = this.predatorChangeInPopulationWithCarryingCapacity(this.predatorInitialParameters,lotkavolterra);
                    //predatorPopulationSizeOverTime[iteration] = predatorPopulationSizeOverTime[iteration - 1] + (predatorLotkaVolterra *  this.predatorInitialParameters.TimeIncrement);
                    predatorPopulationSizeOverTime[iteration] = this.returnzeroorgreater(predatorPopulationSizeOverTime[iteration - 1], (predatorLotkaVolterra * this.predatorInitialParameters.TimeIncrement));
                }

                predatorGrowthRateOverTime[iteration] = this.growthRate(predatorPopulationSizeOverTime, iteration);
            }

            this.preyResults.TimeSeries = timeSeries;
            this.preyResults.PopulationGrowthOverTime = preyPopulationSizeOverTime;
            this.preyResults.GrowthRateOverTime = preyGrowthRateOverTime;
            this.predatorResults.TimeSeries = timeSeries;
            this.predatorResults.PopulationGrowthOverTime = predatorPopulationSizeOverTime;
            this.predatorResults.GrowthRateOverTime = predatorGrowthRateOverTime;
            
        }

        private float returnzeroorgreater(float currentPopulation, float populationChange)
        {
            float returnValue = currentPopulation + populationChange;

            if(returnValue < 0)
            {
                returnValue = 0;
            }
            
            return returnValue;
        }

        private float preyChangeInPopulation(System.Collections.Hashtable lotkavolterravariables)
        {
            float preydeaths = (float)lotkavolterravariables["preydeathrate"] * (float)lotkavolterravariables["preypopulation"] * (float)lotkavolterravariables["predatorpopulation"];
            float preybirths = (float)lotkavolterravariables["preybirthrate"] * (float)lotkavolterravariables["preypopulation"];
            return (preybirths - preydeaths);
        }

        private float predatorChangeInPopulation(System.Collections.Hashtable lotkavolterravariables)
        {
            float predatordeaths = (float)lotkavolterravariables["predatorbirthrate"] * (float)lotkavolterravariables["preypopulation"] * (float)lotkavolterravariables["predatorpopulation"];
            float predatorbirths = (float)lotkavolterravariables["predatordeathrate"] * (float)lotkavolterravariables["predatorpopulation"];
            return -(predatorbirths) + predatordeaths;
        }

        private float predatorChangeInPopulationWithCarryingCapacity(InitialParameters initialparams, System.Collections.Hashtable lotkavolterravariables)
        {
            float a = initialparams.GrowthRate * (float)lotkavolterravariables["predatorpopulation"];
            //float b = (float)lotkavolterravariables["predatorpopulation"] + (initialparams.DeathPropotionalityScore * (float)lotkavolterravariables["preypopulation"]);
            float b = (float)lotkavolterravariables["predatorpopulation"] + (initialparams.AlphaPN * (float)lotkavolterravariables["preypopulation"]);
            float c = b / initialparams.CarryingCapacity;
            float d = 1 - c;

            return a*d;
        }

        private float preyChangeInPopulationWithCarryingCapacity(InitialParameters initialparams, System.Collections.Hashtable lotkavolterravariables)
        {
            float a = initialparams.GrowthRate * (float)lotkavolterravariables["preypopulation"];
            //float b = (float)lotkavolterravariables["preypopulation"] + (initialparams.DeathPropotionalityScore * (float)lotkavolterravariables["predatorpopulation"]);
            float b = (float)lotkavolterravariables["preypopulation"] + (initialparams.AlphaNP * (float)lotkavolterravariables["predatorpopulation"]);
            float c = b / initialparams.CarryingCapacity;
            float d = 1 - c;
            
            return a*d;
        }

        private float deathrate(float populationSize, InitialParameters initialparams)
        {
            return initialparams.GrowthRate * (1 - (populationSize / initialparams.CarryingCapacity));
        }

        private int numberOfIterations()
        {
            return System.Convert.ToInt32(this.preyInitialParameters.LengthofSimulation / this.preyInitialParameters.TimeIncrement) + 1;
        }

        private float growth(float populationSize, InitialParameters initialparams)
        {
            return initialparams.GrowthRate * populationSize * initialparams.TimeIncrement;
        }

        private float growthRate(float[] populationSize, int locationtocalculate)
        {
            return ((populationSize[locationtocalculate] - populationSize[locationtocalculate - 1]) / populationSize[locationtocalculate - 1]) * 100;
        }

       
    }
}
