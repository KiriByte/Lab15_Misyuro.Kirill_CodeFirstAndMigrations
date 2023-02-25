using Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Entity;
using Microsoft.EntityFrameworkCore;

namespace Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Context;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .IsUnicode(false);

            entity.HasKey(e => e.Id).HasName("Enployee_PK");

            entity.HasOne(e => e.Position)
                .WithMany(p => p.Employes)
                .HasConstraintName("FK_Employee_Position");
        });

        modelBuilder.Entity<Journal>(entity =>
        {
            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .IsUnicode(false);
            entity.HasKey(e => e.Id).HasName("Journal_PK");
            entity.HasOne(j => j.Employee)
                .WithMany(e => e.Journals)
                .HasConstraintName("FK_Journal_Employee");
            entity.HasOne(j => j.Room)
                .WithMany(e => e.Journals)
                .HasConstraintName("FK_Journal_Room");
            entity.HasOne(j => j.Visitor)
                .WithMany(e => e.Journals)
                .HasConstraintName("FK_Journal_Visitor");

        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .IsUnicode(false);
            entity.HasKey(e => e.Id).HasName("Position_PK");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .IsUnicode(false);
            entity.HasKey(e => e.Id).HasName("Room_PK");
        });

        modelBuilder.Entity<Visitor>(entity =>
        {
            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .IsUnicode(false);
            entity.HasKey(e => e.Id).HasName("Visitor_PK");
        });


        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Employee> Employee { get; set; } = null!;
    public DbSet<Journal> Journal { get; set; } = null!;
    public DbSet<Position> Position { get; set; } = null!;
    public DbSet<Room> Room { get; set; } = null!;
    public DbSet<Visitor> Visitor { get; set; } = null!;
}