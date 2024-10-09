using AutoBiography.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoBiography.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories{ get; set; }

        public DbSet<Gallery> Gallery{ get; set; }

        public DbSet<UserProfile> Users{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Sedan"},
                new Category { Id = 2, Name = "SUV"},
                new Category { Id = 3, Name = "Sport"}
                );

            modelBuilder.Entity<Gallery>().HasData(
                new Gallery { Id = 1, URI = "https://images.unsplash.com/photo-1674110958136-40fd83adc9e3?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
new Gallery { Id = 2, URI = "https://images.unsplash.com/photo-1536721572694-0b9bc1bb6946?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
new Gallery { Id = 3, URI = "https://images.unsplash.com/photo-1712885046114-5ea81a2f7555?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
new Gallery { Id = 4, URI = "https://images.unsplash.com/photo-1714008384412-97137b26ab42?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw0fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
new Gallery { Id = 5, URI = "https://images.unsplash.com/photo-1722385640799-4ee84eb90038?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw1fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
new Gallery { Id = 6, URI = "https://images.unsplash.com/photo-1706082072635-d19df8f0f3fb?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw2fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
new Gallery { Id = 7, URI = "https://images.unsplash.com/photo-1712815780855-5cce5961f8ba?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw3fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
new Gallery { Id = 8, URI = "https://images.unsplash.com/photo-1711523164285-71e1dbb948ca?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw4fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
new Gallery { Id = 9, URI = "https://images.unsplash.com/photo-1717032676227-aceed0508f1e?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw5fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
new Gallery { Id = 10, URI = "https://images.unsplash.com/photo-1699506612941-9282c50c374d?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDEyOXww&ixlib=rb-4.0.3" },
new Gallery { Id = 11, URI = "https://images.unsplash.com/photo-1719970680701-9c9f5c3ff8b0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 12, URI = "https://images.unsplash.com/photo-1705563666935-4d0a72709948?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 13, URI = "https://images.unsplash.com/photo-1622058232252-a8657f5b2979?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 14, URI = "https://images.unsplash.com/photo-1698663198463-cdf3e40e023b?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 15, URI = "https://images.unsplash.com/photo-1698663198307-645561899472?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 16, URI = "https://images.unsplash.com/photo-1698663197379-2591b57c834c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 17, URI = "https://images.unsplash.com/photo-1698663198293-d06df57687ac?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 18, URI = "https://images.unsplash.com/photo-1698663198608-7116ee7596cd?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 19, URI = "https://images.unsplash.com/photo-1698663197413-c082e7d4af12?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 20, URI = "https://images.unsplash.com/photo-1698663197869-e9f75851f2bd?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 21, URI = "https://images.unsplash.com/photo-1698663198393-ed1cd802f093?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 22, URI = "https://images.unsplash.com/photo-1698663198373-c38cfe4d99ff?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 23, URI = "https://images.unsplash.com/photo-1698663198662-f50225e030c7?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 24, URI = "https://images.unsplash.com/photo-1698663198367-8ceb51fa89f0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 25, URI = "https://images.unsplash.com/photo-1698663198263-9984f048d3ea?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 26, URI = "https://images.unsplash.com/photo-1720590509047-4bd0591aaf13?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 27, URI = "https://images.unsplash.com/photo-1698663198707-d5d3ff6e963d?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 28, URI = "https://images.unsplash.com/photo-1698663198423-1c114d0294a0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 29, URI = "https://images.unsplash.com/photo-1622058232222-2700277d1a56?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 30, URI = "https://images.unsplash.com/photo-1698663198736-4e84796803db?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 31, URI = "https://images.unsplash.com/photo-1698663198451-b66759d9ff3c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 32, URI = "https://images.unsplash.com/photo-1698663197359-33f219b018c1?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 33, URI = "https://images.unsplash.com/photo-1698663197411-2ba61f5f4961?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 34, URI = "https://images.unsplash.com/photo-1725885970369-884a996b638c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 35, URI = "https://images.unsplash.com/photo-1698663198575-136cb08edd8e?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 36, URI = "https://images.unsplash.com/photo-1698663198546-b72850b1e84a?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 37, URI = "https://images.unsplash.com/photo-1646283181928-59e4244eb1e8?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 38, URI = "https://images.unsplash.com/photo-1709104761873-24cc12d23b28?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 39, URI = "https://images.unsplash.com/photo-1682570965698-9eb843b9bd13?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
new Gallery { Id = 40, URI = "https://images.unsplash.com/photo-1706752986827-f784d768d4c3?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw0MHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" }
                );
        }
    }
}
