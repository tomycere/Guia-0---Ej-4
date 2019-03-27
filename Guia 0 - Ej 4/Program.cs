using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_0___Ej_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor entero: ");
            string cadena = Console.ReadLine();
            if (int.TryParse(cadena, out int num))
            {
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El valor ingresado no es Entero");
            }

            Console.WriteLine();

            Console.Write("Ingrese un valor decimal: ");
            string cadena2 = Console.ReadLine();
            if (decimal.TryParse(cadena, out decimal num2))
            {
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El valor ingresado no es Decimal");
            }

            Console.WriteLine();

            Console.Write("Ingrese un valor entero positivo: ");
            string cadena3 = Console.ReadLine();
            if (int.TryParse(cadena, out int num3))
            {
                if (num3 > 0)
                {
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El numero ingresa no es un numero positivo");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es Entero");
            }

            Console.WriteLine();

            Console.Write("Ingrese un valor entero negativo: ");
            string cadena4 = Console.ReadLine();
            if (int.TryParse(cadena, out int num4))
            {
                if (num4 < 0)
                {
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El numero ingresa no es un numero negativo");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es Entero");
            }

            Console.ReadKey();
        }   
    }
}
