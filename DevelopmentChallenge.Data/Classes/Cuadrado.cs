using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : Forma
    {
        public Cuadrado(decimal ladoSuperior, decimal ladoDerecha, decimal ladoInferior, decimal ladoIzquierda)
        {
            this.ladoSuperior = ladoSuperior;
            this.ladoDerecha = ladoDerecha;
            this.ladoInferior = ladoInferior;
            this.ladoIzquierda = ladoIzquierda;
            this.TipoForma = Enumerables.TipoFormaEnum.Cuadrado;
        }
        public Cuadrado(decimal ladoSuperior) : this(ladoSuperior, ladoSuperior, ladoSuperior, ladoSuperior)
        {
            
        }
        public decimal ladoSuperior { get; set; }

        public decimal ladoDerecha { get; set; }

        public decimal ladoInferior { get; set; }

        public decimal ladoIzquierda { get; set; }

        public override decimal GetArea()
        {
            return ladoSuperior * ladoSuperior;
        }

        public override decimal GetPerimetro()
        {

            return ladoSuperior + ladoDerecha + ladoInferior + ladoIzquierda;
        }
    }
}
