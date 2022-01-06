namespace DesignPattern.Relationship.TestPrinter
{
    class HtmlPrinter : Printer
    {
        public override string PrintToScreen()
        {
            return $" <h1> This is a HTML format of the string {StringToBePrinted} </h1>";
        }
    }
}
