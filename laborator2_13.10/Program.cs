using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator2_13._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcul arie triunghi prin formula lui Heron

            int a, b, c;
            float p, S;

            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b=");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("c=");
            c= int.Parse(Console.ReadLine());

            p = (a + b + c) / 2;
            S = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("{0}", p);
            Console.WriteLine("Arie triunghi = {0}", S);

        }
    }
}
