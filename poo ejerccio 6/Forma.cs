using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ejerccio_6
{
    class Forma
    {
        private Ubicacion u = new Ubicacion();
        public double area;
        public double Peri;

        public Forma()
        {

        }
        public Forma(Ubicacion u, double area, double peri)
        {
            this.u = u;
            this.area = area;
            Peri = peri;
        }

        public double Area { get => area; set => area = value; }
        public double Peri1 { get => Peri; set => Peri = value; }
        protected Ubicacion U { get => u; set => u = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
