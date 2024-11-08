using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulation
{

    public class Kniha
    {

        private string nazov;
        private int pocetStran;


        public Kniha(string nazov, int pocetStran)
        {
            this.nazov = nazov;
            this.pocetStran = pocetStran;
        }

        public string Nazov
        {
            get { return nazov; }
            set { nazov = value; }
        }

        public int PocetStran
        {
            get { return pocetStran; }
            set { pocetStran = value; }
        }
    }

    //public class Program
    //{
    //    public static void Main()
    //    {
    //        Kniha kniha1 = new Kniha("Harry Potter", 500);

    //        kniha1.Nazov = "Harry Potter a Kameň mudrcov";
    //        kniha1.PocetStran = 320;

    //        Console.WriteLine("Názov knihy: " + kniha1.Nazov);  // "Harry Potter a Kameň mudrcov"
    //        Console.WriteLine("Počet strán: " + kniha1.PocetStran);  // 320
    //    }
    //}
}
