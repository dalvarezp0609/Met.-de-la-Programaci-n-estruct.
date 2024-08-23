using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayor
{
    internal class Program7
    {
        static void Main(string[] args)
        {
            // Solicitar los tres números al usuario
            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Determinar el mayor de los tres números
            int mayor;
            if (num1 >= num2 && num1 >= num3)
            {
                mayor = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = num3;
            }

            // Mostrar el resultado
            Console.WriteLine($"El mayor de los tres números es: {mayor}");

            Console.ReadKey();
        }
    }
}
