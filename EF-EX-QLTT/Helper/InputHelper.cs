using EF_EX_QLTT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_QLTT.Helper
{

    public class InputHelper
    {
        public static bool InputSTR(string STR, int minLenght, int maxLength)
        {
            return STR.Length > minLenght && STR.Length < maxLength;
        }
        public static bool KiemTra(HocVien hv)
        {
            if(!InputSTR(hv.HoTen, 6, 50))
            {
                return false;
            }
            if(!InputSTR(hv.Email, 10, 100))
            {
                return false;
            }
            if(!InputSTR(hv.SDT, 10, 15))
            {
                return false;
            }
            if(hv.NgaySinh == null || hv.GioiTinh == null)
            {
                return false;
            }
            return true;
        }
    }
}
