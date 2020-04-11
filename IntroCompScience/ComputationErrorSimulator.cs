using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerScienceMethods;

namespace IntroCompScience
{
    public partial class ComputationErrorSimulator : Form
    {
        private int movedecimalpointnumberofplaces;
        private int originalpoweroftenexponent;
        private float significantvalue;
        private ComputationalErrorParameters comperrorparams = new ComputationalErrorParameters();

        public ComputationErrorSimulator()
        {
            InitializeComponent();
        }

        private void CalculatePrecision_Click(object sender, EventArgs e)
        {
            float floatingpointvalue = float.Parse(this.FloatingPointNumber.Text);

            this.originalpoweroftenexponent = System.Convert.ToInt32(this.PowerOfTen.Text);
            this.comperrorparams.Magnitude = System.Convert.ToInt32(this.PowerOfTen.Text);
            this.comperrorparams.OriginalNumber = float.Parse(this.FloatingPointNumber.Text);

            if(!this.isNumberAnInteger())
            {
                Decimal numbertotruncate = System.Convert.ToDecimal(this.FloatingPointNumber.Text);
                Console.WriteLine(Math.Truncate(numbertotruncate));
            }
            else
            {
                this.significantDigitsOfAFloat();
                
            }
            

        }

        private void significantDigitsOfAnInteger(int numberprovided)
        {
            
        }

        private void significantDigitsOfANumber(ref ComputationalErrorParameters value)
        {
            String[] digitsinoriginalnumber = value.OriginalNumber.ToString().Split('.');

            if (digitsinoriginalnumber.Length > 1 && System.Convert.ToInt32(digitsinoriginalnumber[0]) > 0)
            {
                this.normalizedSignificantValueWithDigitsBeforeDecimal(value.OriginalNumber, ref value);
            }
            else
            {
                this.normalizedSignificantValueWithoutDigitsBeforeDecimal(value.OriginalNumber, ref value);
            }

        }

        private StringBuilder normalizedSignificantValueWithDigitsBeforeDecimal(float value, ref ComputationalErrorParameters parameters)
        {
            String[] digitsinoriginalnumber = value.ToString().Split('.');
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

            parameters.Magnitude = parameters.Magnitude + numberofnonzerodigitsbeforedecimalpoint;
            parameters.NormalizedSignificantValue = float.Parse(normalizedsignificantvalue.ToString());

            return normalizedsignificantvalue;
        }

