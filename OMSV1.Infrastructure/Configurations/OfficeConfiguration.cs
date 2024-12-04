using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OMSV1.Domain.Entities.Offices;

namespace OMSV1.Infrastructure.Configurations;

public class OfficeConfiguration : IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder.HasKey(o => o.Id); 

        builder.Property(o => o.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(o => o.Code)
            .IsRequired();

        builder.Property(o => o.ReceivingStaff)
            .IsRequired();

        builder.Property(o => o.AccountStaff)
            .IsRequired();

        builder.Property(o => o.PrintingStaff)
            .IsRequired();

        builder.Property(o => o.QualityStaff)
            .IsRequired();
            

        builder.Property(o => o.DeliveryStaff)  
        .IsRequired();

        builder.Property(o => o.GovernorateId)
            .IsRequired();

        // Relationship
        builder.HasOne(o => o.Governorate)
            .WithMany(g => g.Offices)
            .HasForeignKey(o => o.GovernorateId)
            .OnDelete(DeleteBehavior.Restrict);

        // Table Mapping
        builder.ToTable("Offices");
    }
}