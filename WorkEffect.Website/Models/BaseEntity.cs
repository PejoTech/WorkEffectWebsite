using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkEffect.Website.Models
{
    public class BaseEntity
    {
        [Key]
        [System.Data.Linq.Mapping.Column(Name = "Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    }
}