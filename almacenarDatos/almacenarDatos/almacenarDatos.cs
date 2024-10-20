using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static almacenarDatos.Program;

namespace almacenarDatos
{
    internal class almacenarDatos
    {
        //Contiene los atributos que se almacenarán para cada persona.
        public struct Persona
        {
            public string nombre;
            public string direccion;
            public int telefono;
            public int edad;
        }
        //funcion para que el usuario pueda ingresar los datos de las personas
        public static Persona LeerDatosPersona()
        {
            Persona persona = new Persona();
            Console.Write("Nombre: ");
            persona.nombre = Console.ReadLine();
            Console.Write("Dirección: ");
            persona.direccion = Console.ReadLine();
            Console.Write("Teléfono: ");
            persona.telefono = int.Parse(Console.ReadLine());
            Console.Write("Edad: ");
            persona.edad = int.Parse(Console.ReadLine());
            return persona;
        }
        //funcion para poder mostrar el menu de opciones al usuario
        public static void MostrarMenu()
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Mostrar la lista de todos los nombres.");
            Console.WriteLine("2. Mostrar las personas de una cierta edad.");
            Console.WriteLine("3. Mostrar las personas que coincidan con un nombre.");
            Console.WriteLine("4. Salir.");
            Console.Write("Seleccione una opción: ");
        }
        //funcion para poder mostrar todos los nombres de las personas que se han ingresado
        public static void MostrarNombres(Persona[] personas, int contador)
        {
            Console.WriteLine("\nLista de nombres");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(personas[i].nombre);
            }
        }
        //funcion para mostrar una persona o personas con respecto a su edad
        public static void MostrarPersonasPorEdad(Persona[] personas, int contador, int edad)
        {
            Console.WriteLine($"\nPersonas de {edad} años:");
            bool encontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (personas[i].edad == edad)
                {
                    Console.WriteLine($"Nombre: {personas[i].nombre}, Dirección: {personas[i].direccion}, Teléfono: {personas[i].telefono}");
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("No se encontraron personas de esa edad.");
            }
        }
        //funcion para mostrar personas que tengan nombres iguales o similares
        public static void MostrarPersonasPorNombre(Persona[] personas, int contador, string nombre)
        {
            Console.WriteLine($"\nPersonas con el nombre '{nombre}':");
            bool encontrado = false;
            for (int i = 0; i < contador; i++)
            {
                /*Equals, Es un método que se utiliza para comparar dos cadenas de texto (strings).
                 *En este caso, se está comparando el nombre de la persona con el valor de nombre que se ha proporcionado como argumento.*/

                /*StringComparison.OrdinalIgnoreCase: Este es un enumerador que especifica cómo se debe realizar la comparación. En este caso,
                 *OrdinalIgnoreCase significa que la comparación se realizará sin tener en cuenta las mayúsculas y minúsculas.
                 *Por ejemplo, "Juan", "juan" y "JUAN" se considerarán equivalentes.*/
                if (personas[i].nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Nombre: {personas[i].nombre}, Dirección: {personas[i].direccion}, Teléfono: {personas[i].telefono}, Edad: {personas[i].edad}");
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("No se encontraron personas con ese nombre.");
            }
        }
    }
}
