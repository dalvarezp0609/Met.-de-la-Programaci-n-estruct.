using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludos
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            // Pedir el nombre de la persona
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            // Saludar a la persona
            Console.WriteLine($"Hola, {nombre}! ¿Cómo estás?");
            Console.ReadKey();
        }
    }
}
