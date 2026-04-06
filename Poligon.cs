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
            Console.WriteLine("Koliko temena?");
            int n = Convert.ToInt32(Console.ReadLine());
            Poligon novi = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                novi.teme[i] = new Tacka();
                Console.WriteLine("T[{0}].x =", i + 1);
                novi.teme[i].x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("T[{0}].y=", i + 1);
                novi.teme[i].y = Convert.ToDouble(Console.ReadLine());
            }
            return novi;
        }
        public void stampa()
        {
            Console.WriteLine("Poligon ima {0} temena", broj_temena);
            for (int i=0; i < broj_temena; i++)
            {
                Console.WriteLine("Koordinate {0}. tacke su x={1} i y={2}", i+1,teme[i].x, teme[i].y);
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

            StreamReader ulaz = new StreamReader("poligon.txt");
            int n = Convert.ToInt32(ulaz.ReadLine());
            Poligon novi = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                novi.teme[i] = new Tacka();
                novi.teme[i].x = Convert.ToDouble(ulaz.ReadLine());
                novi.teme[i].y = Convert.ToDouble(ulaz.ReadLine());
            }
                return novi;
        }
        public  double Obim()
        {
             Vektor a;
            double obim = 0;
            for (int i = 0; i < broj_temena-1; i++)
            {
                a = new Vektor(teme[i], teme[i + 1]);
                obim += a.duzina();
            }
            a = new Vektor(teme[broj_temena-1], teme[0]);
            obim += a.duzina();
            return obim;
        }
        public bool prost()
        {
            for (int i = 0; i < broj_temena - 1; i++)
            {
                for (int j = i + 1; j < broj_temena; j++)
                {
                    if (Tacka.jednake(teme[i], teme[j]))
                    {
                        return false;
                    }
                }
            }
            Vektor[] stranica = new Vektor[broj_temena];
            for (int i = 0; i < broj_temena - 1; i++)
            {
                stranica[i] = new Vektor(teme[i], teme[i + 1]);
            }
            stranica[broj_temena - 1] = new Vektor(teme[broj_temena - 1], teme[0]);
            for (int i = 0; i < broj_temena; i++)
            {
                int kraj;
                if (i == 0) kraj = broj_temena - 1;
                else kraj = broj_temena;
                for (int j = i + 2; j < kraj; j++)
                {
                    if (Vektor.seku_se(stranica[i], stranica[j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool konveksan()
        {
            int brojac = 0;
            for (int i = 0; i < broj_temena; i++)
            {
                Vektor prvi = new Vektor(teme[i], teme[(i + 1) % broj_temena]);
                Vektor drugi = new Vektor(teme[(i + 1) % broj_temena], teme[(i + 2) % broj_temena]);
                if (Vektor.VP(prvi, drugi) > 0) brojac++;
            }
            if ((brojac == broj_temena) || (brojac == 0)) return true;
            return false;
        }
        public double povrsina()
        {
            double plus = 0, minus = 0;
            for (int i = 0; i < broj_temena; i++)
            {
                plus += teme[i].x * teme[(i + 1) % broj_temena].y;
                minus += teme[i].y * teme[(i + 1) % broj_temena].x;
            }
            return Math.Abs((plus-minus)/2);
        }
        public bool tacka_u(Tacka T)
        { 
            Tacka O = new Tacka(max.x, T.y);
            return false;
        }
    }
}
