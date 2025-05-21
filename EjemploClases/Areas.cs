using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClases
{
    public class Areas
    {
        //muchos métodos
        public double AreaCuadrado(double l)
        {
            double a;
            a = l * l;

            return a;
        }

        public double Areatriangulo(double h, double b)
        {
            double a = (b * h) / 2;
            return a;
        }

        public double Arearectangulo(double h, double b)
        {
            return b * h;
        }

        public double AreaCirculo(double r)
        {
            double a = Math.PI * (r * r);

            return a;
        }
    }
}
