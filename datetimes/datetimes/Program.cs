using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetimes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            printTimetogether();
            printrandom();

        }
        static void printTimetogether()
        {

            DateTime school = new DateTime(201, 09, 01, 0,0,0);
            DateTime now = DateTime.Now;
            Convert.ToDateTime(now);
            Convert.ToDateTime(school);
            TimeSpan tijd = now - school;
            Console.WriteLine("school is vandaag {0} bezig ", tijd);
        }
        static void printrandom()
        {
            Random EenRandom = new Random();
            Console.WriteLine("een random getal---  {0}",EenRandom.Next(0, 100));
        }
        
    }
}
