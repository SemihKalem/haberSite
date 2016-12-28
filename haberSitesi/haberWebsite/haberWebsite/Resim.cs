namespace haberWebsite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Resim")]
    public partial class Resim
    {
        public int Id { get; set; }

        public int HaberID { get; set; }

        [Required]
        [StringLength(110)]
        public string Ozet { get; set; }

        [Required]
        [StringLength(200)]
        public string ResimYol { get; set; }

        public virtual Haber Haber { get; set; }
    }
}
