/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Enumerables;
using DevelopmentChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        

        #region Formas

        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;
        public const int rectangulo = 5;

        #endregion

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Italiano = 3;

        #endregion

        private readonly decimal _lado;

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }

        public static string Imprimir(List<Forma> formas, int idioma)
        {
            var sb = new StringBuilder();
            var factory = new IdiomaFactory();
            var idiomaSeleccionado = factory.ObtenerIdioma((IdiomasEnum)idioma);

            if (!formas.Any())
            {
                    sb.Append("<h1>"+ idiomaSeleccionado.ObtenerString("Lista vacía de formas!") + "</h1>");
            }
            else
            {
                // Hay por lo menos una forma
               
                sb.Append("<h1>" + idiomaSeleccionado.ObtenerString("Reporte de Formas") + "</h1>");

                var resumenFactory = new ResumenFactory();

                Dictionary<TipoFormaEnum, ResumenFormas> resultado = resumenFactory.CalcularResumen(formas);

                int totalFormas = 0;
                decimal totalAreas = 0;
                decimal totalPerimetros = 0;

                foreach (var item in resultado)
                {
                    sb.Append(resumenFactory.ObtenerLinea(item.Value, item.Key, idiomaSeleccionado));
                    totalFormas += item.Value.Cantidad;
                    totalAreas += item.Value.SumaArea;
                    totalPerimetros += item.Value.SumaPerimetro;
                }

                // FOOTER
                sb.Append(idiomaSeleccionado.ObtenerString("TOTAL") + ":<br/>");
                sb.Append(totalFormas + " " + idiomaSeleccionado.ObtenerString("formas") + " ");
                sb.Append(idiomaSeleccionado.ObtenerString("Perimetro") + " " + totalPerimetros.ToString("#.##") + " ");
                sb.Append(idiomaSeleccionado.ObtenerString("Area") + " " + totalAreas.ToString("#.##"));
            }

            return sb.ToString();
        }

        public decimal CalcularArea()
        {
            switch (Tipo)
            {
                case Cuadrado: return _lado * _lado;
                case Circulo: return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
                case TrianguloEquilatero: return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }

        public decimal CalcularPerimetro()
        {
            switch (Tipo)
            {
                case Cuadrado: return _lado * 4;
                case Circulo: return (decimal)Math.PI * _lado;
                case TrianguloEquilatero: return _lado * 3;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }
    }
}
