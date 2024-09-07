using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : Triangulo
    {
        public TrianguloEquilatero(decimal ladoBase, decimal ladoDerecha, decimal ladoIzquierda)
        {
            this.ladoBase = ladoBase;
            this.ladoDerecha = ladoDerecha;
            this.ladoIzquierda = ladoIzquierda;
            this.TipoForma = Enumerables.TipoFormaEnum.TrianguloEquilatero;
        }
        public TrianguloEquilatero(decimal ladoBase) : this(ladoBase, ladoBase, ladoBase)
        {
          
        }

        public override decimal GetArea() 
        {
            return ((decimal)Math.Sqrt(3) / 4) * ladoBase * ladoBase;
        }
        
    }
}
