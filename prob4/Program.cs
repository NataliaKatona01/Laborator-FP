using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float a1, b1, c1, c;

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            a1 = a;
            b1 = b;

            Console.WriteLine("Parte intreaga = {0}", a / b);
            Console.WriteLine("Rest = {0}", a % b);
            Console.WriteLine("Modulul (Val absoluta) = {0}", Math.Abs(a));
            Console.WriteLine("Radical = {0}", Math.Sqrt(a));
            c = a / b; //var c preia partea intreaga (catul intreg)
            Console.WriteLine("c={0}", c);
            c1 = a1 / b1; //var c1 preia si partea zecimala
            Console.WriteLine("Cat real = {0}", c1);
        }
    }
}
