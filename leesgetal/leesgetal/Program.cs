using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leesgetal
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            Auto Auto = new Auto();
            Console.WriteLine(Auto.Kleur("geel"));
            Auto.rij(4);
            
        }
    }
}
