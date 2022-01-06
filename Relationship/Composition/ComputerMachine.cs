namespace DesignPattern.Relationship.Composition
{
    class ComputerMachine
    {
        private CPU cpu;
        private RAM ram;

        public ComputerMachine(CPU cpu, RAM ram)
        {
            this.cpu = cpu;
            this.ram = ram;
        }

        public string CMDashBorad()
        {
            return $"My Machine Speed Is {cpu.GetSpeed()} GHZ And a Ram of {ram.GEtSize()} GB";
        }
    }
}
