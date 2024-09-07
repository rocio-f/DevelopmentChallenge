using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : Cuadrado
    {
        public Rectangulo(decimal ladoSuperior, decimal ladoDerecha, decimal ladoInferior, decimal ladoIzquierda) 
            : base(ladoSuperior, ladoDerecha, ladoInferior, ladoIzquierda)
        {
            this.TipoForma = Enumerables.TipoFormaEnum.Rectangulo;
        }

        public override decimal GetArea()
        {
            return (ladoSuperior * ladoDerecha );
        }

    }
}
