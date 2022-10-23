namespace PZ_ASP_UnitOfWorks.Models
{
    public class Not
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"[{Id}]\n{Date}\nText: {Text}";
        }

    }
}
