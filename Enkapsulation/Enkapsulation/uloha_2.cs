using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulation
{
    using System;

    public class Tim
    {
        private string nazov;

        private static int pocetTimov = 0;

        public Tim(string nazov)
        {
            this.nazov = nazov;
            pocetTimov++; 
        }

        public static int ZiskajPocetTimov()
        {
            return pocetTimov;
        }

        public string ZiskajNazov()
        {
            return nazov;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Tim tim1 = new Tim("Draci");
            Tim tim2 = new Tim("Sokoli");
            Tim tim3 = new Tim("Orli");

            Console.WriteLine("Celkový počet tímov: " + Tim.ZiskajPocetTimov()); // 3
        }
    }

}
