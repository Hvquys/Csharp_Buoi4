using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Buoi4
{
    struct HoaDon
    {
        public int maHoaDon;
        public DateTime ngayPhatHanh;
        public double soTien;
        public String nguoiMua;
        public DateTime ngayMua;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HoaDon> danhSachHoaDon = new List<HoaDon>();

            while (true)
            {
                Console.WriteLine("-------------------- Menu ---------------------");
                Console.WriteLine("1. Nhap hoa don.");
                Console.WriteLine("2. Xoa hoa don.");
                Console.WriteLine("3. Sua hoa don.");
                Console.WriteLine("4. Danh sach hoa don.");
                Console.WriteLine("5. Tim kiem theo ma hoa don.");
                Console.WriteLine("0. Thoat.");
                Console.WriteLine("-------------------- Menu ---------------------");
                Console.Write("Chon: ");
                int chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        danhSachHoaDon.AddRange(NhapHoaDon());
                        break;
                    case 2:
                        XoaHoaDon(danhSachHoaDon);
                        break;
                    case 3:
                        SuaHoaDon(danhSachHoaDon);
                        break;
                    case 4:
                        HienThiDanhSachHoaDon(danhSachHoaDon);
                        break;
                    case 5:
                        TimKiemHoaDonTheoMa(danhSachHoaDon);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }

            

        }

        public static DateTime StringToDate(string ngay)
        {
            DateTime result;
            DateTime.TryParseExact(ngay, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out result);
            return result;
        }

        public static List<HoaDon> NhapHoaDon()
        {
            List<HoaDon> danhSachHoaDon = new List<HoaDon>();
            Console.Write("Vui long chon so hoa don can nhap: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                HoaDon hoaDon = new HoaDon();

                Console.WriteLine("Hoa don {0}: ", (i+1));
                Console.Write("Ma hoa don: ");
                hoaDon.maHoaDon = int.Parse(Console.ReadLine());
                Console.Write("Ngay phat hanh (dd/MM/yyyy): ");
                string NgayPH = Console.ReadLine();
                hoaDon.ngayPhatHanh = StringToDate(NgayPH);
                Console.Write("So tien: ");
                hoaDon.soTien = double.Parse(Console.ReadLine());
                Console.Write("Nguoi mua: ");
                hoaDon.nguoiMua = Console.ReadLine();
                Console.Write("Ngay mua: ");
                String ngayMua = Console.ReadLine();
                hoaDon.ngayMua = StringToDate(ngayMua);

                danhSachHoaDon.Add(hoaDon);
            }
            return danhSachHoaDon;
        }

        public static void XoaHoaDon(List<HoaDon> danhSachHoaDon)
        {
            Console.Write("Nhap vao ma hoa don can xoa: ");
            int maHD = int.Parse(Console.ReadLine());
            HoaDon hoaDonCanXoa = danhSachHoaDon.Find(hd => hd.maHoaDon == maHD);
            danhSachHoaDon.Remove(hoaDonCanXoa);
        }

        public static void SuaHoaDon(List<HoaDon> danhSachHoaDon)
        {
            Console.Write("Nhap vao ma hoa don can sua: ");
            int maHD = int.Parse(Console.ReadLine());
            HoaDon hoaDonCanSua = danhSachHoaDon.Find(hd => hd.maHoaDon == maHD);
            Console.Write("Ngay phat hanh: ");
            String ngayPH = Console.ReadLine();
            hoaDonCanSua.ngayPhatHanh = StringToDate(ngayPH);
            Console.Write("So Tien: ");
            hoaDonCanSua.soTien = double.Parse(Console.ReadLine());
            Console.Write("Nguoi mua: ");
            hoaDonCanSua.nguoiMua = Console.ReadLine();
            Console.Write("Ngay Mua: ");
            String ngayMua = Console.ReadLine();
            hoaDonCanSua.ngayMua = StringToDate(ngayMua);
        }
        public static void HienThiDanhSachHoaDon(List<HoaDon> danhSachHoaDon)
        {
            Console.WriteLine("Danh sach hoa don: ");
            foreach (var item in danhSachHoaDon)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Hoa Don so: " +  item.maHoaDon);
                Console.WriteLine("Ngay phat hanh: " + item.ngayPhatHanh);
                Console.WriteLine("So tien: " + item.soTien);
                Console.WriteLine("Nguoi mua: " + item.nguoiMua);
                Console.WriteLine("Ngay mua: " + item.ngayMua);
            }
        }

        public static void TimKiemHoaDonTheoMa(List<HoaDon> danhSachHoaDon)
        {
            Console.Write("Nhap vao ma so hoa don: ");
            int maHD = int.Parse(Console.ReadLine());
            HoaDon hoaDonCanTim = danhSachHoaDon.Find(hd => hd.maHoaDon == maHD);
            Console.WriteLine("Hoa don {0} can tim: ", hoaDonCanTim.maHoaDon);
            Console.WriteLine("Ngay phat hanh: " + hoaDonCanTim.ngayPhatHanh);
            Console.WriteLine("So tien: " + hoaDonCanTim.soTien);
            Console.WriteLine("Nguoi mua: " + hoaDonCanTim.nguoiMua);
            Console.WriteLine("Ngay mua: " + hoaDonCanTim.ngayMua);
        }

    }
}
