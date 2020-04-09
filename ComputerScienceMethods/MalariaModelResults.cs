using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class MalariaModelResults
    {
        ModelResults uninfectedHumansPopulation = new ModelResults();
        ModelResults humanHostsPopulation = new ModelResults();
        ModelResults immunePopulation = new ModelResults();
        ModelResults uninfectedMosquitosPopulation = new ModelResults();
        ModelResults vectorsPopulation = new ModelResults();
        ModelResults probabilityhostPopulation = new ModelResults();
        ModelResults probabilityvectorPopulation = new ModelResults();

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
            get { return this.uninfectedMosquitosPopulation; }
            set { this.uninfectedMosquitosPopulation = value; }
        }

        public ModelResults VectorsPopulation
        {
            get { return this.vectorsPopulation; }
            set { this.vectorsPopulation = value; }
        }

        public ModelResults ProbabilityHostPopulation
        {
            get { return this.probabilityhostPopulation; }
            set { this.probabilityhostPopulation = value; }
        }

        public ModelResults ProbabilityVectorPopulation
        {
            get { return this.probabilityvectorPopulation; }
            set { this.probabilityvectorPopulation = value; }
        }
    }
}
