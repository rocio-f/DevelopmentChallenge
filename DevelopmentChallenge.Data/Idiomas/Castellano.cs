using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Idiomas
{
    public class Castellano : IdiomaGeneral
    {
        private Dictionary<string, string> CastellanoDic = new Dictionary<string, string>
        {
            { "Hola", "Hola"},
            { "forma", "forma"},
            { "formas", "formas"},
            { "Reporte de Formas", "Reporte de Formas"},
            { "Lista vacía de formas!", "Lista vacía de formas!"},
            { "TOTAL", "TOTAL" },
            { "Perimetro", "Perimetro"},
            { "Area", "Area" },
            { "Cuadrado", "Cuadrado" },
            { "Cuadrados", "Cuadrados" },
            { "Círculo", "Círculo" },
            { "Círculos", "Círculos" },
            { "Triángulo Equilatero", "Triángulo Equilatero" },
            { "Triángulos Equilateros", "Triángulos Equilateros" },
            { "Triángulo Isosceles", "Triángulo Isosceles" },
            { "Triángulos Isosceles", "Triángulos Isosceles" },
            { "Trapecio Isosceles", "Trapecio Isosceles" },
            { "Trapecios Isosceles", "Trapecios Isosceles" },
            { "Rectángulo", "Rectángulo" },
            { "Rectángulos", "Rectángulos" },
            { "Forma desconocida", "Forma desconocida" }
        };

        public override string ObtenerString(string idioma)
        {
            return this.CastellanoDic[idioma];
        }
    }
}
