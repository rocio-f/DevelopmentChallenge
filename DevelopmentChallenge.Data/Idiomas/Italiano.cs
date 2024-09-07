using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Idiomas
{
    public class Italiano : IdiomaGeneral
    {
        private Dictionary<string, string> ItalianoDic = new Dictionary<string, string>
        {
            { "Hola", "Ciao"},
            { "forma", "forma"},
            { "formas", "forme"},
            { "Reporte de Formas", "Rapporto sui moduli"},
            { "Lista vacía de formas!", "Elenco vuoto di forme!"},
            { "TOTAL", "TOTALE" },
            { "Perimetro", "Perimetro"},
            { "Area", "Zona" },
            { "Cuadrado", "Piazza" },
            { "Cuadrados", "Piazze" },
            { "Círculo", "Cerchio" },
            { "Círculos", "Cerchi" },
            { "Triángulo Equilatero", "Triangolo equilatero" },
            { "Triángulos Equilateros", "Triangoli equilateri" },
            { "Triángulo Isosceles", "Triangoli equilateri" },
            { "Triángulos Isosceles", "Triangoli isosceli" },
            { "Trapecio Isosceles", "Trapezio isoscele" },
            { "Trapecios Isosceles", "Trapezi isosceli" },
            { "Rectángulo", "Rettangolo" },
            { "Rectángulos", "Rettangoli" },
            { "Forma desconocida", "Forma sconosciuta" }
        };

        public override string ObtenerString(string idioma)
        {
            return this.ItalianoDic[idioma];
        }
    }
}
