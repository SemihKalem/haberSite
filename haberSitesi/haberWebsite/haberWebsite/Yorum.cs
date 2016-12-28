namespace haberWebsite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yorum")]
    public partial class Yorum
    {
        public int Id { get; set; }

        public int HaberID { get; set; }

        [Required]
        [StringLength(50)]
        public string Baslik { get; set; }

        [Required]
        [StringLength(50)]
        public string Ip { get; set; }

        [Required]
        [StringLength(50)]
        public string AdSoyad { get; set; }

        [Required]
        [StringLength(100)]
        public string Mail { get; set; }

        [Required]
        [StringLength(500)]
        public string Icerik { get; set; }

        public DateTime Tarih { get; set; }

        public bool Onayli { get; set; }

        public int Begeni { get; set; }

        public int Tiksinti { get; set; }

        public virtual Haber Haber { get; set; }
    }
}
