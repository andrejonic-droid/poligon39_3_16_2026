using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon39_3_16_2026
{
    class Tacka
    {
        public double x, y;
        public Tacka()
        {
            x = 0;
            y = 0;
        }
        public Tacka(double a, double b)
        {
            x = a;
            y = b;
        }
        public double d()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
