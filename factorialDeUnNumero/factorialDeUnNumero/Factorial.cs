using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialDeUnNumero
{
    internal class Factorial
    {
        //Funcion para calcular el factorial de un número
        public static int[] calculaFactorial(int[] arregloNumeros)
        {
            int[] arregloFactoriales = new int[arregloNumeros.Length];

            //Itera sobre cada número en el arreglo.
            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                // Inicializa una variable para calcular el factorial.
                int factorial = 1;
                for (int j = 1; j <= arregloNumeros[i]; j++)
                {
                    factorial *= j;
                }
                arregloFactoriales[i] = factorial;
            }
            return arregloFactoriales;
        }
         //Funcion para mostrar el resultado
         public static void MostrarResultado(int[] arregloNumeros, int[] arregloFactoriales)
         {
            //Se utiliza un bucle foreach para imprimir los elementos de arregloNumeros y arregloFactoriales
            Console.WriteLine("Arreglo de números:");
            foreach (var num in arregloNumeros)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Arreglo de factoriales:");
            foreach (var factorial in arregloFactoriales)
            {
                Console.Write(factorial + " ");
            }
            Console.WriteLine();
        }
        
    }
}
