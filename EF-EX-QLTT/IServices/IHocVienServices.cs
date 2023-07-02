using EF_EX_QLTT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_QLTT.IServices
{
    public interface IHocVienServices 
    {
        //Hiển thị danh sách học viên theo thứ tự ngày đăng ký mới nhất từ trên xuống dưới
        void DSLopTheoNgayDK();
        //Hiển thị danh sách những học viên sinh năm 2002 và có tên chứa "An"
        void DSTheoNamSinhVaTen();
        //Thêm mới 1 học viên
        void ThemHV(HocVien hv);
        //Cập nhật thông tin học viên
        void CapNhatHV(int hvID);
        //Xóa học viên
        void XoaHV(int hvID);
    }
}
