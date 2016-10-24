using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningen_met_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liststrings = new list<string>();
            liststrings.Add("a new object");
            liststrings.Add("another object");
            liststrings.Add("a third one");
            foreach (var liststring in liststrings)
            {
                Console.WriteLine(liststring);
            }
        }
    }
}
