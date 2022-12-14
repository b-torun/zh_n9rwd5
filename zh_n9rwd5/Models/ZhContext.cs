using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace zh_n9rwd5.Models;

public partial class ZhContext : DbContext
{
    public ZhContext()
    {
    }

    public ZhContext(DbContextOptions<ZhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Rendelések> Rendelések { get; set; }

    public virtual DbSet<Vásárló> Vásárló { get; set; }

    public virtual DbSet<Ügynökök> Ügynökök { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=zh.database.windows.net;Initial Catalog=zh;Persist Security Info=True;User ID=turan;Password=Barni2001");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rendelések>(entity =>
        {
            entity.HasKey(e => e.RendelésAzon).HasName("PK__Rendelés__AE591F22D4876A35");

            entity.Property(e => e.RendelésAzon)
                .ValueGeneratedNever()
                .HasColumnName("Rendelés_azon");
            entity.Property(e => e.RendelésiDátum)
                .HasColumnType("date")
                .HasColumnName("Rendelési_dátum");
            entity.Property(e => e.RendelésiMenny).HasColumnName("Rendelési_menny");
            entity.Property(e => e.VásárlóAzon)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Vásárló_azon");
            entity.Property(e => e.ÜgynökAzon)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Ügynök_azon");

            entity.HasOne(d => d.VásárlóAzonNavigation).WithMany(p => p.Rendelések)
                .HasForeignKey(d => d.VásárlóAzon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Rendelése__Vásár__68487DD7");

            entity.HasOne(d => d.ÜgynökAzonNavigation).WithMany(p => p.Rendelések)
                .HasForeignKey(d => d.ÜgynökAzon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Rendelése__Ügynö__693CA210");
        });

        modelBuilder.Entity<Vásárló>(entity =>
        {
            entity.HasKey(e => e.VásárlóAzon).HasName("PK__Vásárló__000F98AEEEB4587F");

            entity.Property(e => e.VásárlóAzon)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Vásárló_azon");
            entity.Property(e => e.VásárlóNév)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Vásárló_név");
            entity.Property(e => e.VásárlóOrszág)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Vásárló_ország");
            entity.Property(e => e.ÜgynökAzon)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Ügynök_azon");

            entity.HasOne(d => d.ÜgynökAzonNavigation).WithMany(p => p.Vásárló)
                .HasForeignKey(d => d.ÜgynökAzon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Vásárló__Ügynök___656C112C");
        });

        modelBuilder.Entity<Ügynökök>(entity =>
        {
            entity.HasKey(e => e.ÜgynökAzon).HasName("PK__Ügynökök__1B0A552837D41CFB");

            entity.Property(e => e.ÜgynökAzon)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Ügynök_azon");
            entity.Property(e => e.Telefon)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ÜgynökNév)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Ügynök_név");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
