using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            // Solicitar el primer número entero
            Console.Write("Ingrese el primer número entero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Solicitar el segundo número entero
            Console.Write("Ingrese el segundo número entero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Calcular la suma de los dos números
            int suma = num1 + num2;

            // Mostrar la suma de los dos números
            Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");

            Console.ReadKey();
        }
    }
}
