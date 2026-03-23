using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon39_3_16_2026
{
    class Program
    {
        static void Main(string[] args)
        {
            //Andrej Onic
            /* Tacka prva = new Tacka();
             Console.WriteLine(prva.d());
             Tacka A = new Tacka(1, 2);
             Tacka B = new Tacka(2, 3);
             Vektor AB = new Vektor(A, B);
             Tacka C = AB.Centriraj();
             Console.WriteLine(C.d());
            */
            /*Tacka A = new Tacka(3, 2);
            Tacka B = new Tacka(-2, 3);
            Tacka O = new Tacka();
            Vektor OA = new Vektor(O, A);
            Vektor OB = new Vektor(O, B);
            Console.WriteLine(Vektor.SP(OA, OB));
            Console.WriteLine(Vektor.VP(OA, OB));
            Console.ReadLine();*/
            Tacka A = new Tacka(5, 3);
            Tacka B = new Tacka(5, 5);
            Tacka prva = new Tacka(3, 2);
            Tacka druga = new Tacka(7, 6);
            Vektor a = new Vektor(prva, druga);
            Console.WriteLine(Ravna.SIS(a, A, B));
            Console.Read();

        }
    }
}
