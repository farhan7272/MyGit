using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public BlogDataContext(DbContextOptions<BlogDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public IQueryable<Trivia> Trivias
        {
            get
            {
                return new[]
                {
                    new Trivia
                    {
                        TriviaQuestion = "California's Mount Whitney measures as the highest peak in the lower 48 states. Its most famous climb is Mount Whitney Trail to the 14,495 feet summit. Wilderness permits are required."
                    },
                    new Trivia
                    {
                        TriviaQuestion="In 1925 a giant sequoia located in California's Kings Canyon National Park was named the nation's national Christmas tree. The tree is over 300 feet in height."
                    },
                    new Trivia
                    {
                        TriviaQuestion="More turkeys are raised in California than in any other state in the United States."
                    }

                }.AsQueryable();
            }
        }

        public IQueryable<MonthlySpecial> MonthlySpecials
        {
            get
            {
                return new[]
                {
                    new MonthlySpecial {
                        Key = "calm",
                        Name = "California Calm Package",
                        Type = "Day Spa Package",
                        Price = 250,
                    },
                    new MonthlySpecial {
                        Key = "desert",
                        Name = "From Desert to Sea",
                        Type = "2 Day Salton Sea",
                        Price = 350,
                    },
                    new MonthlySpecial {
                        Key = "backpack",
                        Name = "Backpack Cali",
                        Type = "Big Sur Retreat",
                        Price = 620,
                    },
                    new MonthlySpecial {
                        Key = "taste",
                        Name = "Taste of California",
                        Type = "Tapas & Groves",
                        Price = 150,
                    },
                }.AsQueryable();
            }
        }
    }
}
