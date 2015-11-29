using System;
using System.ComponentModel.DataAnnotations;

namespace WorkEffect.Website.Types
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.Id = new Guid();
            this.Deleted = false;
            this.CreatedOn = DateTime.UtcNow;
            this.UpdatedOn = DateTime.UtcNow;
        }
        [Required]
        public Guid Id { get; set; }

        [Required]
        public bool Deleted { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public Guid CreatedById { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        [Required]
        public Guid UpdatedById { get; set; }
    }
}
