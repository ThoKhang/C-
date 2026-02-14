using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYUNGCUVIEN
{
    internal class EXPERIENCE : CANDIDATE
    {
        private int SoNamKinhNghiem;
        private String KyNang;
        private String NoiLamViec;
        public int SONAMKINHNGHIEM
        {
            set { this.SoNamKinhNghiem = value; }
            get { return this.SoNamKinhNghiem; }
        }
        public String KYNANG
        {
            set { this.KyNang = value; }
            get { return this.KyNang; }
        }
        public String NOILAMVIEC
        {
            set { this.NoiLamViec = value; }
            get { return this.NoiLamViec; }
        }
        public EXPERIENCE() : base() { }
        public EXPERIENCE(string StaffCode, string Hoten, DateTime NgaySinh, string
       DiaChi,
        string QueQuan, string SoDienThoai, string Email, int SoNamKinhNghiem, String
       KyNang, String NoiLamViec)
        : base(StaffCode, Hoten, NgaySinh, DiaChi, QueQuan, SoDienThoai, Email)
        {
            this.SoNamKinhNghiem = SoNamKinhNghiem;
            this.KyNang = KyNang;
            this.NoiLamViec = NoiLamViec;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap thong tin EXPERIENCE");
            Console.Write("Nhap so nam kinh nghiem");
            this.SoNamKinhNghiem = Int16.Parse(Console.ReadLine());
            Console.Write("Nhap so ky nang");
            this.KyNang = Console.ReadLine();
            Console.Write("Nhap noi lam viec");
            this.NoiLamViec = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Xuat thong tin EXPERIENCE");
            Console.WriteLine("So nam kinh nghiem:{0}", this.SoNamKinhNghiem);
            Console.WriteLine("Ky nang:{0}", this.KyNang);
            Console.WriteLine("Noi lam viec:{0}", this.NoiLamViec);
        }
    }

}
