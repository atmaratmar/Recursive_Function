using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Function
{
    class Program
    {
        //Recursion is when a method call it selfe 
        static void Main(string[] args)
        {
            int answer = 0;
            answer = factorial(5);
            Console.WriteLine(answer);
        }
        private static int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

    }
}
