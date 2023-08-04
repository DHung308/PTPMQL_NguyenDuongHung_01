using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenDuongHung_01.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSinhVien{ get; set; }
        public string?  HoTen { get; set; }
        public string?  Malop { get; set; }
        [ForeignKey("Malop")]
        public LopHoc? LopHoc { get; set; }
    }
}
