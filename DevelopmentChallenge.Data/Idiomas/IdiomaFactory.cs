using DevelopmentChallenge.Data.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Idiomas
{
    public class IdiomaFactory
    {
        private Dictionary<IdiomasEnum, IdiomaGeneral> dictGegneral = new Dictionary<IdiomasEnum, IdiomaGeneral>()
        {
            { IdiomasEnum.Castellano, new Castellano()},
            { IdiomasEnum.Ingles, new Ingles()},
            { IdiomasEnum.Italiano, new Italiano()}
        }
        ;

        public IdiomaGeneral ObtenerIdioma(IdiomasEnum idioma)
        {
            
            return this.dictGegneral[idioma];
        }
    }
}
