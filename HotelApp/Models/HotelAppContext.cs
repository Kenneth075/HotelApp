using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Models;

public partial class HotelAppContext : DbContext
{
    public HotelAppContext()
    {
    }

    public HotelAppContext(DbContextOptions<HotelAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PictureDb> PictureDbs { get; set; }

    public virtual DbSet<PictureTbl> PictureTbls { get; set; }

    public virtual DbSet<RegUsersTbl> RegUsersTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=KENNETH;Integrated Security=True;database=HotelApp;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Command Timeout=0");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PictureDb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PictureDb");

            entity.Property(e => e.HotelDescription)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("hotelDescription");
            entity.Property(e => e.HotelGroup)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hotelGroup");
            entity.Property(e => e.HotelImageUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hotelImageUrl");
            entity.Property(e => e.HotelLocation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hotelLocation");
            entity.Property(e => e.HotelName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hotelName");
            entity.Property(e => e.HotelPopularity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hotelPopularity");
            entity.Property(e => e.HotelPrice)
                .HasMaxLength(50)
                .HasColumnName("hotelPrice");
            entity.Property(e => e.IsPopular)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PictureTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PictureTbl");

            entity.Property(e => e.HotelDescription)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("hotelDescription");
            entity.Property(e => e.HotelGroup)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hotelGroup");
            entity.Property(e => e.HotelImageUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hotelImageUrl");
            entity.Property(e => e.HotelLocation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hotelLocation");
            entity.Property(e => e.HotelName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hotelName");
            entity.Property(e => e.HotelPopularity)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hotelPopularity");
            entity.Property(e => e.HotelPrice)
                .HasMaxLength(50)
                .HasColumnName("hotelPrice");
            entity.Property(e => e.IsPopular)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RegUsersTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_User_Table");

            entity.ToTable("RegUsersTbl");

            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
