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
