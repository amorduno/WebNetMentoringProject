using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebNetMentoringProject.Models
{
    public partial class DBShopContext : DbContext
    {
        public DBShopContext()
        {
        }

        public DBShopContext(DbContextOptions<DBShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Picture).HasColumnType("image");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.oCategory)
                    .WithOne(p => p.Product)
                    .HasForeignKey<Product>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Category");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
