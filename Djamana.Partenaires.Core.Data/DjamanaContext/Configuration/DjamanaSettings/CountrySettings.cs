using Djamana.Partenaires.Core.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Djamana.Partenaires.Core.Data.DjamanaContext.Configuration.DjamanaSettings
{
    internal sealed class CountrySettings : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(e => e.CreatedAt)
                .IsRequired();
        }
    }
}
