using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Basement : IPart
    {
        public string MaterialName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Cost { get; set; }
        public static int count = 0;
        public Basement(string materialName, int width, int height, int cost)
        {
            MaterialName = materialName;
            Width = width;
            Height = height;
            Cost = cost;
            count++;
        }

        public Basement()
        {
        }
    }
}
