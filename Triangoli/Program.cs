using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il primo lato");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo lato");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il terzo lato");
            double c = double.Parse(Console.ReadLine());
            double perimetro = 0;
            double area = 0;
            double altezza = Math.Sqrt(3) / 2 * a;
            if (a == b && a == c)
            {
                Console.WriteLine("è un triangolo equilatero");
                perimetro = (a + b + c);
                area = (altezza * a) / 2;
                Console.WriteLine($"il perimetro del triangolo è {perimetro} e l'area è {area}");
            }
            else
            {
                Console.WriteLine("non è un trangolo equilatero");
            }
            Console.ReadLine();
        }
        
    }
}
