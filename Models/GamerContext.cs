using Microsoft.EntityFrameworkCore;

namespace bingbong.Models
{
    public class GamerContext : DbContext
    {
        public GamerContext (DbContextOptions<GamerContext> options)
                : base(options)
                {

                }

                public DbSet<Gamer> Gamers {get; set;}
    }
}