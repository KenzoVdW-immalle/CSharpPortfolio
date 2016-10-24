using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sliders_enzo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press esc to escape or a to write ");
            
            
            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Write(" \n >>>");
                if (Console.ReadKey().Key == ConsoleKey.A)
            {
                Console.WriteLine(" \n you pressed a!");
            }
            }
            
            
        }
    }
}
