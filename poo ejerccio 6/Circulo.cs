using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_6
{
    class Circulo : Forma
    {
        double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public double Radio { get => radio; set => radio = value; }
    }
}
