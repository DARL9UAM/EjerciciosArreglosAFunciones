using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    internal class Calculodearea
    {
        public static double calcular_area_triangulo(double[] areas)

        {
            double basetriangulo = 0;
            double altura = 0;

            foreach(double area in areas)
            {
              basetriangulo += area;
               altura += area;
            }
            return basetriangulo * altura / 2;
        }

        public static void imprimir_area(double areatriangulo)
        {
            Console.WriteLine($"El ara del triángulo es: {areatriangulo}");
        }
    }
}
