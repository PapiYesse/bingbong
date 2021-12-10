using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace bingbong.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GamerContext(
                serviceProvider.GetRequiredService<DbContextOptions<GamerContext>>()))
            {
                // Look for any Gamer Tags.
                if (context.Gamer.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Gamer.AddRange(
                    new Gamers
                    {
                        gamerTag = "__Papi"
                    },
                    new Gamers
                    {
                        gamerTag = "Tyroil Smoochie"
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}