using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            //un numar exprimat in secunde

            int o, m, s, sec, difsec;
            Console.WriteLine("Introduceti numarul de secunde");
            sec = int.Parse(Console.ReadLine());

            o = sec / 3600;
            difsec = sec - o * 3600;
            m = difsec / 60;
            s = sec - o * 3600 - m * 60;

            Console.WriteLine("ore = {0}", o);
            Console.WriteLine("minute = {0}", m);
            Console.WriteLine("secunde = {0}", s);

        }
    }
}
