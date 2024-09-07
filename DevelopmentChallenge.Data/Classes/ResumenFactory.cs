using DevelopmentChallenge.Data.Enumerables;
using DevelopmentChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class ResumenFactory
    {
        private Dictionary<TipoFormaEnum, ResumenFormas> resumenGegneral = new Dictionary<TipoFormaEnum, ResumenFormas>()
        {
            { TipoFormaEnum.Cuadrado, new ResumenFormas()},
            { TipoFormaEnum.Rectangulo, new ResumenFormas()},
            { TipoFormaEnum.TrapecioIscoceles, new ResumenFormas()},
            { TipoFormaEnum.Circulo, new ResumenFormas()},
            { TipoFormaEnum.TrianguloEquilatero, new ResumenFormas()},
            { TipoFormaEnum.TrianguloIscoceles, new ResumenFormas()}
        };

        public Dictionary<TipoFormaEnum, ResumenFormas> CalcularResumen(List<Forma> formas)
        {
            foreach (var forma in formas)
            {
                var resumen = this.resumenGegneral[forma.TipoForma];
                resumen.Cantidad++;
                resumen.SumaArea += forma.GetArea();
                resumen.SumaPerimetro += forma.GetPerimetro();
            }
            
            return resumenGegneral;
        }

        public string ObtenerLinea(ResumenFormas resumenFormas, TipoFormaEnum tipo, IdiomaGeneral idioma)
        {
            if (resumenFormas.Cantidad > 0)
            {
                
                return $"{resumenFormas.Cantidad} {TraducirForma(tipo, resumenFormas.Cantidad, idioma)} | " 
                    + idioma.ObtenerString("Area") + $" {resumenFormas.SumaArea:#.##} | " 
                    + idioma.ObtenerString("Perimetro")
                    + $" {resumenFormas.SumaPerimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        private static string TraducirForma(TipoFormaEnum tipo, int cantidad, IdiomaGeneral idioma)
        {
            switch (tipo)
            {
                case TipoFormaEnum.Cuadrado:
                    return cantidad == 1 ? idioma.ObtenerString("Cuadrado") : idioma.ObtenerString("Cuadrados");
                    
                case TipoFormaEnum.Rectangulo:
                    return cantidad == 1 ? idioma.ObtenerString("Rectángulo") : idioma.ObtenerString("Rectángulos");

                case TipoFormaEnum.TrapecioIscoceles:
                   return cantidad == 1 ? idioma.ObtenerString("Trapecio Isosceles") : idioma.ObtenerString("Trapecios Isosceles");

                case TipoFormaEnum.Circulo:
                    return cantidad == 1 ? idioma.ObtenerString("Círculo") : idioma.ObtenerString("Círculos");

                case TipoFormaEnum.TrianguloEquilatero:
                    return cantidad == 1 ? idioma.ObtenerString("Triángulo Equilatero") : idioma.ObtenerString("Triángulos Equilateros");

                case TipoFormaEnum.TrianguloIscoceles:
                    return cantidad == 1 ? idioma.ObtenerString("Triángulo Isosceles") : idioma.ObtenerString("Triángulos Isosceles");
            }

            return string.Empty;
        }
    }
}
