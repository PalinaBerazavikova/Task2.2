using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listString = new List<string>();
            List<string> newListString = new List<string>();
            List<string> newListString1 = new List<string>();
            int resultInt;
            double resultDouble;
            List<double> resultDoubleList = new List<double>();
            List<int> resultIntList = new List<int>();
            int numberOfInt = 0;
            int numberOfDouble = 0;
            string input = string.Empty;
            while (!input.Equals("stop"))
            {
                if (!string.IsNullOrEmpty(input))
                {
                    listString.Add(input);
                }
                input = Console.ReadLine();
            }

            foreach(string str in listString)
            {
                if (Int32.TryParse(str, out resultInt))
                {
                    resultIntList.Add(resultInt);
                    numberOfInt++;
                }
            }


            Console.WriteLine($"Number of Int {numberOfInt}");

            foreach (string str in listString)
            {
                if (Double.TryParse(str, out resultDouble))
                {
                    if (resultDouble % 1 > 0)
                    {
                        resultDoubleList.Add(resultDouble);
                        numberOfDouble++;   
                    }
                }
            }
            Console.WriteLine($"Number of Double {numberOfDouble}");

            int sumInt = 0;
            foreach (int outputInt in resultIntList)
            {
                Console.WriteLine($"Number: {outputInt}".PadLeft(15, ' '));
                sumInt = sumInt + outputInt;
            }
            Console.WriteLine($"Average: {(double)sumInt/(double)resultIntList.Count}".PadLeft(15, ' '));

            double sumDouble = 0;
            foreach (double outputDouble in resultDoubleList)
            {
                Console.WriteLine($"Double: {outputDouble:#.##}".PadLeft(15, ' '));
                sumDouble = sumDouble + outputDouble;
            }
            Console.WriteLine($"Average: {sumDouble / resultDoubleList.Count:#.##}".PadLeft(15, ' '));
            foreach (string str in listString)
            {
                if ((!Double.TryParse(str, out resultDouble)) &&(!Int32.TryParse(str, out resultInt)))
                {
                    newListString.Add(str);
                }
            }
            IEnumerable<string> newList = null;
            newList = newListString.OrderBy(x => x.Length).ThenByDescending(x => x);

            foreach (string lines in newList)
            {
                Console.WriteLine(lines);
            }
        }

    }
}
