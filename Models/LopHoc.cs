using System.ComponentModel.DataAnnotations;

namespace NguyenDuongHung_01.Models
{
    public class LopHoc
    {
        [Key]
        public string  Malop { get; set; }
        public string TenLop { get; set; }
    }
}
