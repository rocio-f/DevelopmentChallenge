using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrapecioIsosceles : Cuadrado
    {
        public TrapecioIsosceles(decimal ladoSuperior, decimal ladoDerecha, decimal ladoInferior, decimal ladoIzquierda) 
            : base(ladoSuperior, ladoDerecha, ladoInferior, ladoIzquierda)
        {
            this.TipoForma = Enumerables.TipoFormaEnum.TrapecioIscoceles;
        }

        public override decimal GetArea()
        {
            decimal s = (ladoInferior + ladoSuperior + (2 * ladoDerecha))/2;

            return (decimal)Math.Sqrt((double)(s - ladoSuperior) * (double)(s - ladoInferior) * Math.Pow((double)(s-ladoDerecha),2));
        }

    }
}
