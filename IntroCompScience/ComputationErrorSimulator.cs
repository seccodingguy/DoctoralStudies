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

            this.comperrorparams.NormalizedSignificantValue = value.NormalizedSignificantValue;
            this.comperrorparams.Magnitude = value.Magnitude;
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
            
            this.comperrorparams.NormalizedSignificantValue = errorparams.NormalizedSignificantValue;
            this.comperrorparams.Magnitude = errorparams.Magnitude;
            
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
            dataGridView2.Columns.Add("calculatedvalue", "Calculated value");
            //dataGridView2.Columns.Add("calculatedmagnitude", "Calculated Magnitude");
            dataGridView2.Columns.Add("truncatedvalue", "Truncated value");
            dataGridView2.Columns.Add("absoluteerror", "Absolute Error");
            dataGridView2.Columns.Add("relativeerror", "Relative Error");
            dataGridView2.Columns.Add("originalvalue", "Original Value before Normalization");
        }

        private void addRoundedColumnHeaders()
        {
            dataGridView3.Columns.Add("calculatedvalue", "Calculated value");
            //dataGridView2.Columns.Add("calculatedmagnitude", "Calculated Magnitude");
            dataGridView3.Columns.Add("roundedvalue", "Rounded value");
            dataGridView3.Columns.Add("relativeerror", "Relative Error");
            dataGridView3.Columns.Add("absoluteerror", "Absolute Error");
            dataGridView3.Columns.Add("originalvalue", "Original Value before Normalization");
        }

        private void addFloatingPointLogicColumnHeaders()
        {
            dataGridView4.Columns.Add("calculatedvaluetimes7", "Calculated value (y=x*7)");
            //dataGridView2.Columns.Add("calculatedmagnitude", "Calculated Magnitude");
            dataGridView4.Columns.Add("calculatedvaluedividedby7", "Calculated value (x=y/7)");
            dataGridView4.Columns.Add("absolutedifferent", "Absolute Difference (|x - z|)");
            dataGridView4.Columns.Add("isvaluelessthanconstant", "Are x and z equal? (|x-z|<c");
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

        private float truncatetosignificantdigits(float value, int significantdigits, ref ComputationalErrorParameters currentcomperrorparams)
        {
            float returnValue = 0;
            this.significantDigitsOfANumber(ref currentcomperrorparams);
            char[] digitsinvalue = this.comperrorparams.NormalizedSignificantValue.ToString().ToCharArray();
            StringBuilder truncateddigitsvalue = new StringBuilder(".");

            for(int i = 2; i < significantdigits + 2; i++)
            {
                truncateddigitsvalue.Append(digitsinvalue[i]);
            }

            returnValue = float.Parse(truncateddigitsvalue.ToString());

            return returnValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComputationalErrorParameters calculated = new ComputationalErrorParameters();
            ComputationalErrorParameters truncated = new ComputationalErrorParameters();
            object[] gridvalues = new object[5];

            float x = this.comperrorparams.NormalizedSignificantValue;
            calculated.OriginalNumber = x;

            float absoluteerror = 0;
            int iterations = System.Convert.ToInt32(this.NumberOfIterations.Text);
            int truncate = System.Convert.ToInt32(this.NumberOfSignificantNumbers.Text);
            truncated.Magnitude = this.comperrorparams.Magnitude;
            float xtruncated = 0;
            
            if(this.dataGridView2.Columns.Count < 1)
            {
                this.addComputeErrorColumnHeaders();
            }

            if(this.dataGridView2.Rows.Count > 0)
            {
                this.dataGridView2.Rows.Clear();
            }

            for(int i = 1; i <= iterations; i++)
            {
                x = x + x;
                truncated.OriginalNumber = x;
                calculated.OriginalNumber = x;
                this.significantDigitsOfANumber(ref calculated);
                xtruncated = this.truncatetosignificantdigits(x, truncate, ref truncated);
                absoluteerror = calculated.NormalizedSignificantValue - xtruncated;

                gridvalues[0] = calculated.NormalizedSignificantValue;
                //gridvalues[1] = calculated.Magnitude;
                gridvalues[1] = xtruncated;
                gridvalues[2] = absoluteerror;
                gridvalues[3] = (absoluteerror / calculated.NormalizedSignificantValue);
                gridvalues[4] = calculated.OriginalNumber;
                dataGridView2.Rows.Add(gridvalues);
            }

        }

        
        private void RoundingError_Click(object sender, EventArgs e)
        {
            ComputationalErrorParameters xvalue = new ComputationalErrorParameters();
            ComputationalErrorParameters yvalue = new ComputationalErrorParameters();
            object[] gridvalues = new object[5];
            float absoluteerror = 0;
            float relativeerror = 0;
            float x = float.Parse(this.XValue.Text);
            float y = float.Parse(this.YValue.Text);

            if (this.dataGridView3.Columns.Count < 1)
            {
                this.addRoundedColumnHeaders();
            }

            if (this.dataGridView3.Rows.Count > 0)
            {
                this.dataGridView3.Rows.Clear();
            }

            xvalue.OriginalNumber = x;
            yvalue.OriginalNumber = y;

            this.significantDigitsOfANumber(ref xvalue);
            this.significantDigitsOfANumber(ref yvalue);
            
            for(int i = 0; i < 4; i++)
            {
                y = y + x;
                yvalue.OriginalNumber = y;
                yvalue.CalculatedValue = y;
                this.significantDigitsOfANumber(ref yvalue);

                absoluteerror = yvalue.NormalizedSignificantValue - (float)Math.Round(yvalue.NormalizedSignificantValue,4);
                relativeerror = absoluteerror / yvalue.NormalizedSignificantValue;

                gridvalues[0] = yvalue.NormalizedSignificantValue;
                //gridvalues[1] = calculated.Magnitude;
                gridvalues[1] = Math.Round(yvalue.NormalizedSignificantValue, 4);
                gridvalues[2] = absoluteerror;
                gridvalues[3] = relativeerror;
                gridvalues[4] = yvalue.CalculatedValue;
                dataGridView3.Rows.Add(gridvalues);
            }
        }

        private void FloatingPointLogic_Click(object sender, EventArgs e)
        {
            ComputationalErrorParameters yparameters = new ComputationalErrorParameters();
            ComputationalError zparameters = new ComputationalError();
            Double x = Double.Parse(this.XValue.Text);
            Double y = 0.0;
            Double z = 0.0;
            Double c = Double.Parse(this.LogicConstant.Text);
            Double difference = 0.0;
            int noofsignificantdigits = System.Convert.ToInt32(this.NumberOfSignificantNumbers.Text);
            bool isequivelant = false;

            y = x * 7.0;
            z = y/7.0;

            zparameters.OriginalNumber = z;
            zparameters.significantDigitsOfANumber();
            z = zparameters.NormalizedSignificantValue * Math.Pow(10,yparameters.Magnitude);
            z = Math.Round(z, noofsignificantdigits);

            difference = Math.Abs(x - z);

            if (difference < c)
            {
                isequivelant = true;
            }

            if(this.dataGridView4.Columns.Count < 1)
            {
                this.addFloatingPointLogicColumnHeaders();
            }

            object[] rowvalues = { y,z, difference,isequivelant};
            this.dataGridView4.Rows.Add(rowvalues);

        }


        private void copySelectedItemsToClipboard(DataGridView gridview)
        {
            if (gridview.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(
                        gridview.GetClipboardContent());
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    MessageBox.Show("The Clipboard could not be accessed. Please try again.");
                }
            }
        }

        private void CopyToClipboardGrid2_Click(object sender, EventArgs e)
        {
            this.dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            this.copySelectedItemsToClipboard(this.dataGridView2);
        }

        private void CopyToClipboardGrid4_Click(object sender, EventArgs e)
        {
            this.dataGridView4.ClipboardCopyMode =DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            this.copySelectedItemsToClipboard(this.dataGridView4);
        }
    }
}
