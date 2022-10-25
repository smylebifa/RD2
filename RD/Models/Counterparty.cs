namespace RD.Models
{
    public class Counterparty
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Counterparty()
        {
            Id = 1;
        }

        public Counterparty(int id, string name)
        {
            Id = id; 
            Name = name;
        }

        public Counterparty(string name)
        {
            Name = name;
        }
    }
}
