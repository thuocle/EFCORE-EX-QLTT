using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_QLTT.Entities
{
    public class HocVien
    {
        public int HocVienID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string TrinhDo { get; set; }
        public int LopID { get; set; }
        public Lop Lop { get; set; }
        public DateTime NgayDK { get; set; }
        public HocVien()
        {
        }
        public void HienThi()
        {
            Console.WriteLine($"{HocVienID} - {HoTen} - {NgaySinh} - {GioiTinh} - {Email} - {SDT} - {DiaChi} - {TrinhDo} - Lop: {LopID} - NgayDK {NgayDK}");
        }
    }
}
