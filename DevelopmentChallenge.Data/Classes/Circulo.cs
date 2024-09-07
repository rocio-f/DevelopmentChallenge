using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : Forma
    {
        public Circulo(decimal radio)
        {
            this.radio = radio;
            this.TipoForma = Enumerables.TipoFormaEnum.Circulo;
        }

        public decimal radio { get; set; }

        public override decimal GetArea()
        {
            return (decimal)(Math.PI * Math.Pow((double)radio, 2));
        }

        public override decimal GetPerimetro()
        {

            return (decimal)Math.PI * radio * 2;
        }
    }
}
