using Digivance.Data.EntityFramework.Tests.Entities;
using Microsoft.EntityFrameworkCore;

namespace Digivance.Data.EntityFramework.Tests.Contexts
{
    /// <summary>
    /// Very simple in memory context we use to test our BaseEntity
    /// </summary>
    public class SampleContext : DbContext
    {
        /// <summary>
        /// Represents the SampleEntities collection
        /// </summary>
        public DbSet<SampleEntity> SampleEntities { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public SampleContext() { }

        /// <summary>
        /// Basic constructor, instantiate from provided DbContextOptions
        /// </summary>
        /// <param name="options">The options to instantiate this context with</param>
        public SampleContext(DbContextOptions<SampleContext> options) : base(options) { }

        /// <summary>
        /// Default OnConfiguring will setup our basic in memory context with the
        /// name "TEST_SAMPLE"
        /// </summary>
        /// <param name="optionsBuilder">The options builder we can configure</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("TEST_SAMPLE");
        }

        /// <summary>
        /// Default OnModelCreating will configure the entity types we are using in
        /// collections above
        /// </summary>
        /// <param name="modelBuilder">The model builder we can configure</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new SampleEntityConfiguration()
                .Configure(modelBuilder.Entity<SampleEntity>());
        }
    }
}
