using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloEnteros
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Imprime un mensaje pidiendo al usuario que ingrese los datos del arreglo
            Console.WriteLine("Ingrese los elementos del arreglo separados por espacios:");

            //lectura de la variable y la almacena
            string input = Console.ReadLine();

            //Convierte la cadena de entrada en un arreglo de enteros
            int[] array = input.Split(' ').Select(int.Parse).ToArray();

            //Imprime el arreglo original
            Console.WriteLine("Arreglo original:");
            //llama al metodo imprimir arreglo y le pasa el arreglo original
            InvertirYcontar.ImprimirArreglo(array);

            //llama al metodo invertirarreglo de la clase invertir y contar para invertir el arreglo original y lo almacena
            //en el array invertido
            int[] arrayInvertido = InvertirYcontar.InvertirArreglo(array);

            //se muestra el arreglo invertido gracias al metodo imprimir arreglo establecido en la clase invertir y contar
            Console.WriteLine("Arreglo invertido:");
            InvertirYcontar.ImprimirArreglo(arrayInvertido);

            //Llama al método ContarImpares de la clase InvertirYcontar para contar
            // los números impares en el arreglo invertido y almacena el resultado en la variable impares.
            int impares = InvertirYcontar.ContarImpares(arrayInvertido);
            Console.WriteLine($"Cantidad de valores impares en el arreglo invertido: {impares}");

            Console.ReadKey();
        }
    }
}