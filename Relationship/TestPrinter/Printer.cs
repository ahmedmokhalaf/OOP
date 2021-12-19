using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Relationship.TestPrinter
{
    abstract class Printer
    {
        protected string? StringToBePrinted;

        public void SetStringToBePrinted(string textString)
        {
            StringToBePrinted = textString;
        }

        abstract public string PrintToScreen();
    }
}
