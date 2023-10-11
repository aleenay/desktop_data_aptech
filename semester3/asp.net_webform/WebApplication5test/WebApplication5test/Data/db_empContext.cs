using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication5test.Models;

namespace WebApplication5test.Data
{
    public partial class db_empContext : DbContext
    {
        public db_empContext()
        {
        }

        public db_empContext(DbContextOptions<db_empContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCity> TblCities { get; set; } = null!;
        public virtual DbSet<TblEmpDetail> TblEmpDetails { get; set; } = null!;
        public virtual DbSet<TblStd> TblStds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=db_emp;Persist Security Info=False;User ID=sa;Password=aptech;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.ToTable("tbl_cities");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblEmpDetail>(entity =>
            {
                entity.ToTable("tbl_emp_detail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phoneno).HasColumnName("phoneno");
            });

            modelBuilder.Entity<TblStd>(entity =>
            {
                entity.ToTable("tbl_std");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.TblStds)
                    .HasForeignKey(d => d.City)
                    .HasConstraintName("FK__tbl_std__city__36B12243");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
