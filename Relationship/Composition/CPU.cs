namespace DesignPattern.Relationship.Composition
{
    class CPU
    {
        private int Speed;

        public CPU(int speed)
        {
            Speed = speed;
        }

        public int GetSpeed() => Speed;
    }
}