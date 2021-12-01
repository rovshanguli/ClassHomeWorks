using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialWithClass
{
    class Factorial
    {
        public Factorial()
        {
            Console.WriteLine("Faktorialin Hesablanmasi");
        }
        public Factorial(int n):this()
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
