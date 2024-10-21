using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloEnteros

{
        //definicion de la clase interna
        internal class InvertirYcontar
        {
        //recibe un arreglo de enteros y lo devuelve invertido
        public static int[] InvertirArreglo(int[] array)
            {
                int[] invertido = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    invertido[i] = array[array.Length - 1 - i]; //asignacion de la posicion
                }
                return invertido;  //devuelve el arreglo invertido
        }

            public static void ImprimirArreglo(int[] array)
        {
                foreach (int num in array) //Inicia un bucle foreach que itera sobre cada elemento num en el arreglo array.
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            public static int ContarImpares(int[] array)
            {
                int contador = 0;
                foreach (int num in array)
                {
                    if (num % 2 != 0) //comprabacion si es impar
                    {
                        contador++; //incremento del contador si es impar
                }
                }
                return contador; //devuelve el contador
            }
}
    }

