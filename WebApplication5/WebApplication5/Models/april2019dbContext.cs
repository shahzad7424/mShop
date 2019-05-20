using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication5.Models
{
    public partial class april2019dbContext : DbContext
    {
        public april2019dbContext()
        {
        }

        public april2019dbContext(DbContextOptions<april2019dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TMovie> TMovie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-9M7SHOQ;Database=april2019db;User ID=sa; Password=12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<TMovie>(entity =>
            {
                entity.ToTable("t_movie");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Actor)
                    .HasColumnName("actor")
                    .HasMaxLength(50);

                entity.Property(e => e.Actoress)
                    .HasColumnName("actoress")
                    .HasMaxLength(50);

                entity.Property(e => e.Movie)
                    .HasColumnName("movie")
                    .HasMaxLength(50);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("date");
            });
        }
    }
}
