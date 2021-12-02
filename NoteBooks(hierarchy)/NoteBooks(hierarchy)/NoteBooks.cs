using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBooks_hierarchy_
{
    class NoteBooks
    {

       public int ram;
       public string processor;
       public double screensize;
       public int memory;
       
       
        public NoteBooks(int ram, string processor, double screensize, int memory)
        {
            this.ram = ram;
            this.processor = processor;
            this.screensize = screensize;
            this.memory = memory;
            Console.WriteLine("Ram " + ram);
            Console.WriteLine("Processor " + processor);
            Console.WriteLine("ScreenSize " + screensize);
            Console.WriteLine("Memory " + memory);

        }
        
    }
}
