using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class MalariaModelResults
    {
        ModelResults uninfectedHumansPopulation;
        ModelResults humanHostsPopulation;
        ModelResults immunePopulation;
        ModelResults uninfectedMosquitosPopulation;
        ModelResults vectorsPopulation;

        public ModelResults UninfectedHumansPopulation
        {
            get { return this.uninfectedHumansPopulation; }
            set { this.uninfectedHumansPopulation = value; }
        }

        public ModelResults ImmunePopulation
        {
            get { return this.immunePopulation; }
            set { this.immunePopulation = value; }
        }

        public ModelResults HumanHostsPopulation
        {
            get { return this.humanHostsPopulation; }
            set { this.humanHostsPopulation = value; }
        }

        public ModelResults UninfectedMosquitosPopulation
        {
            get { return this.uninfectedHumansPopulation; }
            set { this.uninfectedHumansPopulation = value; }
        }

        public ModelResults VectorsPopulation
        {
            get { return this.vectorsPopulation; }
            set { this.vectorsPopulation = value; }
        }
    }
}
