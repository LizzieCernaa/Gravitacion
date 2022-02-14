using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyDeGravitacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ley de la Gravitacion Universal");

            Console.WriteLine("Ingrese la masa del cuerpo 1");
            int m1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la masa del cuerpo 2");
            int m2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba la distancia entre los centros de los cuerpos ");
            int r = int.Parse(Console.ReadLine());

            double G = 9.81;

            double F = G * ((m1 * m2) / Math.Pow(r, 2));

            Console.WriteLine("El resultado es:" + F);

            Console.ReadKey();
        }
    }
}
 