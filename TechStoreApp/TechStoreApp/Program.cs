using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TechStore store = new TechStore();
            string opt;
            do
            {
                Console.WriteLine("1. Notebook elave et");
                Console.WriteLine("2. Notebook sat");
                Console.WriteLine("3. Total amounta bax");
                Console.WriteLine("0. Cix");

                Console.WriteLine("Emeliyyat secin");
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        
                        Console.WriteLine("Ad:");
                        string name = Console.ReadLine();
                        string Strprice;
                        double price;
                        do
                        {
                             Console.WriteLine("Price: ");
                         Strprice = Console.ReadLine();
                        
                        } while (!double.TryParse(Strprice,out price));
                       
            
                        Notebook newNt = new Notebook(name, price);
                        
                        
                        bool check =store.Check(name);
                        if (!check)
                        {
                            Console.WriteLine("elave etmek olmaz"); 
                        }
                        else
                        {
                            store.Add(newNt);
                        }
                        
                        break;
                    case "2":
                        store.ShowInfo();
                        bool checn = store.CheckBeeingNote();
                        if (checn)
                        {
                         Console.WriteLine("Mehsul adi:");
                        string ntName = Console.ReadLine();
                        Notebook nt = store.Find(ntName);

                        store.Sell(nt);
                        }
                        else
                        {
                            Console.WriteLine("notebooklar yoxdur");
                        }
                        

                        break;
                    case "3":
                        Console.WriteLine("Total amount:");
                        Console.WriteLine(store.TotalAmount);
                        break;
                    case "0":
                        Console.WriteLine("Proqram bitdi");
                        break;
                    default:
                        Console.WriteLine("Yanlis secim!");
                        break;
                }

            } while (opt != "0");


        }
      

    }
}