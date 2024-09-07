using DevelopmentChallenge.Data.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class ResumenFormas
    {
        public TipoFormaEnum TipoForma { get; set; }
        public int Cantidad { get; set; }
        public decimal SumaPerimetro { get; set; }
        public decimal SumaArea { get; set; }
    }
}
