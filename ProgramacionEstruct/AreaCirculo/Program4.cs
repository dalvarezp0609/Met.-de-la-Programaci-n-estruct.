using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculo
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            // Solicitar el radio del círculo
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            // Calcular el área del círculo
            double area = Math.PI * Math.Pow(radio, 2);

            // Mostrar el resultado
            Console.WriteLine($"El área del círculo con radio {radio} es: {area:F2}");

            Console.ReadKey();
        }
    }
}
