using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace poligon39_3_16_2026
{
    internal class Poligon
    {
        public int broj_temena;
        public Tacka[] teme;
        public Poligon(int n) 
        {
            broj_temena = n;
            teme = new Tacka[n];
        }
        public static Poligon unos()
        {
            Console.WriteLine("Koliko poligon ima temena?");
            int n = Convert.ToInt32(Console.ReadLine());
            Poligon novi = new Poligon(n);
            for (int i=0;i<n; i++)
            {
                novi.teme[i] = new Tacka();
                Console.WriteLine("A[{0}].x=", i + 1);
                novi.teme[i].x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("A[{0}].y=", i + 1);
                novi.teme[i].y= Convert.ToDouble(Console.ReadLine());
            }
            return novi;
        }
        public void stampa()
        {
            Console.WriteLine("Poligon ima {0} temena", broj_temena);
            for (int i=0; i < broj_temena; i++)
            {
                Console.WriteLine("Koordinate {0}. su x={1} i y={2}", i,teme[i].x, teme[i].x);
            }
        }
        public void snimi()
        {
            StreamWriter izlaz= new StreamWriter("poligon.txt");
            izlaz.WriteLine(broj_temena);
            for (int i = 0; i < broj_temena; i++)
            {
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);
            }
            izlaz.Close();
        }
        public static Poligon ucitaj()
        {
            return null;
        }
    }
}
