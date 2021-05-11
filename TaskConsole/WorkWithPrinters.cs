using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskConsole.Printers;

namespace TaskConsole
{
    public class WorkWithPrinters
    {
        List<Printer> printers = new List<Printer>();
        public void AddPrinter(int speed, string name, string model, string color)
        {
            Printer printer = new Printer(speed,name,model,color);
            printers.Add(printer);
        }
        public void AllInfo()
        {
            foreach(var el in printers)
            {
                Console.WriteLine($"printer name: {el.name}\tmodel: {el.model}\tprint speed: {el.print_speed}p/sec.\tprint color: {el.print_color}");
                if (el.model.ToLower() == "mfp")
                {
                    MFU mfu = new MFU();
                    mfu.DoPrint();
                }
                if (el.model.ToLower() == "mobile photoprinter")
                {
                    MobilePhotoprinter mfu = new MobilePhotoprinter();
                    mfu.DoPrint();
                }
                if (el.model.ToLower() == "photoprinter")
                {
                    Photoprinter mfu = new Photoprinter();
                    mfu.DoPrint();
                }
                if (el.model.ToLower() == "plotter")
                {
                    Plotter mfu = new Plotter();
                    mfu.DoPrint();
                }
                if (el.model.ToLower() == "texile printer")
                {
                    TexilePrinter mfu = new TexilePrinter();
                    mfu.DoPrint();
                }
                Console.WriteLine();
            }
        }
        public void PrintTime(int num, string name, string model)
        {
            bool key = false;
            foreach(var el in printers)
            {
                if(el.name == name && el.model == model)
                {
                    Console.WriteLine($"to print {num} pages you need {el.print_speed * num } sec.");
                    key = true;
                }
            }
            if (key == false)
                Console.WriteLine("this printer is out of stock");
        }
        public void Menu()
        {
            Console.WriteLine("1. info about all printers");
            Console.WriteLine("2. add printer");
            Console.WriteLine("3. cost of printing on a specific printer");
            Console.WriteLine("4. exit");
        }
    }
}
