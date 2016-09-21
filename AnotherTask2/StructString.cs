using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    resultDoubleList.Add(resultDouble);
                    this.NumberOfDouble++;
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
        }

        public void PrintInt(List<int> list)
        {
            this.SumInt = 0;
            foreach (int output in list)
            {
                Console.WriteLine($"Number: {output}".PadLeft(15, space));
                this.SumInt = this.SumInt + output;
            }
            if (resultDoubleList.Count > 0)
            {
                Console.WriteLine($"Average: {(double)this.SumInt / (double)list.Count}".PadLeft(15, space));
            }else
            {
                Console.WriteLine($"Average: {0}".PadLeft(15, space));
            }
        }

        public void PrintDouble(List<double> list)
        {
            foreach (double outputDouble in list)
            {
                Console.WriteLine($"Double: {outputDouble:F}".PadLeft(15, space));
                this.SumDouble = this.SumDouble + outputDouble;
            }
            if (resultDoubleList.Count>0)
            {
                Console.WriteLine($"Average: {this.SumDouble / resultDoubleList.Count:F}".PadLeft(15, space));
            }else
            {
                Console.WriteLine($"Average: {0:F}".PadLeft(15, space));
            }
        }

        public void PrintStrings(List<string> list)
        {
            var sorted = this.SortByLength(list);
            foreach (string lines in sorted)
            {
                Console.WriteLine(lines);
            }
        }

        public IEnumerable<string> SortByLength(IEnumerable<string> e)
        {
            // Use LINQ to sort the array received and return a copy.
            var sorted = from s in e
                         orderby s.Length ascending
                         orderby s
                         select s;
            return sorted;
        }
    }
}
