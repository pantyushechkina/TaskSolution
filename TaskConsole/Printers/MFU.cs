﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole.Printers
{
    public class MFU : IWorkStrategy
    {
        public void DoPrint()
        {
            Console.WriteLine("printing is carried out on an MFP printer");
        }
    }
}
