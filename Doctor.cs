namespace GCS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        [Key]
        public decimal regno { get; set; }

        [Required]
        [StringLength(100)]
        public string DocName { get; set; }

        [Required]
        [StringLength(100)]
        public string specialization { get; set; }

        [Required]
        [StringLength(10)]
        public string gender { get; set; }

        [Column(TypeName = "numeric")]
        public decimal phone { get; set; }

        [Required]
        [StringLength(50)]
        public string UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string pwd { get; set; }

        [Required]
        [StringLength(30)]
        public string timings { get; set; }
    }
}
