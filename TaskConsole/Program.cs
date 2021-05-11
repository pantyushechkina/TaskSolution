using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskConsole.Printers;

namespace TaskConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithPrinters work = new WorkWithPrinters();
            work.Menu();
            Console.Write("select menu item: ");
            int key = Convert.ToInt32(Console.ReadLine());
            while (key != 4)
            {
                switch (key)
                {
                    case 1:
                        work.AllInfo();
                        break;
                    case 2:
                        Console.Write("input print speed: ");
                        int speed = Convert.ToInt32(Console.ReadLine());
                        Console.Write("input printer's name: ");
                        string name = Console.ReadLine();
                        Console.Write("input printer's model: ");
                        string model = Console.ReadLine();
                        Console.WriteLine("select print color:\n\t1. chromatic print\n\t2. black and white print");
                        int c = Convert.ToInt32(Console.ReadLine());
                        string color = c == 1 ? "chromatic" : "black and white";
                        work.AddPrinter(speed,name,model,color);
                        break;
                    case 3:
                        Console.Write("input num of pages: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.Write("input printer's name: ");
                        string n = Console.ReadLine();
                        Console.Write("input printer's model: ");
                        string m = Console.ReadLine();
                        work.PrintTime(num, n, m);
                        break;
                    default:
                        Console.WriteLine("select menu item");
                        break;
                }
                Console.WriteLine("select menu item");
                key = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
