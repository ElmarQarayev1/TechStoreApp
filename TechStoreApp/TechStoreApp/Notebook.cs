using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Notebook : Product
    {
        public Notebook(string name, double price) : base(name, price)
        {
            this.Name = "elmar";

        }
        public Notebook(string name, double price, int storage) : base(name, price)
        {
            Storage = storage;
        }
        public int Storage;
        
    }
}