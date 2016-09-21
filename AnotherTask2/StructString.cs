using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherTask2
{
    class StructString
    {
        List<string> newListString = new List<string>();
        List<int> resultIntList = new List<int>();
        List<double> resultDoubleList = new List<double>();
        public int NumberOfInt { get; set; }
        private int numberOfInt;
        public int SumInt{ get; set; }
        private int sumInt;
        public double SumDouble { get; set; }
        private double sumDouble;
        public int NumberOfDouble { get; set; }
        private int numberOfDouble;
        private const char space = ' ';

        public int FindNumbers(List<string> list)
        {
            int resultInt;
            this.NumberOfInt = 0;
            foreach (string str in list)
            {
                if (Int32.TryParse(str, out resultInt))
                {
                    this.resultIntList.Add(resultInt);
                    this.NumberOfInt++;
                }
            }
            return NumberOfInt;
        }

        public int FindDouble(List<string> list)
        {
            double resultDouble;
            this.NumberOfDouble = 0;
            foreach (string str in list)
            {
                if (Double.TryParse(str, out resultDouble))
                {
                    if (resultDouble % 1 > 0)
                    {
                        resultDoubleList.Add(resultDouble);
                        this.NumberOfDouble++;
                    }
                }
            }
            return this.NumberOfDouble;
        }

        public void FindStrings(List<string> list)
        {
            foreach (string str in list)
            {
                double resultDouble;
                int resultInt;
                if ((!Double.TryParse(str, out resultDouble)) && (!Int32.TryParse(str, out resultInt)))
                {
                    this.newListString.Add(str);
                }
            }
            this.PrintStrings(newListString);
        }

        public void PrintAll()
        {
            this.PrintInt(resultIntList);
            this.PrintDouble(resultDoubleList);
            
            this.PrintStrings(this.newListString);
        }

        public void PrintInt(List<int> list)
        {
            this.SumInt = 0;
            foreach (int output in list)
            {
                Console.WriteLine($"Number: {output}".PadLeft(15, space));
                this.SumInt = this.SumInt + output;
            }
            Console.WriteLine($"Average: {(double)this.SumInt / (double)list.Count}".PadLeft(15, space));
        }

        public void PrintDouble(List<double> list)
        {
            foreach (double outputDouble in list)
            {
                Console.WriteLine($"Double: {outputDouble:#.##}".PadLeft(15, space));
                this.SumDouble = this.SumDouble + outputDouble;
            }
            Console.WriteLine($"Average: {this.SumDouble / resultDoubleList.Count:#.##}".PadLeft(15, space));
        }

        public void PrintStrings(List<string> list)
        {
            list.Sort();
            foreach (string lines in list)
            {
                Console.WriteLine(lines);
            }
        }
    }
}
