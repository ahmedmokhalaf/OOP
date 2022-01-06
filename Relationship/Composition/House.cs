namespace DesignPattern.Relationship.Composition
{
    class House
    {
        private List<Room> Rooms;

        public House(List<Room> rooms)
        {
            Rooms = rooms;
        }
    }
}
