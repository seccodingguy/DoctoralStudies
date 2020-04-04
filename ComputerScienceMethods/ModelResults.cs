using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class ModelResults
    {
        private Array timeSeries;
        private Array populationGrowthOverTime;
        private Array deathRateOverTime;
        private Array growthRateOverTime;
        

        public Array TimeSeries
        {
            get { return this.timeSeries; }
            set { this.timeSeries = value; }
        }

        public Array PopulationGrowthOverTime
        {
            get { return this.populationGrowthOverTime; }
            set { this.populationGrowthOverTime = value; }
        }

        public Array DeathRateOverTime
        {
            get { return this.deathRateOverTime; }
            set { this.deathRateOverTime = value; }
        }

        public Array GrowthRateOverTime
        {
            get { return this.growthRateOverTime; }
            set { this.growthRateOverTime = value; }
        }

    }
}
