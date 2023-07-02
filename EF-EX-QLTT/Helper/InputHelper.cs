using EF_EX_QLTT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_QLTT.Helper
{
    public enum inputType
    {
        HoTen,NgaySinh,GioiTinh,Email, SDT, DiaChi,TrinhDo,NgayDK
    }
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
            if(!InputSTR(hv.SDT, 9, 15))
            {
                return false;
            }
            if(hv.NgaySinh == null || hv.GioiTinh == null)
            {
                return false;
            }
            return true;
        }
        public static int InputINT(string msg, string err)
        {
            bool check = true;
            int ret;
            do
            {
                Console.WriteLine(msg);
                check = int.TryParse(Console.ReadLine(), out ret);
                if (!check) Console.WriteLine(err);
            } while (!check);
            return ret;
        }
        public static string InputSTRING(string msg, string err, int minLength = 0, int maxLength = int.MaxValue)
        {
            bool check = true;
            string ret;
            do
            {
                Console.WriteLine(msg);
                ret = Console.ReadLine();
                check = ret.Length >= minLength && ret.Length <= maxLength;
                if (!check) Console.WriteLine(err);
            } while (!check);
            return ret;
        }
        public static DateTime InputDATETIME(string msg, string err, DateTime minDate, DateTime maxDate)
        {
            bool check = true;
            DateTime ret;
            do
            {
                Console.WriteLine(msg);
                check = DateTime.TryParse(Console.ReadLine(), out ret);
                check = check && ret >= minDate && ret <= maxDate;
                if (!check) Console.WriteLine(err);
            } while (!check);
            return ret;
        }
    }
}
