using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorEF.Models;

public partial class StudentdatabaseContext : DbContext
{
    public StudentdatabaseContext()
    {
    }

    public StudentdatabaseContext(DbContextOptions<StudentdatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StudTable> StudTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-JHF39MS\\SQLEXPRESS;Database=Studentdatabase;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudTable>(entity =>
        {
            entity.HasKey(e => e.Age);

            entity.ToTable("Stud_table");

            entity.Property(e => e.Age).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
