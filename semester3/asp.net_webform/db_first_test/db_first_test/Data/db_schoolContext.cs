using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using db_first_test.Models;

namespace db_first_test.Data
{
    public partial class db_schoolContext : DbContext
    {
        public db_schoolContext()
        {
        }

        public db_schoolContext(DbContextOptions<db_schoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCity> TblCities { get; set; } = null!;
        public virtual DbSet<TblStdInfo> TblStdInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=db_school;Persist Security Info=False;User ID=sa;Password=aptech;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("tbl_city");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("c_id");

                entity.Property(e => e.CName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c_name");
            });

            modelBuilder.Entity<TblStdInfo>(entity =>
            {
                entity.HasKey(e => e.StdId);

                entity.ToTable("tbl_std_info");

                entity.Property(e => e.StdId)
                    .ValueGeneratedNever()
                    .HasColumnName("std_id");

                entity.Property(e => e.StdAge)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("std_age");

                entity.Property(e => e.StdCity).HasColumnName("std_city");

                entity.Property(e => e.StdName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("std_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
