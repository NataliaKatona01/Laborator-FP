using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inversarea valorilor a doua numere
            int a, b, x;

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("a={0}, b={1}", a, b);
            x = a;
            a = b;
            b = x;

            Console.WriteLine("a={0}, b={1}", a, b); 
           
        }
    }
}
