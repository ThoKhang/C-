using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYUNGCUVIEN
{
    internal class INTERN : CANDIDATE
    {
        private int NamDuKienTotNghiep;
        private String NganhHoc;
        private String HocKy;
        private String Truong;
        public int NAMDULIENTOTNGHIEP
        {
            set { this.NamDuKienTotNghiep = value; }
            get { return this.NamDuKienTotNghiep; }
        }
        public String NGANHHOC
        {
            set { this.NganhHoc = value; }
            get { return this.NganhHoc; }
        }
        public String HOCKY
        {
            set { this.HocKy = value; }
            get { return this.HocKy; }
        }
        public String TRUONG
        {
            set { this.Truong = value; }
            get { return this.Truong; }
        }
        public INTERN() : base() { }
        public INTERN(string StaffCode, string Hoten, DateTime NgaySinh, string
       DiaChi,
        string QueQuan, string SoDienThoai, string Email, int NamDuKienTotNghiep,
        String NganhHoc, String HocKy, String Truong)
        : base(StaffCode, Hoten, NgaySinh, DiaChi, QueQuan, SoDienThoai, Email)
        {
            this.NamDuKienTotNghiep = NamDuKienTotNghiep;
            this.NganhHoc = NganhHoc;
            this.HocKy = HocKy;
            this.Truong = Truong;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap thong tin intern");
            Console.Write("Nhap nam du kien tot nghiep:");
            this.NamDuKienTotNghiep = Int16.Parse(Console.ReadLine());
            Console.Write("Nhap nganh hoc:");
            this.NganhHoc = Console.ReadLine(); ;
            Console.Write("Nhap hoc ky:");
            this.HocKy = Console.ReadLine();
            Console.Write("Nhap truong :");
            this.Truong = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Xuat thong tin intern");
            Console.WriteLine("Nam du kien tot nghiep:{0}", this.NamDuKienTotNghiep);
            Console.WriteLine("Nganh hoc:{0}", this.NganhHoc);
            Console.WriteLine("Hoc ky:{0}", this.HocKy);
            Console.WriteLine("Truong :{0}", this.Truong);

        }
    }
}
