using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minnutes_to_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many seconds do you want to convert?");
            string input = Console.ReadLine();
            int totalSeconds = Convert.ToInt32(input);
            int minutes;
            int seconds;

            minutes = totalSeconds / 60;
            seconds = totalSeconds % 60;
            Console.WriteLine("{0} seconds is equal to {1} minutes and {2}seconds", totalSeconds, minutes, seconds);
            
        }
    }
}
