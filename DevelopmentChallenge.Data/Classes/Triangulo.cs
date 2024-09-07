using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class Triangulo : Forma
    {
        public decimal ladoBase { get; set; }
        public decimal ladoDerecha { get; set; }
        public decimal ladoIzquierda { get; set; }

        public override decimal GetPerimetro()
        {
            return ladoBase + ladoDerecha + ladoIzquierda;
        }
    }
}
