using Djamana.Partenaires.Core.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Djamana.Partenaires.Core.Data.DjamanaContext.Configuration.DjamanaSettings
{
    internal sealed class HostelServicesSettings : IEntityTypeConfiguration<HostelServices>
    {
        public void Configure(EntityTypeBuilder<HostelServices> builder)
        {
            builder.ToTable("HostelServices");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(e => e.ServicesName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(e => e.CreatedAt)
                .IsRequired();

            builder.HasOne(hs => hs.Hostel)
                .WithMany(h => h.HostelServices)
                .HasForeignKey(hs => hs.HostelId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
