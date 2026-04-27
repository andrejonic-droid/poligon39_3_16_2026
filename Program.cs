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
            /*Tacka A = new Tacka(5, 3);
            Tacka B = new Tacka(5, 5);
            Tacka prva = new Tacka(3, 2);
            Tacka druga = new Tacka(7, 6);
            Vektor a = new Vektor(prva, druga);
            Console.WriteLine(Ravna.SIS(a, A, B));
            Console.Read();*/
            Poligon prvi = Poligon.unos();

          
            
                Vektor AB = new Vektor(prvi.teme[0], prvi.teme[1]);
                Vektor BC = new Vektor(prvi.teme[1], prvi.teme[2]);
                Vektor CD = new Vektor(prvi.teme[2], prvi.teme[3]);
                Vektor DA = new Vektor(prvi.teme[3], prvi.teme[0]);

               
                bool uslov1d = (AB.duzina() == DA.duzina()) && (BC.duzina() == CD.duzina());

             
                bool uslov2d = (AB.duzina() == BC.duzina()) && (CD.duzina() == DA.duzina());
            if (Vektor.SP(AB, BC) == 0 && Vektor.SP(BC, CD) == 0 && Vektor.SP(CD, DA) == 0 && Vektor.SP(DA, AB) == 0) { Console.WriteLine("Nije deltoid"); }
            else
            {
                if (uslov1d || uslov2d)
                {
                    Console.WriteLine("Deltoid je");
                }
                else
                {
                    Console.WriteLine("Nije deltoid");
                }
            }

            if (Vektor.SP(AB, BC) == 0 && Vektor.SP(BC, CD) == 0 && Vektor.SP(CD, DA) == 0 && Vektor.SP(DA, AB) == 0) { Console.WriteLine("Pravougaonik je"); }
            else Console.WriteLine("Nije pravougaonik");
            if ((Vektor.SP(AB, BC) == 0 && Vektor.SP(BC, CD) == 0) || (Vektor.SP(CD, DA) == 0 && Vektor.SP(DA, AB) == 0)) { Console.WriteLine("Trapez je"); }
            else Console.WriteLine("Nije trapez");


            //Console.WriteLine("konveksan={0}", prvi.konveksan());
            //Console.WriteLine("povrsina={0}", prvi.povrsina());

        }
    }
}
