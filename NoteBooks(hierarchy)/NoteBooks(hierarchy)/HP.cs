using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBooks_hierarchy_
{
    class HP:NoteBooks
    {
        public HP(int ram, string processor, double screensize, int memory) : base(ram, processor, screensize, memory)
        {
            this.ram = ram;
            this.processor = processor;
            this.screensize = screensize;
            this.memory = memory;
        }
    }
}
