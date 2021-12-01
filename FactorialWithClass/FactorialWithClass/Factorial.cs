using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialWithClass
{
    class Factorial
    {
        public Factorial(int n)
        {
            int fuc = 1;
            for(int i= 1; i < n; i++)
            {
                fuc = fuc* i;
            }
            Console.WriteLine(fuc);
        }
    }
}
