using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumq
{
    class Program
    {
        enum eten
        {
           lasagne, frieten, hamburger
        };
        static void Main(string[] args)
        {
            int a = (int)eten.frieten;
            Console.WriteLine("vandaag eten we " + a);
            
        }
    }
}
