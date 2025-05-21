using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClases
{
   public class Perimetros
    {
        public void PerimetroCirculo(double r, ref double p)
        //{
        //    double a = 2 * (Math.PI * r);
        //    return a;
        //}
        {
            p = 2 * Math.PI * r;
        }

        public void PerimetroRectangulo(double b, double h, ref double p)
        {
            p = 2 * (b + h);
        }
    }
}
