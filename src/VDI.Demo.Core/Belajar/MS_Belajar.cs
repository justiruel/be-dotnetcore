using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VDI.Demo.Belajar
{
    [Table("MS_Belajar")]
    public class MS_Belajar : FullAuditedEntity
    {
        [Required]
        public string nama { get; set; }
        public int? umur { get; set; } //means return value can be null or integer.  kalo di database == allow null
    }
}


