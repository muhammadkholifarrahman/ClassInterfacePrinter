using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrinter
{
    class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nLaserJet Printer Dimension : 21*17");
        }

        public void Print()
        {
            Console.WriteLine("LaserJet Printer Printing...\n");
        }
    }
}