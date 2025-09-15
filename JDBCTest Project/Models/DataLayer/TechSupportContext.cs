﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Assign_07.Models.DataLayer;

public partial class TechSupportContext : DbContext
{
    public TechSupportContext()
    {
    }

    public TechSupportContext(DbContextOptions<TechSupportContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Incident> Incidents { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Registration> Registrations { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Technician> Technicians { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=TARTARS_LAPTOP;Database=TechSupport;TrustServerCertificate=True;Trusted_Connection=True;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.State).IsFixedLength();

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.Customers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_States_Customers");
        });

        modelBuilder.Entity<Incident>(entity =>
        {
            entity.Property(e => e.ProductCode).IsFixedLength();

            entity.HasOne(d => d.Customer).WithMany(p => p.Incidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Incidents_Customers");

            entity.HasOne(d => d.ProductCodeNavigation).WithMany(p => p.Incidents).HasConstraintName("FK_Incidents_Products");

            entity.HasOne(d => d.Tech).WithMany(p => p.Incidents)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Incidents_Technicians");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ProductCode).IsFixedLength();
        });

        modelBuilder.Entity<Registration>(entity =>
        {
            entity.Property(e => e.ProductCode).IsFixedLength();

            entity.HasOne(d => d.Customer).WithMany(p => p.Registrations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registrations_Customers");

            entity.HasOne(d => d.ProductCodeNavigation).WithMany(p => p.Registrations).HasConstraintName("FK_Registrations_Products");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.Property(e => e.StateCode).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
