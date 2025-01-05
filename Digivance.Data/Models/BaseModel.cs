namespace Digivance.Data.Models
{
    /// <summary>
    /// BaseModel represents the shared id and auditing fields of models within
    /// the Digivance Platform family of microservices.
    /// </summary>
    public record BaseModel
    {
        /// <summary>
        /// Optional unique id of the entity that created this record
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UTC date and time when this record was first created
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// The unique id of this record
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Optional unique id of the entity that last modified this record
        /// </summary>
        public Guid? ModifiedBy { get; set; }

        /// <summary>
        /// Optional UTC date and time when this record was last modified
        /// </summary>
        public DateTime? ModifiedOn { get; set; }
    }
}
