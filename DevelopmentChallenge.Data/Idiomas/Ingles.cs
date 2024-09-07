using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Idiomas
{
    public class Ingles :IdiomaGeneral
    {
        private Dictionary<string, string> InglesDic = new Dictionary<string, string>
        {
            { "Hola", "Hello"},
            { "forma", "shape"},
            { "formas", "shapes"},
            { "Reporte de Formas", "Shapes report"},
            { "Lista vacía de formas!", "Empty list of shapes!"},
            { "TOTAL", "TOTAL" },
            { "Perimetro", "Perimeter"},
            { "Area", "Area" },
            { "Cuadrado", "Square" },
            { "Cuadrados", "Squares" },
            { "Círculo", "Circle" },
            { "Círculos", "Circles" },
            { "Triángulo Equilatero", "Equilateral Triangle" },
            { "Triángulos Equilateros", "Equilateral Triangles" },
            { "Triángulo Isosceles", "Isosceles Triangle" },
            { "Triángulos Isosceles", "Isosceles Triangles" },
            { "Trapecio Isosceles", "Isosceles trapezoid" },
            { "Trapecios Isosceles", "Isosceles trapezoids" },
            { "Rectángulo", "Rectangle" },
            { "Rectángulos", "Rectangles" },
            { "Forma desconocida", "Unknown form" }
        };

        public override string ObtenerString(string idioma)
        {
            return this.InglesDic[idioma];
        }
    }
}
