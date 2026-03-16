using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon39_3_16_2026
{
    class Vektor
    {
        Tacka pocetak, kraj;
        public Vektor(Tacka A, Tacka B)
        {
            pocetak = A;
            kraj = B;
        }
        public Tacka Centriraj()
        {
            Tacka Nova = new Tacka(kraj.x-pocetak.x,kraj.y-pocetak.y);
            return Nova;
        }
    }
}
