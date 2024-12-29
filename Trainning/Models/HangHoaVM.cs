namespace Trainning.Models
{
    public class HangHoaVM
    {
        public string TenHangHoa { get; set; }
        public double DonGia { get; set; }
    }
    public class hangHoa : HangHoaVM { 
        public Guid MaHangHoa { get; set;}
    }
}
