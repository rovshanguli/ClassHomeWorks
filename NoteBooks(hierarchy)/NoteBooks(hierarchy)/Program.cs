using System;

namespace NoteBooks_hierarchy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asus Parametrs    :");
            Asus notebook = new Asus(16,"Intel i5",15.6,512);

            Console.WriteLine("                                              ");
            Console.WriteLine("Ryzen Parametrs   :");
            Acer notebook1 = new Acer(8, "Ryzen r3", 13.8, 1024);
           
           
        }
        
    }
}
