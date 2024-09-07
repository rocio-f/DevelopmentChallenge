using DevelopmentChallenge.Data.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class Forma
    {
        public TipoFormaEnum TipoForma { get; set; }
        public abstract decimal GetArea();

        public abstract decimal GetPerimetro();

    }
}
