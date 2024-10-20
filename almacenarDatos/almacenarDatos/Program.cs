using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static almacenarDatos.almacenarDatos;

namespace almacenarDatos
{
    /*Programa que sea capaz de almacenar los datos de 10 personas: nombre, dirección,
    teléfono, edad (usando structs). Deberá ir pidiendo los datos uno por uno, hasta que
   el usuario lo decida. Entonces deberá aparecer un menú que permita:
   • Mostrar la lista de todos los nombres.
   • Mostrar las personas de una cierta edad.
   • Mostrar las personas que coincidan con un nombre. Sea el que el usuario indique.
   • Salir del programa.
   - Cada opción del menú representa una función o procedimiento que se invocará desde
   la clase principal.
   - Utilizar funciones o procedimientos con parámetros.
   */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declara un arreglo de Persona que puede almacenar hasta 10 personas.
            Persona[] personas = new Persona[10];
            // Inicializa un contador para rastrear cuántas personas han sido ingresadas.
            int contador = 0;
            //Controla el bucle que permite al usuario ingresar datos.
            bool continuar = true;
            /*Este bucle permite al usuario ingresar datos de hasta 10 personas.
             * Se ejecuta mientras el usuario desee continuar y no se haya alcanzado el límite de 10.*/
            while (continuar && contador < 10)
            {
                Console.WriteLine($"Ingrese los datos de la persona {contador + 1}:");
                personas[contador] = almacenarDatos.LeerDatosPersona();
                contador++;

                Console.Write("¿Desea agregar otra persona? (s/n): ");
                continuar = Console.ReadLine().ToLower() == "s";
                Console.Clear();
            }
            //Un bucle infinito que mostrará el menú hasta que el usuario decida salir.
            while (true)
            {
                //Llama a la función que muestra las opciones disponibles.
                almacenarDatos.MostrarMenu();
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        almacenarDatos.MostrarNombres(personas, contador);
                        break;
                    case 2:
                        Console.Write("Ingrese la edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        almacenarDatos.MostrarPersonasPorEdad(personas, contador, edad);
                        break;
                    case 3:
                        Console.Write("Ingrese el nombre a buscar: ");
                        string nombreBuscado = Console.ReadLine();
                        almacenarDatos.MostrarPersonasPorNombre(personas, contador, nombreBuscado);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}


