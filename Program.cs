using System;
using System.Collections.Generic;
using System.Text;

namespace IncrementoDeremento
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            Console.WriteLine(n++);
            Console.WriteLine(n);
            Console.WriteLine(n--);
            Console.WriteLine(n);
            Console.WriteLine(++n);
            Console.WriteLine(--n);

            Console.WriteLine(n+=5);
            Console.WriteLine(n-=5);
            Console.WriteLine(n*=5);
            Console.WriteLine(n/=5);

            Console.ReadKey();

        }

    }
}
