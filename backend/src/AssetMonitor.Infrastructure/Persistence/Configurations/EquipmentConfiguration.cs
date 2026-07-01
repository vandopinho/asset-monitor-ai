using AssetMonitor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetMonitor.Infrastructure.Persistence.Configurations;

public class EquipmentConfiguration :
    IEntityTypeConfiguration<Equipment>
{
    public void Configure(
        EntityTypeBuilder<Equipment> builder)
    {
        builder.ToTable("Equipments");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.SerialNumber)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Type)
            .HasMaxLength(80)
            .IsRequired();

        builder.Property(x => x.Status)
            .HasMaxLength(40)
            .IsRequired();

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId);
    }
}