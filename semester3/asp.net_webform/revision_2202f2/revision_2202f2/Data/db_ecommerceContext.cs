using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using revision_2202f2.Models;

namespace revision_2202f2.Data
{
    public partial class db_ecommerceContext : DbContext
    {
        public db_ecommerceContext()
        {
        }

        public db_ecommerceContext(DbContextOptions<db_ecommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCart> TblCarts { get; set; } = null!;
        public virtual DbSet<TblCategory> TblCategories { get; set; } = null!;
        public virtual DbSet<TblProduct> TblProducts { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=db_ecommerce;Persist Security Info=False;User ID=sa;Password=aptech;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCart>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("tbl_cart");

                entity.Property(e => e.ItemId).HasColumnName("Item_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblCarts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tbl_cart__produc__49C3F6B7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblCarts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__tbl_cart__user_i__4AB81AF0");
            });

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

                entity.Property(e => e.PImg)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("p_img");

                entity.Property(e => e.PName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_name");

                entity.Property(e => e.PPrice).HasColumnName("p_price");

                entity.HasOne(d => d.CIdNavigation)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.CId)
                    .HasConstraintName("FK__tbl_produc__c_id__25869641");
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
