
using Api.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class AccessEntity : BaseEntity
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        public int IdModel { get; set; }
        public virtual ModelEntity Model { get; set; }
    }
}
