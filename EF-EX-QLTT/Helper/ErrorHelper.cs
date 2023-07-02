using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_QLTT.Helper
{
    public enum errType
    {
        ThanhCong, ThatBai, TrungMa, ChuaTonTai, DanhSachTrong
    }
    public class ErrorHelper
    {
        public static void Log(errType et)
        {
            switch (et) { 
            case errType.ThanhCong:
                    Console.WriteLine(Res.ThanhCong);
                    break;
            case errType.ThatBai:
                    Console.WriteLine(Res.ThatBai);
                    break;
            case errType.TrungMa:
                    Console.WriteLine(Res.TrungMa);
                    break;
            case errType.ChuaTonTai:
                    Console.WriteLine(Res.ChuaTonTai);
                    break;
            case errType.DanhSachTrong:
                    Console.WriteLine(Res.DanhSachTrong);
                    break;
            }
        }
    }
}
