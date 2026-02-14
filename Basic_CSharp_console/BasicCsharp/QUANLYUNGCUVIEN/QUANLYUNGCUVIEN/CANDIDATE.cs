using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYUNGCUVIEN
{
    internal class CANDIDATE
    { //begin class CANDIDATE
        protected string StaffCode;
        protected string Hoten;
        protected DateTime NgaySinh;
        protected string DiaChi;
        protected string QueQuan;
        protected string SoDienThoai;
        protected string Email;
        public String STAFFCODE
        {
            set { this.StaffCode = value; }
            get { return this.StaffCode; }
        }
        public String HOTEN
        {
            set { this.Hoten = value; }
            get { return this.Hoten; }
        }
        public DateTime NGAYSINH
        {
            set { this.NgaySinh = value; }
            get { return this.NgaySinh; }
        }
        public String DIACHI
        {
            set { this.DiaChi = value; }
            get { return this.DiaChi; }
        }
        public String QUEQUAN
        {
            set { this.QueQuan = value; }
            get { return this.QueQuan; }
        }
        public String SODIENTHOAI
        {
            set { this.SoDienThoai = value; }
            get { return this.SoDienThoai; }
        }
        public String EMAIL
        {
            set { this.Email = value; }
            get { return this.Email; }
        }
        public CANDIDATE() { }
        public CANDIDATE(string StaffCode, string Hoten, DateTime NgaySinh, string
       DiaChi,
        string QueQuan, string SoDienThoai, string Email)
        {

            this.StaffCode = StaffCode;
            this.Hoten = Hoten;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.QueQuan = QueQuan;
            this.SoDienThoai = SoDienThoai;
            this.Email = Email;
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap thong tin ung cu vien");
            Console.Write("Nhap ma ung cu vien:");
            this.StaffCode = Console.ReadLine();
            Console.Write("Nhap Ho Ten:");
            this.Hoten = Console.ReadLine(); ;
            Console.Write("Nhap Ngay Sinh:");
            this.NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap Dai Chi:");
            this.DiaChi = Console.ReadLine();
            Console.Write("Nhap Que Quan:");
            this.QueQuan = Console.ReadLine();
            Console.Write("Nhap So Dien Thoai:");
            this.SoDienThoai = Console.ReadLine();
            Console.Write("Nhap Email");
            this.Email = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Xuat thong tin ung cu vien");
            Console.WriteLine("Ma ung cu vien:{0}", this.StaffCode);
            Console.WriteLine("Ho Ten:{0}", this.Hoten);
            Console.WriteLine("Ngay Sinh:{0}",
           this.NgaySinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("Dai Chi:{0}", this.DiaChi);
            Console.WriteLine("Que Quan:{0}", this.QueQuan);
            Console.WriteLine("So Dien Thoai:{0}", this.SoDienThoai);
            Console.WriteLine("Email:{0}", this.Email);
        }
    } //End class CANDIDATE

}
