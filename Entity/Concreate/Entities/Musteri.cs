using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Abstract;

namespace Entity.Concreate.Entities
{
    [Table("Musteriler")]
    public class Musteri : IEntity
    {
        [Key] [Column(Order = 1)] public int ID { get; set; }

        [Required(ErrorMessage = "Lütfen tc kimlik no alanını giriniz..")]
        [StringLength(11)]
        public string TCNo { get; set; }

        [Required(ErrorMessage = "Lütfen isim alanını giriniz..")]
        [StringLength(20)]
        public string Isim { get; set; }

        [Required(ErrorMessage = "Lütfen soy isim alanını giriniz..")]
        [StringLength(20)]
        public string Soyisim { get; set; }

        [Required(ErrorMessage = "Lütfen isim alanını giriniz..")]
        [StringLength(15)]
        public string Telefon { get; set; }


        [EmailAddress]
        [RegularExpression(@"[a-z0-9._-]+@[a-z0-9.-]+\.[a-z]{2,4}")]
        public string Email { get; set; }

        [StringLength(5)] public string Cinsiyet { get; set; }

        public List<Konaklama> Konaklamalar { get; set; }
    }
}