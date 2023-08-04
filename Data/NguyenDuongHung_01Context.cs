using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenDuongHung_01.Models;

namespace NguyenDuongHung_01.Data
{
    public class NguyenDuongHung_01Context : DbContext
    {
        public NguyenDuongHung_01Context (DbContextOptions<NguyenDuongHung_01Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenDuongHung_01.Models.LopHoc> LopHoc { get; set; } = default!;

        public DbSet<NguyenDuongHung_01.Models.SinhVien> SinhVien { get; set; } = default!;
    }
}
