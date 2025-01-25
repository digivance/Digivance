using Digivance.Data.Models;

namespace Digivance.Data.EntityFramework.Tests.Models
{
    /// <summary>
    /// Sample Model that we use to test our BaseEntity with
    /// </summary>
    public record SampleModel : BaseModel
    {
        /// <summary>
        /// A custom field on our sample entity
        /// </summary>
        public string? SampleMessage { get; set; }
    }
}
