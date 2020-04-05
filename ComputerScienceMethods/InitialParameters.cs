using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class InitialParameters
    {
        private float deltaTime;
        private int initialPopulation;
        private float growthRate;
        private int simulationLength;
        private int carringcapacity;
        private float birthFraction;
        private float deathProportionalityConstant;
        private float competitionCoefficientPreyPredator;
        private float competitionCoefficientPredatorPrey;
        private bool runforPreyOnly;
        private bool runforPredatoryOnly;
        private float transmissionConstant;
        private float recoveryRate;


        public float TimeIncrement
        {
            get { return this.deltaTime; }
            set { this.deltaTime = value; }
        }

        public int InitialPopulationSize
        {
            get { return this.initialPopulation; }
            set { this.initialPopulation = value; }
        }

        public float GrowthRate
        {
            get { return this.growthRate; }
            set { this.growthRate = value; }
        }

        public int LengthofSimulation
        {
            get { return this.simulationLength; }
            set { this.simulationLength = value; }
        }

        public int CarryingCapacity
        {
            get { return this.carringcapacity; }
            set { this.carringcapacity = value; }
        }

        public float BirthFraction
        {
            get { return this.birthFraction; }
            set { this.birthFraction = value; }
        }

        public float DeathPropotionalityScore
        {
            get { return this.deathProportionalityConstant; }
            set { this.deathProportionalityConstant = value; }
        }

        public float AlphaNP
        {
            get { return this.competitionCoefficientPreyPredator; }
            set { this.competitionCoefficientPreyPredator = value; }
        }

        public float AlphaPN
        {
            get { return this.competitionCoefficientPredatorPrey; }
            set { this.competitionCoefficientPredatorPrey = value; }
        }

        public bool RunForPreyOnly
        {
            get { return this.runforPreyOnly; }
            set { this.runforPreyOnly = value; }
        }

        public bool RunForPredatorOnly
        {
            get { return this.runforPredatoryOnly; }
            set { this.runforPredatoryOnly = value; }
        }

        public float TransmissionConstant
        {
            get { return this.transmissionConstant; }
            set { this.transmissionConstant = value; }
        }

        public float RecoveryRate
        {
            get { return this.recoveryRate; }
            set { this.recoveryRate = value; }
        }
    }
}
