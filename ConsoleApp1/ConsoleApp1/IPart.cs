using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IPart
    {
        string MaterialName { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        int Cost { get; set; }
    }
}
