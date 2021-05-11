using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    public class Printer
    {
        public int print_speed;
        public string name;
        public string model;
        public string print_color;
        public Printer(int speed, string name, string model, string color)
        {
            print_speed = speed;
            this.name = name;
            this.model = model;
            print_color = color;
        }

    }
}
