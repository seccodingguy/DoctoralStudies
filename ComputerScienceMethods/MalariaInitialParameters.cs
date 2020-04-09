using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class MalariaInitialParameters: InitialParameters
    {
        private float malariainduceddeathrate;
        private float probabilityofgettingbit;
        private float mosquitobirthrate;
        private float mosquitodeathrate;
        private float probabilitytobiteahuman;
        private float immunityrate;
        private int initialsusceptiblepopulation;
        private int initialimmunepopulation;
        private int initialuninfectedmosquitos;
        private int initialnumberofvectors;
        private int initialhumanhostspopulation;

        public float MalariaInducedDeathRate
        {
            get { return this.malariainduceddeathrate; }
            set { this.malariainduceddeathrate = value; }
        }

        public float ProbabilityOfGettingBit
        {
            get { return this.probabilityofgettingbit; }
            set { this.probabilityofgettingbit = value; }
        }

        public float MosquitoBirthRate
        {
            get { return this.mosquitobirthrate; }
            set { this.mosquitobirthrate = value; }
        }

        public float MosquitoDeathRate
        {
            get { return this.mosquitodeathrate; }
            set { this.mosquitodeathrate = value; }
        }

        public float ProbabilityToBiteAHuman
        {
            get { return this.probabilitytobiteahuman; }
            set { this.probabilitytobiteahuman = value; }
        }

        public float ImmunityRate
        {
            get { return this.immunityrate; }
            set { this.immunityrate = value; }
        }

        public int InitialSusceptablePopulation
        {
            get { return this.initialsusceptiblepopulation; }
            set { this.initialsusceptiblepopulation = value; }
        }

        public int InitialImmunePopulation
        {
            get { return this.initialimmunepopulation; }
            set { this.initialimmunepopulation = value; }
        }

        public int InitialUninfectedMosquitosPopulation
        {
            get { return this.initialuninfectedmosquitos; }
            set { this.initialuninfectedmosquitos = value; }
        }

        public int InitialNumberOfVectors
        {
            get { return this.initialnumberofvectors; }
            set { this.initialnumberofvectors = value; }
        }

        public int InitialHumanHostsPopulation
        {
            get { return this.initialhumanhostspopulation; }
            set { this.initialhumanhostspopulation = value; }
        }
    }
}
