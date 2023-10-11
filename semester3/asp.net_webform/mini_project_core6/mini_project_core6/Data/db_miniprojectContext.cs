using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using mini_project_core6.Models;

namespace mini_project_core6.Data
{
    public partial class db_miniprojectContext : DbContext
    {
        public db_miniprojectContext()
        {
        }

        public db_miniprojectContext(DbContextOptions<db_miniprojectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategory> TblCategories { get; set; } = null!;
        public virtual DbSet<TblInvoice> TblInvoices { get; set; } = null!;
        public virtual DbSet<TblOrder> TblOrders { get; set; } = null!;
        public virtual DbSet<TblProduct> TblProducts { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=db_miniproject;Persist Security Info=False;User ID=sa;Password=aptech;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
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

            modelBuilder.Entity<TblInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("tbl_invoice");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.InvoiceTotalbill).HasColumnName("invoice_totalbill");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblInvoices)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__tbl_invoi__user___2E1BDC42");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.OId);

                entity.ToTable("tbl_order");

                entity.Property(e => e.OId).HasColumnName("o_id");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.OBill).HasColumnName("o_bill");

                entity.Property(e => e.ODate)
                    .HasColumnType("datetime")
                    .HasColumnName("o_date");

                entity.Property(e => e.OQty).HasColumnName("o_qty");

                entity.Property(e => e.ProId).HasColumnName("pro_id");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK__tbl_order__invoi__2D27B809");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK__tbl_order__pro_i__2C3393D0");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.PId);

                entity.ToTable("tbl_product");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.PDes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_des");

                entity.Property(e => e.PImg)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("p_img");

                entity.Property(e => e.PName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_name");

                entity.Property(e => e.PPrice).HasColumnName("p_price");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__tbl_produ__cat_i__2B3F6F97");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UId);

                entity.ToTable("tbl_user");

                entity.Property(e => e.UId).HasColumnName("u_id");

                entity.Property(e => e.UEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("u_email");

                entity.Property(e => e.UName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("u_name");

                entity.Property(e => e.UPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("u_password");

                entity.Property(e => e.UPhoneno).HasColumnName("u_phoneno");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
