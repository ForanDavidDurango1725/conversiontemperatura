using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiontemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }using System;

class ConversionTemperatura
    {
        static void Main()
        {
            double celsius, fahrenheit;

            Console.Write("Ingrese una temperatura en grados Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = celsius * 9 / 5 + 32;

            Console.WriteLine("La temperatura equivalente en grados Fahrenheit es: {0}", fahrenheit);
        }
    }
}
}
