using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Abstract;

namespace Entity.Concreate.Entities
{
    [Table("Konaklamalar")]
    public class Konaklama : IEntity
    {
        [Key]
        [Column(Order =1)]
        public int ID { get; set; }
        
        [Required]
        public int MusteriID { get; set; }

        [Required]
        public int OdaID { get; set; }

        [Required]
        public DateTime GirisTarihi { get; set; }

        [Required]
        public DateTime CikisTarihi { get; set; }

        [Required]
        public decimal ToplamFiyat { get; set; }

        [Required]
        public bool AktifMi { get; set; }

        // İlişkiler
        [ForeignKey("MusteriID")]
        public Musteri GetMusteri { get; set; }

        [ForeignKey("OdaID")]
        public Oda GetOdalar { get; set; }

    }
}