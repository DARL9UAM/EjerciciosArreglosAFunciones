using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialDeUnNumero
{
    internal class Program
    {
        /*Crea un programa que use un arreglo estático para almacenar números y una función
        que calcule el factorial de cada número, el cual es enviado a un segundo arreglo.
        Muestra los resultados, es decir ambos arreglos
        - El número es leído en la función principal Main y es enviado como parámetro a la
        función que calcula el factorial. Recuerda que el factorial no se calcula para números
        negativos. Por lo tanto, al arreglo original sólo debes guardar los números positivos
        o cero.
        - El programa se repetirá mientras el usuario lo desea.
        */
        static void Main(string[] args)
        {
            //se utiliza variable booleana que controla el bucle de repetición.
            bool continuar = true;
            //Un bucle que se ejecuta mientras continuar sea verdadero.
            while (continuar)
            {
                Console.WriteLine("Calcular el factorial de un número");
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("No se puede calcular el factorial de números negativos.");
                }
                else
                {
                    int[] arregloNumeros = new int[1] { numero };
                    int[] arregloFactoriales = Factorial.calculaFactorial(arregloNumeros);

                    //Se muestran los resultados
                    Factorial.MostrarResultado(arregloNumeros, arregloFactoriales);
                }
                Console.Write("¿Desea continuar? (s/n):");
                string respuesta = Console.ReadLine();
                continuar = respuesta.ToLower() == "s";
                Console.Clear();
                Console.ReadKey();
            }
        }
    }
}
