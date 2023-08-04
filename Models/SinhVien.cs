using System.ComponentModel.DataAnnotations;

namespace NguyenDuongHung_01.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSinhVien{ get; set; }
        public string?  HoTen { get; set; }
        public string?  Malop { get; set; }
    }
}
