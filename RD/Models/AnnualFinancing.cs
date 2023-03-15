namespace RD.Models
{
    public class AnnualFinancing
    {
        public int Id { get; set; }
        public int ThemeId { get; set; }
        public int? Year { get; set; }
        public float? Amount { get; set; }

        public AnnualFinancing()
        {
            Id = 1;
        }

        public AnnualFinancing(int id, int themeId)
        {
            Id = id;
            ThemeId = themeId;
        }

        public AnnualFinancing(int id, int themeId, int year, float amount)
        {
            Id = id;
            ThemeId = themeId;
            Year = year;
            Amount = amount;
        }
      
    }
}
