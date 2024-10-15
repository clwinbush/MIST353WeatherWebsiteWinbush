using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MIST353WeatherWebsiteAPIS.Data;

public partial class LandscapingDbContext : DbContext
{
    public LandscapingDbContext()
    {
    }

    public LandscapingDbContext(DbContextOptions<LandscapingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Climate> Climates { get; set; }

    public virtual DbSet<LandscapingService> LandscapingServices { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Plant> Plants { get; set; }

    public virtual DbSet<ServiceProvider> ServiceProviders { get; set; }

    public virtual DbSet<ServiceSuitability> ServiceSuitabilities { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WeatherCondition> WeatherConditions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Climate>(entity =>
        {
            entity.HasKey(e => e.ClimateId).HasName("PK__Climates__55D2C24F93BEC85B");

            entity.HasIndex(e => e.ClimateName, "UQ__Climates__55C43FC783B77B61").IsUnique();

            entity.Property(e => e.ClimateId).HasColumnName("ClimateID");
            entity.Property(e => e.ClimateName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
        });

        modelBuilder.Entity<LandscapingService>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__Landscap__C51BB0EABBD836FD");

            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.PriceRange).HasMaxLength(50);
            entity.Property(e => e.ServiceName).HasMaxLength(100);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__Location__E7FEA47770353141");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.ZipCode).HasMaxLength(20);
        });

        modelBuilder.Entity<Plant>(entity =>
        {
            entity.HasKey(e => e.PlantId).HasName("PK__Plants__98FE46BCF766E884");

            entity.Property(e => e.PlantId).HasColumnName("PlantID");
            entity.Property(e => e.ClimateId).HasColumnName("ClimateID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.PlantName).HasMaxLength(100);
            entity.Property(e => e.ScientificName).HasMaxLength(150);

            entity.HasOne(d => d.Climate).WithMany(p => p.Plants)
                .HasForeignKey(d => d.ClimateId)
                .HasConstraintName("FK__Plants__ClimateI__4F7CD00D");
        });

        modelBuilder.Entity<ServiceProvider>(entity =>
        {
            entity.HasKey(e => e.ProviderId).HasName("PK__ServiceP__B54C689DDA2C8ACB");

            entity.HasIndex(e => e.Email, "UQ__ServiceP__A9D10534A211E3EC").IsUnique();

            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.CompanyName).HasMaxLength(150);
            entity.Property(e => e.ContactPerson).HasMaxLength(100);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.Website).HasMaxLength(255);

            entity.HasOne(d => d.Location).WithMany(p => p.ServiceProviders)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK__ServicePr__Locat__4CA06362");
        });

        modelBuilder.Entity<ServiceSuitability>(entity =>
        {
            entity.HasKey(e => e.ServiceSuitabilityId).HasName("PK__ServiceS__126969B066742E1D");

            entity.ToTable("ServiceSuitability");

            entity.Property(e => e.ServiceSuitabilityId).HasColumnName("ServiceSuitabilityID");
            entity.Property(e => e.ClimateId).HasColumnName("ClimateID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.SuitabilityDescription).HasMaxLength(255);

            entity.HasOne(d => d.Climate).WithMany(p => p.ServiceSuitabilities)
                .HasForeignKey(d => d.ClimateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ServiceSu__Clima__47DBAE45");

            entity.HasOne(d => d.Service).WithMany(p => p.ServiceSuitabilities)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ServiceSu__Servi__46E78A0C");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC914F239F");

            entity.HasIndex(e => e.Email, "UQ__Users__A9D105341267EC27").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);

            entity.HasOne(d => d.Location).WithMany(p => p.Users)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK__Users__LocationI__3D5E1FD2");
        });

        modelBuilder.Entity<WeatherCondition>(entity =>
        {
            entity.HasKey(e => e.WeatherConditionId).HasName("PK__WeatherC__F6B3A5574B2708E3");

            entity.Property(e => e.WeatherConditionId).HasColumnName("WeatherConditionID");
            entity.Property(e => e.AverageRainfall).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.AverageTemperature).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ClimateId).HasColumnName("ClimateID");
            entity.Property(e => e.HumidityLevel).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.LastUpdated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.HasOne(d => d.Climate).WithMany(p => p.WeatherConditions)
                .HasForeignKey(d => d.ClimateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WeatherCo__Clima__4222D4EF");

            entity.HasOne(d => d.Location).WithMany(p => p.WeatherConditions)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WeatherCo__Locat__412EB0B6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
