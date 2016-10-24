using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leesgetal
{
    public class Auto
    {
        private string kleur;
        public int snelheid = 50;

        public void auto(string kleur)
        {
            kleur = "rood";
        }
        public string Kleur(string kleur)
        {
            return "de kleur van de auto is " + kleur;
        }
        public void rij(int snelheid)
        {
            Console.WriteLine("de auto rijd "+ snelheid + "km/h");
        }

    }
}
