namespace GetQuoteApi.Models
{
    public class Quote
    {
        public long Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool IsFamous { get; set; }
    }
    
    
}