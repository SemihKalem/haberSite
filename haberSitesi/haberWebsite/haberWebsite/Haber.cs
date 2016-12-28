namespace haberWebsite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Haber")]
    public partial class Haber
    {
        internal object HaberTip;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Haber()
        {
            Resim = new HashSet<Resim>();
            Etiket = new HashSet<Etiket>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(70)]
        public string Baslik { get; set; }

        [Required]
        [StringLength(200)]
        public string Ozet { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Icerik { get; set; }

        public DateTime YayimTarihi { get; set; }

        public Guid YazarID { get; set; }

        public int KategoriID { get; set; }

        public int TipiId { get; set; }

        [Required]
        [StringLength(200)]
        public string ResimYol { get; set; }

        [Required]
        [StringLength(200)]
        public string KucukResimYol { get; set; }

        public int Goruntulenme { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual Kategori Kategori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resim> Resim { get; set; }

        public virtual Yorum Yorum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etiket> Etiket { get; set; }
        public bool HaberTipi { get; internal set; }
    }
}