        private StringBuilder normalizedSignificantValueWithoutDigitsBeforeDecimal(float value, ref ComputationalErrorParameters parameters)
        {
            String[] digitsinoriginalnumber = value.ToString().Split('.');
            int numberofzerosbeforenonzerodigitafterdecimalpoint = this.numberOfDigitsAfterDecimalPoint(value);
            char[] digitsafterdecimalpoint = digitsinoriginalnumber[1].ToCharArray();
            StringBuilder normalizedsignificantvalue = new StringBuilder();
            normalizedsignificantvalue.Append('.');

            for (int iteration = (digitsafterdecimalpoint.Length - numberofzerosbeforenonzerodigitafterdecimalpoint); iteration < digitsafterdecimalpoint.Length; iteration++)
            {
                normalizedsignificantvalue.Append(digitsafterdecimalpoint[iteration]);
            }

            parameters.Magnitude = parameters.Magnitude + (digitsafterdecimalpoint.Length - numberofzerosbeforenonzerodigitafterdecimalpoint);
            parameters.NormalizedSignificantValue = float.Parse(normalizedsignificantvalue.ToString());

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

        private int numberOfDigitsPriorToDecimalPoint(float value)
        {
            int returnValue = 0;
            int numberofzerosbeforenonzerodigit = 0;

            char[] digitsbeforedecimalpoint = value.ToString().ToCharArray();
            numberofzerosbeforenonzerodigit = this.numberOfZerosBeforeNonZeroDigit(digitsbeforedecimalpoint);
            returnValue = digitsbeforedecimalpoint.Length - numberofzerosbeforenonzerodigit;

            return returnValue;
        }

        private int numberOfDigitsAfterDecimalPoint(float value)
        {
            int returnValue = 0;
            int numberofzerosbeforenonzerodigit = 0;
            String[] seperatedecimalfromdigits = value.ToString().Split('.');

            char[] digitsafterdecimalpoint = seperatedecimalfromdigits[1].ToCharArray();
            numberofzerosbeforenonzerodigit = this.numberOfZerosBeforeNonZeroDigit(digitsafterdecimalpoint);
            returnValue = digitsafterdecimalpoint.Length - numberofzerosbeforenonzerodigit;

            return returnValue;
        }

        private void significantDigitsOfAFloat()
        {
            this.comperrorparams.OriginalNumber = float.Parse(this.FloatingPointNumber.Text);
            
            ComputationalErrorParameters errorparams = new ComputationalErrorParameters();
            errorparams.OriginalNumber = float.Parse(this.FloatingPointNumber.Text);
            errorparams.Magnitude = System.Convert.ToInt32(this.PowerOfTen.Text);

            this.significantDigitsOfANumber(ref errorparams);

            if (dataGridView1.Columns.Count < 1)
            {
                this.addPrecisionMagnitudeColumnHeaders();

            }

            //object[] values = { fractionalpart, mostsiginficantdigit, precision, magnititude, aen, Math.Truncate(float.Parse(this.FloatingPointNumber.Text)) };
            object[] values = { errorparams.NormalizedSignificantValue, errorparams.MostSignificantDigit, errorparams.Precision, errorparams.Magnitude, errorparams.AEN, Math.Truncate(errorparams.OriginalNumber) };
            dataGridView1.Rows.Add(values);
            
        }

        private void addPrecisionMagnitudeColumnHeaders()
        {
            dataGridView1.Columns.Add("fractionalvalue", "Fractional value");
            dataGridView1.Columns.Add("significantdigit", "Significant digit");
            dataGridView1.Columns.Add("precisionvalue", "Precision");
            dataGridView1.Columns.Add("magnitudevalue", "Magnitude");
            dataGridView1.Columns.Add("aenvalue", "Aen");
            dataGridView1.Columns.Add("truncatedvalue", "Truncate");
        }

        private void addComputeErrorColumnHeaders()
        {
            dataGridView1.Columns.Add("originalfractionalvalue", "Fractional value");
            dataGridView1.Columns.Add("truncatedfractionalvalue", "Truncated value");
            dataGridView1.Columns.Add("absoluteerror", "Absolute Error");
        }

        private bool isNumberAnInteger()
        {
            return FloatingPointNumber.Text.Contains(".");
        }

        private void CalculatePrecision_Click_1(object sender, EventArgs e)
        {
            this.CalculatePrecision_Click(sender, e);
            this.groupBox2.Enabled = true;
        }

        private void ComputationErrorSimulator_Load(object sender, EventArgs e)
        {

        }

        private float truncatetosignificantdigits(float value, int significantdigits)
        {
            float returnValue = 0;
            char[] digitsinvalue = value.ToString().ToCharArray();
            char[] truncateddigitsvalue = new char[significantdigits + 1];

            for(int i = 0; i < significantdigits; i++)
            {
                truncateddigitsvalue[i] = digitsinvalue[i];
            }

            returnValue = float.Parse(truncateddigitsvalue.ToString());

            return returnValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = this.significantvalue;
            float xprime = 0;
            int iterations = System.Convert.ToInt32(this.NumberOfIterations.Text);
            
            this.comperrorparams.CalculatedValue = float.Parse(this.FloatingPointNumber.Text);

            for(int i = 1; i <= iterations; i++)
            {
                x = x + x;
                xprime = this.truncatetosignificantdigits(x, System.Convert.ToInt32(this.NumberOfSignificantNumbers.Text));
                MessageBox.Show(x.ToString() + ":" + xprime.ToString());
            }

        }
    }
}
