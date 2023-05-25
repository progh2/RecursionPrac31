using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPrac31
{
    internal class Program
    {
        private static object fibo;

        static void Main(string[] args)
        {
            Fibonacci fino = new Fibonacci();
            Console.WriteLine(fibo.Get(10));
        }
    }
}
