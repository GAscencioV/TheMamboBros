using Microsoft.EntityFrameworkCore;
using TheMamboBros.Data.Entities;

namespace TheMamboBros.Data.Context
{
    public class TheMamboBrosContext : DbContext
    {
        public TheMamboBrosContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Music> Musics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("TheMambroBrosDb");
        }
    }
}
