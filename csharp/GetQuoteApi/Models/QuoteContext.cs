using Microsoft.EntityFrameworkCore;

namespace GetQuoteApi.Models
{
    public class GetQuoteContext: DbContext
    {
        public GetQuoteContext(DbContextOptions<GetQuoteContext> options)
            :base(options)
        {}
        
        public DbSet<Quote> Quotes { get; set; }
        
    }
}