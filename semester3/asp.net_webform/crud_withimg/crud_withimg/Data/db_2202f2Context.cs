using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using crud_withimg.Models;

namespace crud_withimg.Data
{
    public partial class db_2202f2Context : DbContext
    {
        public db_2202f2Context()
        {
        }

        public db_2202f2Context(DbContextOptions<db_2202f2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategory> TblCategories { get; set; } = null!;
        public virtual DbSet<TblStd> TblStds { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=db_2202f2;Persist Security Info=False;User ID=sa;Password=aptech;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tbl_category");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.CName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c_name");
            });

            modelBuilder.Entity<TblStd>(entity =>
            {
                entity.HasKey(e => e.StdId);

                entity.ToTable("tbl_std");

                entity.Property(e => e.StdId)
                    .ValueGeneratedNever()
                    .HasColumnName("std_id");

                entity.Property(e => e.StdAge).HasColumnName("std_age");

                entity.Property(e => e.StdCity).HasColumnName("std_city");

                entity.Property(e => e.StdEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("std_email");

                entity.Property(e => e.StdName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("std_name");

                entity.Property(e => e.StdProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("std_profile");

                entity.HasOne(d => d.StdCityNavigation)
                    .WithMany(p => p.TblStds)
                    .HasForeignKey(d => d.StdCity)
                    .HasConstraintName("FK__tbl_std__std_cit__36B12243");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tbl_user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
