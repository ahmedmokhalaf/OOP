namespace DesignPattern.Relationship.Aggregation
{
    class Project
    {
        private string Name;
        private DateOnly DeadLine;
        private HashSet<Developer> Developers;

        public Project(string name, DateOnly deadLine, HashSet<Developer> developers)
        {
            Name = name;
            DeadLine = deadLine;
            Developers = developers;
        }

        public DateOnly SetDeadLine(int NoMonth)
        {
            return DeadLine.AddMonths(NoMonth);
        }

        public string ShowProjectInformation()
        {
            //List<string> developerNames = new List<string>();
            //Developers.ForEach(x => developerNames.Append(x.GetName().ToString()));
            List<string> DeveloperNames = Developers.Select((x) => x.GetName()).ToList();
            DeveloperNames.ForEach((name) => DeveloperNames.Append(name.ToString()));
            string DNames = string.Join(",", DeveloperNames);

            return $"Project Name" + Name +
               $"Project Dead Line" + DeadLine.ToShortDateString() +
               $"Developers : " + DNames;
        }
    }
}
