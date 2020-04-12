using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class ComputationalError
    {
        private Double originalnumber;
        private Double normalizedsignificantvalue;
        private int magnitude = 0;
        private int numberofsignificantdigits;

        public Double OriginalNumber
        {
            get { return this.originalnumber; }
            set { this.originalnumber = value; }
        }

        public Double NormalizedSignificantValue
        {
            get { return this.normalizedsignificantvalue; }
            set { this.normalizedsignificantvalue = value; }
        }

        public int Magnitude
        {
            get { return this.magnitude; }
            set { this.magnitude = value; }
        }

        public void significantDigitsOfANumber()
        {
            String[] digitsinoriginalnumber = this.originalnumber.ToString().Split('.');

            if (digitsinoriginalnumber.Length > 1 && System.Convert.ToInt32(digitsinoriginalnumber[0]) > 0)
            {
                this.normalizedSignificantValueWithDigitsBeforeDecimal();
            }
            else
            {
                this.normalizedSignificantValueWithoutDigitsBeforeDecimal();
            }
        }

        private void normalizedSignificantValueWithDigitsBeforeDecimal()
        {
            String[] digitsinoriginalnumber = this.originalnumber.ToString().Split('.');
            int numberofnonzerodigitsbeforedecimalpoint = 0;
            StringBuilder normalizedsignificantvalue = new StringBuilder();
            normalizedsignificantvalue.Append('.');

            numberofnonzerodigitsbeforedecimalpoint = this.numberOfDigitsPriorToDecimalPoint(float.Parse(digitsinoriginalnumber[0]));
            char[] digitspriortodecimalpoint = digitsinoriginalnumber[0].ToCharArray();
            char[] digitsafterdecimalpoint = digitsinoriginalnumber[1].ToCharArray();

            for (int iteration = (digitspriortodecimalpoint.Length - numberofnonzerodigitsbeforedecimalpoint); iteration < digitspriortodecimalpoint.Length; iteration++)
            {
                normalizedsignificantvalue.Append(digitspriortodecimalpoint[iteration]);
            }

            for (int iteration = 0; iteration < digitsafterdecimalpoint.Length; iteration++)
            {
                normalizedsignificantvalue.Append(digitsafterdecimalpoint[iteration]);
            }

            this.magnitude = this.magnitude + numberofnonzerodigitsbeforedecimalpoint;
            this.normalizedsignificantvalue = Double.Parse(normalizedsignificantvalue.ToString());

        }

        private StringBuilder normalizedSignificantValueWithoutDigitsBeforeDecimal()
        {
            String[] digitsinoriginalnumber = this.originalnumber.ToString().Split('.');
            int numberofzerosbeforenonzerodigitafterdecimalpoint = this.numberOfDigitsAfterDecimalPoint(this.originalnumber);
            char[] digitsafterdecimalpoint = digitsinoriginalnumber[1].ToCharArray();
            StringBuilder normalizedsignificantvalue = new StringBuilder();
            normalizedsignificantvalue.Append('.');

            for (int iteration = (digitsafterdecimalpoint.Length - numberofzerosbeforenonzerodigitafterdecimalpoint); iteration < digitsafterdecimalpoint.Length; iteration++)
            {
                normalizedsignificantvalue.Append(digitsafterdecimalpoint[iteration]);
            }

            this.magnitude = this.magnitude + (digitsafterdecimalpoint.Length - numberofzerosbeforenonzerodigitafterdecimalpoint);
            this.normalizedsignificantvalue = Double.Parse(normalizedsignificantvalue.ToString());

            return normalizedsignificantvalue;
        }

        private int numberOfZerosBeforeNonZeroDigit(char[] value)
        {
            int returnValue = 0;

            for (int d = 0; d < value.Length; d++)
            {
                if (value[d] == '0')
                {
                    returnValue++;
                }
                if (value[d] != '0')
                {
                    d = value.Length + 1;
                }
            }

            return returnValue;
        }

        private int numberOfDigitsPriorToDecimalPoint(Double value)
        {
            int returnValue = 0;
            int numberofzerosbeforenonzerodigit = 0;

            char[] digitsbeforedecimalpoint = value.ToString().ToCharArray();
            numberofzerosbeforenonzerodigit = this.numberOfZerosBeforeNonZeroDigit(digitsbeforedecimalpoint);
            returnValue = digitsbeforedecimalpoint.Length - numberofzerosbeforenonzerodigit;

            return returnValue;
        }

        private int numberOfDigitsAfterDecimalPoint(Double value)
        {
            int returnValue = 0;
            int numberofzerosbeforenonzerodigit = 0;
            String[] seperatedecimalfromdigits = value.ToString().Split('.');

            char[] digitsafterdecimalpoint = seperatedecimalfromdigits[1].ToCharArray();
            numberofzerosbeforenonzerodigit = this.numberOfZerosBeforeNonZeroDigit(digitsafterdecimalpoint);
            returnValue = digitsafterdecimalpoint.Length - numberofzerosbeforenonzerodigit;

            return returnValue;
        }
    }
}
