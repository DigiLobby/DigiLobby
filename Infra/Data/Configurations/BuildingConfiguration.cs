using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations;

public class BuildingConfiguration : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.Property(t => t.Name)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(t => t.Address)
            .HasMaxLength(800)
            .IsRequired();

        builder.Property(t => t.City)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(t => t.State)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(t => t.ZipCode)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(t => t.Country)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(t => t.Description)
            .HasMaxLength(800);

        
    }
}

