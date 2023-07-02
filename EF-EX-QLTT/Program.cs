
using EF_EX_QLTT.Helper;
using EF_EX_QLTT.IServices;
using EF_EX_QLTT.Services;
using EF_EX_QLTT.Entities;
using System.Threading.Channels;

IHocVienServices hocVienServices = new HocVienServices();
void MENU()
{
    Console.Clear();
    Console.WriteLine("====MENU====\n" +
        "1.Danh sach theo ngay dk gan nhat\n" +
        "2.Danh sach theo nam sinh 2002 va co chua ten An\n" +
        "3.Them moi 1 hoc vien\n" +
        "4.Cap nhat thong tin hoc vien\n" +
        "5.Xoa hoc vien\n" +
        "6.Thoat");
    char c = Console.ReadKey().KeyChar;
    Console.WriteLine();
    DoAction(c);
}
void DoAction(char c)
{
    switch (c)
    {
        case '1':
            hocVienServices.DSLopTheoNgayDK();
            break;
        case '2':
            hocVienServices.DSTheoNamSinhVaTen();
            break;
        case '3':
            hocVienServices.ThemHV(new HocVien(inputType.Them));
            break;
        case '4':
            Console.WriteLine("Nhap ID hoc vien muon cap nhat:");
            int hvID = int.Parse(Console.ReadLine());
            hocVienServices.CapNhatHV(hvID);
            break;
        case '5':
            Console.WriteLine("Nhap ID hoc vien muon xoa:");
            hvID = int.Parse(Console.ReadLine());
            hocVienServices.XoaHV(hvID);
            return;
        case '6':
            return;
    }
    Console.ReadKey();
    MENU();
}
void Main()
{
    MENU();
}
Main();
