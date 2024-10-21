using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            double area;
           
            Console.WriteLine("Programa para calcular área de triángulo utilizando métodos\n");
            
            Console.WriteLine("Ingrese la base del triángulo: ");
            double basetriangulo=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triángulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            area = Calculodearea.calcular_area_triangulo(areas);
            Calculodearea.imprimir_area(area);
            Console.ReadKey();
        }
            
    }
}
