using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloIsosceles : Triangulo
    {
        public TrianguloIsosceles(decimal ladoBase, decimal ladoDerecha, decimal ladoIzquierda)
        {
            this.ladoBase = ladoBase;
            this.ladoDerecha = ladoDerecha;
            this.ladoIzquierda = ladoIzquierda;
            this.TipoForma = Enumerables.TipoFormaEnum.TrianguloIscoceles;
        }

        public override decimal GetArea()
        {
            return (0.25m) * ladoBase * (decimal)Math.Sqrt((4 * Math.Pow((double)ladoDerecha, 2)) - Math.Pow((double)ladoBase, 2));
        }

    }
}
