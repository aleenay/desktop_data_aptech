using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication6_2207G1.Models;

namespace WebApplication6_2207G1.Data
{
    public partial class db_2207b2Context : DbContext
    {
        public db_2207b2Context()
        {
        }

        public db_2207b2Context(DbContextOptions<db_2207b2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategory> TblCategories { get; set; } = null!;
        public virtual DbSet<TblProduct> TblProducts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=db_2207b2;Persist Security Info=False;User ID=sa;Password=aptech;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tbl_category");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("c_id");

                entity.Property(e => e.CName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c_name");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.PId);

                entity.ToTable("tbl_product");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.PDes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_des");

                entity.Property(e => e.PName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_name");

                entity.Property(e => e.PPrice).HasColumnName("p_price");

                entity.HasOne(d => d.CIdNavigation)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.CId)
                    .HasConstraintName("FK__tbl_produc__c_id__36B12243");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
