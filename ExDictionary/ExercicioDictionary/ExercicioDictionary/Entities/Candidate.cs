namespace ExercicioDictionary.Entities
{
    internal class Candidate
    {
        public string Name { get; set; }
        public int TotalVotes { get; set; }

        public Candidate() { }

        public Candidate(string name, int totalVotes)
        {
            Name = name;
            TotalVotes = totalVotes;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Total Votes: {TotalVotes}";
        }
    }
}

