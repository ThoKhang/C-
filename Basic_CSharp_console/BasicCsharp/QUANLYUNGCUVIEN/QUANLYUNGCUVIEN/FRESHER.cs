using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYUNGCUVIEN
{
    internal class FRESHER : CANDIDATE
    {
        private int NamTotNghiep;
        private String Xeploai;
        private String TruongtotNghiep;
        public int NAMTOTNGHIEP
        {
            set { this.NamTotNghiep = value; }
            get { return this.NamTotNghiep; }
        }
        public String XEPLOAI
        {
            set { this.Xeploai = value; }
            get { return this.Xeploai; }
        }
        public String TRUONGTOTNGHIEP
        {
            set { this.TruongtotNghiep = value; }
            get { return this.TruongtotNghiep; }
        }
        public FRESHER() : base() { }
        public FRESHER(string StaffCode, string Hoten, DateTime NgaySinh, string DiaChi,
        string QueQuan, string SoDienThoai, string Email, int NamTotNghiep, String Xeploai,
       String TruongtotNghiep)
        : base(StaffCode, Hoten, NgaySinh, DiaChi, QueQuan, SoDienThoai, Email)
        {
            this.NamTotNghiep = NamTotNghiep;
            this.Xeploai = Xeploai;
            this.TruongtotNghiep = TruongtotNghiep;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap thong tin FRESHER");
            Console.Write("Nhap nam tot nghiep:");
            this.NamTotNghiep = Int16.Parse(Console.ReadLine());
            Console.Write("Nhap xep loai");
            this.Xeploai = Console.ReadLine();
            Console.Write("Nhap truong tot nghiep");
            this.TruongtotNghiep = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Xuat thong tin EXPERIENCE");
            Console.WriteLine("Nam tot nghiep:{0}", this.NamTotNghiep);
            Console.WriteLine("Xep loai:{0}", this.Xeploai);
            Console.WriteLine("Truong tot nghiep:{0}", this.TruongtotNghiep);
        }
    }

}
