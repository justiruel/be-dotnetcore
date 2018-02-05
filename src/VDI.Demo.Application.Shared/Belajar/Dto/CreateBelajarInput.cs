using System.ComponentModel.DataAnnotations;

namespace VDI.Demo.Belajar
{
    public class CreateBelajarInput
    {
        [Required]
        //[StringLength(5)]
        public string nama { get; set; }
        public int? umur { get; set; }
    }
}