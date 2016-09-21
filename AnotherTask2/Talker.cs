using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherTask2
{
    class Talker
    {
        private string input;
        public string Input { get; set; }
        private const string Stop = "stop";
        private const string Enter = "Enter String. To quit enter stop";
        private const string NumbOfInt = "Number of Int";
        private const string NumbOfDouble = "Number of Double";
        private List<string> listString = new List<string>();
        StructString ss = new StructString();

        public void EnterStrings()
        {
            this.Input = string.Empty;
            Console.WriteLine(Enter);
            while (!this.Input.Equals(Stop))
            {
                if (!string.IsNullOrEmpty(this.Input))
                {
                    this.listString.Add(this.Input);
                }
                this.Input = Console.ReadLine();
            }
            Console.WriteLine($"{NumbOfInt} {ss.FindNumbers(this.listString)}");
            Console.WriteLine($"{NumbOfDouble} {ss.FindDouble(this.listString)}");
            ss.PrintAll();
            ss.FindStrings(listString);
            
        }




    }
}
