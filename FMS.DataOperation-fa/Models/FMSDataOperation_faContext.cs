using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.DataOperation_fa.Models
{
    public partial class FMSDataOperation_faContext : DbContext
    {

        public FMSDataOperation_faContext(DbContextOptions<FMSDataOperation_faContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.ToTable("ACTOR");

                entity.Property(e => e.ActorId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.ToTable("FILM");

                entity.Property(e => e.FilmId).ValueGeneratedNever();

                entity.Property(e => e.ActorId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LengthMins).HasColumnName("Length(Mins)");

                entity.Property(e => e.Rating).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.RentalDurationDays).HasColumnName("RentalDuration(Days)");

                entity.Property(e => e.ReplacementCostCrores).HasColumnName("ReplacementCost(Crores)");

                entity.Property(e => e.SpecialFeatures)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.ActorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FILM_ACTOR");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FILM_CATEGORY");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FILM_LANGUAGE");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("LANGUAGE");

                entity.Property(e => e.LanguageId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
