using ETickets.Models;
using Microsoft.EntityFrameworkCore;

namespace ETickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(n => new
            {
                n.ActorId,
                n.MovieId

            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(m => m.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(m => m.Actors_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<actor> Actors { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Actor_Movie> actor_Movies { get; set; }

    }
}
