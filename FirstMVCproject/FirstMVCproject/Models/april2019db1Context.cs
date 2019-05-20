using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirstMVCproject.Models
{
    public partial class april2019db1Context : DbContext
    {
        public april2019db1Context()
        {
        }

        public april2019db1Context(DbContextOptions<april2019db1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TMovie> TMovie { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=den1.mssql8.gear.host ;Database=april2019db1;User ID=april2019db1; Password=Du8be1D-5QV-;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<TMovie>(entity =>
            {
                entity.ToTable("t_movie");

                entity.Property(e => e.Id).HasColumnName("id");

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
