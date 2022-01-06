namespace DesignPattern.Relationship.Composition
{
    class RAM
    {
        private int Size;

        public RAM(int size)
        {
            Size = size;
        }

        public int GEtSize() => Size;
    }
}