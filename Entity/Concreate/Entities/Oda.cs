using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Abstract;

namespace Entity.Concreate.Entities
{
    [Table("Odalar")]
    public class Oda : IEntity
    {
        [Key] [Column(Order = 1)] public int ID { get; set; }

        [StringLength(5)] [Required] public string Odano { get; set; }

        [Required] public decimal Fiyat { get; set; }

        [Required] public bool MusaitMi { get; set; }
    }
}