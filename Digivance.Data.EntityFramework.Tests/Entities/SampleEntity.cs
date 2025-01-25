using Digivance.Data.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Digivance.Data.EntityFramework.Tests.Entities
{
    /// <summary>
    /// A sample entity we use to test our BaseEntity functionality
    /// </summary>
    public record SampleEntity : BaseEntity
    {
        /// <summary>
        /// A custom field on our sample entity
        /// </summary>
        public string? SampleMessage { get; set; }
    }

    /// <summary>
    /// EntityFramework type configuration for our sample entity
    /// </summary>
    public class SampleEntityConfiguration : IEntityTypeConfiguration<SampleEntity>
    {
        public void Configure(EntityTypeBuilder<SampleEntity> builder)
        {
            builder.ConfigureBaseEntity();

            builder.Property(x => x.SampleMessage)
                .IsRequired(false)
                .HasMaxLength(255);
        }
    }
}
