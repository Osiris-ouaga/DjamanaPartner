using Djamana.Partenaires.Core.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Djamana.Partenaires.Core.Data.DjamanaContext.Configuration.DjamanaSettings
{
    internal class PartnerSettings : IEntityTypeConfiguration<Partners>
    {
        public void Configure(EntityTypeBuilder<Partners> builder)
        {
            builder.ToTable("Partners");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.PhoneContact)
                .IsRequired();

            builder.Property(e => e.Adress)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(e => e.CreatedAt)
                .IsRequired();

            builder.HasOne(e => e.City)
                .WithMany()
                .HasForeignKey("CityId")
                .IsRequired();

            builder.HasOne(e => e.Hostel)
                .WithMany()
                .HasForeignKey("HostelId")
                .IsRequired();
        }
    }
}
