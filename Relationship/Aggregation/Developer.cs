namespace DesignPattern.Relationship.Aggregation
{
    class Developer
    {
        private string Name;

        public Developer(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
