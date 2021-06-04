using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.DAL.Entities
{
    public class Customer : BaseEntity
    {
        [StringLength(150)]
        [Required]
        public string Name { get; set; }

        [StringLength(250)]
        [Required]
        public string Address { get; set; }

        public Guid CustomerTypeId { get; set; }

        [ForeignKey(nameof(CustomerTypeId))]
        public virtual CustomerType CustomerType { get; set; }

        public virtual ICollection<Activity> Activities { get; set; } = new HashSet<Activity>();
    }
}