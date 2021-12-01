using System;
using System.Collections.Generic;
using System.Text;

namespace CheckLogin
{
    class Check
    {
        public Check()
        {
            Console.WriteLine("Login inputlarinin yoxlanmasi ");
        }
        public Check(string name , int password):this()
        {
            if(name== "cavid@code.edu.az" && password == 12345)
            {
                Console.WriteLine("Giris Olundu");
            }
            else
            {
                Console.WriteLine("Mail ve ya Password sehvdir");
            }

        }
    }
}
