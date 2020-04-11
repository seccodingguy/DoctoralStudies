using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceMethods
{
    public class ComputationalErrorParameters
    {
        int magnitude = 0;
        float significantvalue = 0;
        float calculatedvalue = 0;
        float absoluteError = 0;
        float relativeError = 0;
        float originalnumber = 0;
        int precision = 0;
        int mostsignificantdigit = 0;
        String aen = "";

        public int Magnitude
        {
            get { return this.magnitude; }
            set { this.magnitude = value; }
        }

        public float NormalizedSignificantValue
        {
            get { return this.significantvalue; }
            set { this.significantvalue = value; }
        }
        
        public float AbsoluteError
        {
            get { return this.absoluteError; }
            set { this.absoluteError = value; }
        }

        public float RelativeError
        {
            get { return this.relativeError; }
            set { this.relativeError = value; }
        }

        public float CalculatedValue
        {
            get { return this.calculatedvalue; }
            set { this.calculatedvalue = value; }
        }

        public float OriginalNumber
        {
            get { return this.originalnumber; }
            set { this.originalnumber = value; }
        }

        public String AEN
        {
            get { return (this.significantvalue.ToString() + " x 10^" + this.magnitude.ToString()); }
        }

        public int Precision
        {
            get 
            {
                String[] digitsinsignificantvalue = this.significantvalue.ToString().Split('.');
                return digitsinsignificantvalue[1].ToCharArray().Length;
            }
        }

        public int MostSignificantDigit
        {
            get 
            {
                char[] digitsinsignificantvalue = this.significantvalue.ToString().ToCharArray();
                int returnValue = 0;

                for(int i = 0; i < digitsinsignificantvalue.Length; i++)
                {
                    if(digitsinsignificantvalue[i] == '.')
                    {
                        returnValue = System.Convert.ToInt32(digitsinsignificantvalue[i + 1].ToString());
                        i = digitsinsignificantvalue.Length + 1;
                    }
                }

                return returnValue; 
            }
        }
    }
}
