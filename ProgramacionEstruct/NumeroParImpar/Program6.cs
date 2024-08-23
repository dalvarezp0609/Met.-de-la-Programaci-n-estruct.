using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroParImpar
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            // Solicitar el número al usuario
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Determinar si el número es par o impar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar.");
            }

            Console.ReadKey();
        }
    }
}
