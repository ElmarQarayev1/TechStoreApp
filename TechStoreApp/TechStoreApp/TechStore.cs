using System;
using System.Collections.Generic;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace Task
{
    internal class TechStore
    {
        public string Name="0";
        public Notebook[] Notebooks = new Notebook[0];
        public double TotalAmount;
        public void Sell(Notebook notebook)
        {
            TotalAmount += notebook.Price;
        }

        public void Add(Notebook notebook)
        {
            Array.Resize(ref Notebooks, Notebooks.Length + 1);
            Notebooks[Notebooks.Length - 1] = notebook;
        }

        public Notebook Find(string name)
        {
            for (int i = 0; i < Notebooks.Length; i++)
            {
                if (Notebooks[i].Name == name)
                   return Notebooks[i];
            }
            return null;
        }
        public bool Check(string name)
        {
            for (int i = 0; i < Notebooks.Length; i++)
            {
                if (Notebooks[i].Name == name)
                {
                    return false;

                }
                
            }
                return true;
        }
        public void ShowInfo()
        {
            Console.WriteLine("notebooklar: ");
            for (int i = 0; i < Notebooks.Length; i++)
            {
                Console.WriteLine($"{Notebooks[i].Name}-{Notebooks[i].Price}");
            }
        }
        public bool CheckBeeingNote()
        {
            if (Notebooks.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}