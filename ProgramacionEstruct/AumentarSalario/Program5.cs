using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentarSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leer el nombre del trabajador
            Console.Write("Ingrese el nombre del trabajador: ");
            string nombre = Console.ReadLine();

            // Leer el cargo del trabajador
            Console.Write("Ingrese el cargo del trabajador: ");
            string cargo = Console.ReadLine();

            // Leer el salario del trabajador
            Console.Write("Ingrese el salario del trabajador: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            // Calcular el aumento del 10%
            double aumento = salario * 0.10;

            // Calcular el nuevo salario
            double nuevoSalario = salario + aumento;

            // Mostrar los datos del trabajador con aumento
            Console.WriteLine($"Datos del trabajador:");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Salario anterior: {salario:C2}");
            Console.WriteLine($"Aumento: {aumento:C2}");
            Console.WriteLine($"Salario nuevo: {nuevoSalario:C2}");

            Console.ReadKey();
        }
    }
}
