using System.ComponentModel.DataAnnotations;

namespace DemoApp.DAL.Entities
{
    public class CustomerType : BaseEntity
    {
        [StringLength(200)]
        [Required]
        public string Description { get; set; }
    }
}