using EF_EX_QLTT.Helper;

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
            Console.WriteLine("");
            LopID = InputHelper.InputINT(Res.InLop, Res.ErrBatBuocHopLe);
            NhapHV();
        }
        public void NhapHV()
        {

            Console.WriteLine("");
            HoTen = InputHelper.InputSTRING(Res.inputHoten, Res.ErrHoten, 6, 50);
            NgaySinh = InputHelper.InputDATETIME(Res.InDK, Res.ErrBatBuocHopLe, new DateTime(1990, 1, 1), DateTime.Now);
            GioiTinh = InputHelper.InputSTRING(Res.InGT, Res.ErrBatBuocHopLe,2, 10);
            Email  = InputHelper.InputSTRING(Res.inputHoten, Res.ErrHoten, 10, 100);
            SDT  = InputHelper.InputSTRING(Res.inputHoten, Res.ErrHoten, 9, 15);
            TrinhDo = InputHelper.InputSTRING(Res.inputHoten, Res.ErrHoten, 1, 50);
            NgayDK = InputHelper.InputDATETIME(Res.InDK, Res.ErrBatBuocHopLe,new DateTime(2022, 5, 1), DateTime.Now);

        }
        public void HienThi()
        {
            Console.WriteLine($"{HocVienID} - {HoTen} - {NgaySinh} - {GioiTinh} - {Email} - {SDT} - {DiaChi} - {TrinhDo} - Lop: {LopID} - NgayDK {NgayDK}");
        }
    }
    
}

