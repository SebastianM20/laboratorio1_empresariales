using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirCF
{
    internal class Program
    {
        static int Cel(int a)
        {
            return ((9 * a) / 5) + 32;
        }

        static int Far(int a)
        {
            return (5 * (a - 32)) / 9;
        }
        static void Main(string[] args)
        {
            Console.Title = "Convertir C a F (o viceversa)";
            string opcion;
            do
            { 
                Console.Clear();
                Console.WriteLine("[1] Convierte F a C");
                Console.WriteLine("[2] Convierte C a F");
                Console.WriteLine("[0] Salir zzz");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese la temperatura en F: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La temperatura en Celcius es: ",a,Cel(a));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese la temperatura en F: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La temperatura en Celcius es: ",b, Far(b));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }
    }
}
