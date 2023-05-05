using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_6
{
    class Rectangulo : Forma
    {
        double Lado1;
        double Lado2;

        public Rectangulo(double lado1, double lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public double Lado11 { get => Lado1; set => Lado1 = value; }
        public double Lado21 { get => Lado2; set => Lado2 = value; }


    }
}
