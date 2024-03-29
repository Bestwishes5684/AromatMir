﻿using System;
using AromatMir.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AromatMir.DbContextT
{
    public partial class TradeContext : DbContext
    {
    

        public TradeContext(DbContextOptions<TradeContext> options)
            : base(options)
        {
        }

        public  DbSet<Order> Order { get; set; }
        public  DbSet<OrderProduct> OrderProduct { get; set; }
        public  DbSet<PickupPoint> PickupPoint { get; set; }
        public  DbSet<Product> Product { get; set; }
        public  DbSet<Role> Role { get; set; }
        public  DbSet<User> User { get; set; }

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CodeGive)
                    .IsRequired()
                    .HasColumnName("Code_Give")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FioClient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TheOrder).IsRequired();

                entity.HasOne(d => d.OrderPickupPointNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.OrderPickupPoint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_PikupPoint");
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductArticleNumber })
                    .HasName("PK__OrderPro__817A26627323D1E6");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductArticleNumber).HasMaxLength(100);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProduct)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderProd__Order__2D27B809");

                entity.HasOne(d => d.ProductArticleNumberNavigation)
                    .WithMany(p => p.OrderProduct)
                    .HasForeignKey(d => d.ProductArticleNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderProd__Produ__4222D4EF");
            });

            modelBuilder.Entity<PickupPoint>(entity =>
            {
                entity.HasKey(e => e.IdPickupPoint)
                    .HasName("PK_PikupPoint_1");

                entity.Property(e => e.IdPickupPoint)
                    .HasColumnName("Id_PickupPoint")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityPickupPoint)
                    .HasColumnName("City_PickupPoint")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailIndexPickupPoint)
                    .HasColumnName("MailIndex_PickupPoint")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberHousePickupPoint)
                    .HasColumnName("NumberHouse_PickupPoint")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StreetPickupPoint)
                    .HasColumnName("Street_PickupPoint")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductArticleNumber)
                    .HasName("PK__Product__2EA7DCD544241CD6");

                entity.Property(e => e.ProductArticleNumber).HasMaxLength(100);

                entity.Property(e => e.ProductCategory).IsRequired();

                entity.Property(e => e.ProductCost).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ProductDescription).IsRequired();

                entity.Property(e => e.ProductManufacturer).IsRequired();

                entity.Property(e => e.ProductName).IsRequired();

                entity.Property(e => e.ProductPhoto)
                    .HasColumnType("image");

                entity.Property(e => e.ProductStatus).IsRequired();
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserLogin).IsRequired();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserPassword).IsRequired();

                entity.Property(e => e.UserPatronymic)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserSurname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.UserRoleNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User__UserRole__4316F928");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
