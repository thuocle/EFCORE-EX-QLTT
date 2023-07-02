using EF_EX_QLTT.Entities;
using EF_EX_QLTT.IServices;
using EF_EX_QLTT.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_EX_QLTT.Services
{
    public class HocVienServices : IHocVienServices
    {
        public readonly AppDbConText dbConText;
        public HocVienServices()
        {
            this.dbConText = new AppDbConText();
        }
        public void DSLopTheoNgayDK()
        {
            dbConText.HocVien.OrderBy(x => x.NgayDK).ToList().ForEach(x => x.HienThi());
        }

        public void DSTheoNamSinhVaTen()
        {
            dbConText.HocVien.Where(x => x.NgaySinh.Year == 2000 && x.HoTen.Contains("An")).ToList().ForEach(x => x.HienThi());
            
        }

        public void ThemHV(HocVien hv, int lopID)
        {
            if (!InputHelper.KiemTra(hv))
            {
                Console.WriteLine(Res.ThatBai);
            }
            var hvNow = dbConText.HocVien.FirstOrDefault(v => v.HocVienID == hv.HocVienID);
            var lopNow = dbConText.Lop.FirstOrDefault(v => v.LopID == lopID);
            if(hvNow == null )
            {
               if (lopNow == null)
                {
                    Console.WriteLine("Lop" + Res.ChuaTonTai);
                    Console.WriteLine(Res.ThatBai);
                }
                else
                {
                    dbConText.Add(hv);
                    dbConText.SaveChanges();
                    Console.WriteLine(Res.ThanhCong);
                }
            }
            else
            {
                Console.WriteLine("Hoc vien" + Res.TrungMa);
                Console.WriteLine(Res.ThatBai);
            }
        }
    }
}
