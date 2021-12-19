using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Relationship.TestPrinter
{
    class PlainPrinter : Printer
    {
        public override string PrintToScreen()
        {
            return $" This is a Plain Text format of the string {StringToBePrinted}";
        }
    }
}
