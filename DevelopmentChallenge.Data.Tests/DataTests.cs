using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<Forma>(), 1));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<Forma>(), 2));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometrica.Imprimir(new List<Forma>(), 3));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<Forma> {new Cuadrado(5)};

            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var rectangulo = new List<Forma> { new Rectangulo(5, 2, 5, 2) };

            var resumen = FormaGeometrica.Imprimir(rectangulo, FormaGeometrica.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 10 | Perimetro 14 <br/>TOTAL:<br/>1 formas Perimetro 14 Area 10", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioIsosceles()
        {
            var trapecioIsosceles = new List<Forma> { new TrapecioIsosceles(3, 4, 5, 4) };

            var resumen = FormaGeometrica.Imprimir(trapecioIsosceles, FormaGeometrica.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio Isosceles | Area 15,49 | Perimetro 16 <br/>TOTAL:<br/>1 formas Perimetro 16 Area 15,49", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCirculo()
        {
            var circulos = new List<Forma> { new Circulo(4) };

            var resumen = FormaGeometrica.Imprimir(circulos, FormaGeometrica.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Círculo | Area 50,27 | Perimetro 25,13 <br/>TOTAL:<br/>1 formas Perimetro 25,13 Area 50,27", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrianguloEquilatero()
        {
            var circulos = new List<Forma> { new TrianguloEquilatero(8) };

            var resumen = FormaGeometrica.Imprimir(circulos, FormaGeometrica.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo Equilatero | Area 27,71 | Perimetro 24 <br/>TOTAL:<br/>1 formas Perimetro 24 Area 27,71", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrianguloIsosceles()
        {
            var circulos = new List<Forma> { new TrianguloIsosceles(6, 8, 8) };

            var resumen = FormaGeometrica.Imprimir(circulos, FormaGeometrica.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo Isosceles | Area 22,25 | Perimetro 22 <br/>TOTAL:<br/>1 formas Perimetro 22 Area 22,25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<Forma>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<Forma>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 52,03 | Perimeter 36,13 <br/>3 Equilateral Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 115,73 Area 130,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<Forma>
            {
               new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 52,03 | Perimetro 36,13 <br/>3 Triángulos Equilateros | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 115,73 Area 130,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<Forma>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Rectangulo(2, 4, 2, 4),
                new TrapecioIsosceles(5, 4, 9, 4)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto sui moduli</h1>2 Piazze | Zona 29 | Perimetro 28 <br/>1 Rettangolo | Zona 8 | Perimetro 12 <br/>1 Trapezio isoscele | Zona 24,25 | Perimetro 22 <br/>2 Cerchi | Zona 52,03 | Perimetro 36,13 <br/>3 Triangoli equilateri | Zona 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>9 forme Perimetro 149,73 Zona 162,92",
                resumen);
        }
    }
}
