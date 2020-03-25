using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTipAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            PersoaneContact persoana = new PersoaneContact("Emanuel", "0743307248", "emy_baciu@yahoo.com");

            
            Console.WriteLine(persoana.Info());
            Console.WriteLine(persoana.DataNasterii = new DateTime(1999, 01, 03));

            Console.ReadKey();

            PersoaneContact p1 = new PersoaneContact("Andreea", "0756818340", "andreea@yahoo.com");

            Console.WriteLine(p1.Info());
            Console.WriteLine(p1.DataNasterii = new DateTime(1999, 07, 31));


            Console.ReadKey();
        }
    }
}
