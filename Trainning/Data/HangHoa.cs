using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trainning.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public Guid MaHh { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenHh { get; set; }
        public string Mota {  get; set; }
        [Range(0,double.MaxValue)]   
        
        public double Dongia { get; set; }
        public byte Giamgia { get; set; }
    }
}
