using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole.Printers
{
    public class Photoprinter : IWorkStrategy
    {
        public void DoPrint()
        {
            Console.WriteLine("printing is carried out on an photoprinter");
        }
    }
}
