﻿using Djamana.Partenaires.Core.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Djamana.Partenaires.Core.Data.DjamanaContext.Configuration.DjamanaSettings
{
    internal sealed class HostelsSettings : IEntityTypeConfiguration<Hostels>
    {
        public void Configure(EntityTypeBuilder<Hostels> builder)
        {
            builder.ToTable("Hostels");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(e => e.Designation)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.Adress)
                .HasMaxLength(500);

            builder.Property(e => e.Phone)
                .IsRequired();

            builder.Property(e => e.CreatedAt)
                .IsRequired();

            builder.HasOne(e => e.City)
                .WithMany(c => c.Hostels)
                .HasForeignKey(e => e.CityId)
                .IsRequired();

            builder.HasMany(h => h.HostelServices)
                .WithOne(hs => hs.Hostel)
                .HasForeignKey(hs => hs.HostelId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
