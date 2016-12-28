namespace haberWebsite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HaberTip")]
    public partial class HaberTip
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Adi { get; set; }
    }
}
