using Microsoft.EntityFrameworkCore;

namespace MusicCollectionREST.Models
{
    public class RecordDbContext : DbContext
    {
        public RecordDbContext(DbContextOptions<RecordDbContext> options) : base(options)
        {
        }
        public DbSet<Record> Records { get; set; }
    }
}
