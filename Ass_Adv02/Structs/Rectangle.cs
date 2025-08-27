using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv02.Structs
{
    struct Rectangle
    {
        private double width;
        private double height;

        public double Width
        {
            get => width;
            set
            {
                if (value >= 0)
                    width = value;
                else
                    Console.WriteLine("Error: Width cannot be negative!");
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value >= 0)
                    height = value;
                else
                    Console.WriteLine("Error: Height cannot be negative!");
            }
        }

        public double Area => width * height;

        public void DisplayInfo()
        {
            Console.WriteLine($"Rectangle: Width={width}, Height={height}, Area={Area}");
        }
    }
}
