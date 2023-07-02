using EF_EX_QLTT.Entities;
using EF_EX_QLTT.IServices;
using EF_EX_QLTT.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

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
            if(dbConText.HocVien.Count() == 0)
            {
                Console.WriteLine(Res.DanhSachTrong);
                Console.ReadKey();
                return;
            }
            var lstHV = dbConText.HocVien.OrderBy(x => x.NgayDK);
                if(lstHV.Count() == 0 )
            {
                Console.WriteLine(Res.DanhSachTrong);
                Console.ReadKey();
                return;
            }
            else
            {
                lstHV.ToList().ForEach(x => x.HienThi());
            }
        }

        public void DSTheoNamSinhVaTen()
        {
            if (dbConText.HocVien.Count() == 0)
            {
                Console.WriteLine(Res.DanhSachTrong);
                Console.ReadKey();
                return;
            }
            var lstHV = dbConText.HocVien.Where(x => x.NgaySinh.Year == 2000 && x.HoTen.Contains("An"));
                if(lstHV.Count() == 0)
            {
                Console.WriteLine(Res.DanhSachTrong);
                Console.ReadKey();
                return;
            }
            else
            {
                lstHV.ToList().ForEach(x => x.HienThi());
            }
        }

        public void ThemHV(HocVien hv)
        {

            if (!InputHelper.KiemTra(hv))
            {
                Console.WriteLine(Res.ThatBai);
                return;
            }
            var hvNow = dbConText.HocVien.FirstOrDefault(v => v.HocVienID == hv.HocVienID);
            var lopNow = dbConText.Lop.FirstOrDefault(v => v.LopID == hv.LopID);
            if(hvNow == null )
            {
               if (lopNow == null)
                {
                    Console.WriteLine("Lop" + Res.ChuaTonTai);
                    Console.WriteLine(Res.ThatBai);
                    return;
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
                return;
            }
        }
        public void CapNhatHV(int hvID)
        {
            if (dbConText.HocVien.Count() == null)
            {
                Console.WriteLine(Res.DanhSachTrong);
                return;
            }
            var hvNow = dbConText.HocVien.FirstOrDefault(v => v.HocVienID == hvID);
            if (hvNow != null)
            {
                hvNow.NhapHV();
                if (!InputHelper.KiemTra(hvNow))
                {
                    Console.WriteLine(Res.ThatBai);
                    return;
                }
                dbConText.Update(hvNow);
                dbConText.SaveChanges();
                Console.WriteLine(Res.ThanhCong);
            }
            else
            {
                Console.WriteLine("Hoc vien" + Res.ChuaTonTai);
                Console.WriteLine(Res.ThatBai);
                return;
            }
        }
        public void XoaHV(int hvID)
        {
            if (dbConText.HocVien.Count() == null)
            {
                Console.WriteLine(Res.DanhSachTrong);
                return;
            }
            var hvNow = dbConText.HocVien.FirstOrDefault(v => v.HocVienID == hvID);
            if (hvNow != null)
            {
                dbConText.Remove(hvNow);
                dbConText.SaveChanges();
                Console.WriteLine(Res.ThanhCong);
            }
            else
            {
                Console.WriteLine("Hoc vien" + Res.ChuaTonTai);
                Console.WriteLine(Res.ThatBai);
                return;
            }
        }
    }
}
