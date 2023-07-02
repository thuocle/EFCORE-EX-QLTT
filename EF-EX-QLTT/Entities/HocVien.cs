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
        public HocVien(inputType it)
        {
            if(it == inputType.Them)
            {
                LopID = InputHelper.InputINT(Res.InLop, Res.ErrBatBuocHopLe);
                NhapHV();
            }
        }
        public HocVien()
        {
            
        }
        public void NhapHV()
        {

            HoTen = InputHelper.InputSTRING(Res.inputHoten, Res.ErrHoten, 6, 50);
            NgaySinh = InputHelper.InputDATETIME(Res.InNgsinh, Res.ErrBatBuocHopLe, new DateTime(1990, 1, 1), new DateTime(2010, 1, 1));
            GioiTinh = InputHelper.InputSTRING(Res.InGT, Res.ErrBatBuocHopLe,2, 10);
            Email  = InputHelper.InputSTRING(Res.InEmail, Res.ErrEmail, 10, 100);
            SDT  = InputHelper.InputSTRING(Res.InSDT, Res.ErrSDT, 9, 15);
            DiaChi = InputHelper.InputSTRING(Res.InDC, Res.ErrBatBuocHopLe, 10, 100);
            TrinhDo = InputHelper.InputSTRING(Res.InTrinhDo, Res.ErrBatBuocHopLe, 1, 50);
            NgayDK = InputHelper.InputDATETIME(Res.InDK, Res.ErrBatBuocHopLe,new DateTime(2022, 5, 1), new DateTime(2023, 7, 1));

        }
        public void HienThi()
        {
            Console.WriteLine($"{HocVienID} - {HoTen} - {NgaySinh} - {GioiTinh} - {Email} - {SDT} - {DiaChi} - {TrinhDo} - Lop: {LopID} - NgayDK {NgayDK}");
        }
    }
    
}

