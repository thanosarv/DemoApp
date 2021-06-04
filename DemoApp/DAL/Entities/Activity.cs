using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.DAL.Entities
{
    public class Activity : BaseEntity
    {
        [MaxLength(500)]
        [Required]
        public string Description { get; set; }

        public Guid CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Guid ActivityTypeId { get; set; }

        [ForeignKey(nameof(ActivityTypeId))]
        public virtual ActivityType ActivityType { get; set; }
    }
}