using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYUNGCUVIEN
{
    internal class LISTCANDIDATE : IFILE
    {
        private Dictionary<String, CANDIDATE> liststaff;
        public void READDATA()
        {
            String fileName = Environment.CurrentDirectory + "D:\\QUANLYUNGCUVIEN.txt";
            String[] AllLines = File.ReadAllLines(fileName);
            foreach (String line in AllLines)
            {
                string[] inforcandidate = line.Split(',');
                string StaffCode = inforcandidate[1];
                string Hoten = inforcandidate[2];
                DateTime NgaySinh = DateTime.Parse(inforcandidate[3]);
                string DiaChi = inforcandidate[4];
                string QueQuan = inforcandidate[5];
                string SoDienThoai = inforcandidate[6];
                string Email = inforcandidate[7];
                CANDIDATE candidate = null;
                if (inforcandidate[0] == "1")
                {
                    int SoNamKinhNghiem = Int16.Parse(inforcandidate[8]);
                    String KyNang = inforcandidate[9];
                    String NoiLamViec = inforcandidate[10];
                    candidate = new EXPERIENCE(StaffCode, Hoten, NgaySinh, DiaChi,
                   QueQuan,
                    SoDienThoai, Email, SoNamKinhNghiem, KyNang, NoiLamViec);
                }
                if (inforcandidate[0] == "2")
                {
                    int NamTotNghiep = Int16.Parse(inforcandidate[8]);
                    String Xeploai = inforcandidate[9];
                    String TruongtotNghiep = inforcandidate[10];
                    candidate = new FRESHER(StaffCode, Hoten, NgaySinh, DiaChi, QueQuan,
                    SoDienThoai, Email, NamTotNghiep, Xeploai, TruongtotNghiep);
                }
                if (inforcandidate[0] == "3")
                {
                    int NamDuKienTotNghiep = Int16.Parse(inforcandidate[8]);
                    String NganhHoc = inforcandidate[9];
                    String HocKy = inforcandidate[10];
                    String Truong = inforcandidate[11];
                    candidate = new INTERN(StaffCode, Hoten, NgaySinh, DiaChi, QueQuan,
                    SoDienThoai, Email, NamDuKienTotNghiep, NganhHoc, HocKy, Truong);
                }
                this.liststaff.Add(candidate.STAFFCODE, candidate);
            }
        }//end readdata
        public void WRITEDATA()
        {
            String fileName = Environment.CurrentDirectory +
           "D\\QUANLYUNGCUVIEN.txt";
            StreamWriter write = new StreamWriter(fileName);
            foreach (CANDIDATE candidate in this.liststaff.Values)
            {
                String infroCandidate = candidate.STAFFCODE + "," + candidate.HOTEN +
               ","
                + candidate.NGAYSINH + "," + candidate.DIACHI + "," +
               candidate.QUEQUAN + "," + candidate.SODIENTHOAI + ","
                + candidate.EMAIL;
                String infor = null;
                if (candidate is EXPERIENCE)
                {
                    EXPERIENCE exper = (EXPERIENCE)candidate;
                    infor = exper.SONAMKINHNGHIEM + "," + exper.KYNANG + "," +
                   exper.NOILAMVIEC;
                    infroCandidate = "1," + infroCandidate + "," + infor;
                }
                else if (candidate is FRESHER)
                {
                    FRESHER fresh = (FRESHER)candidate;
                    infor = fresh.NAMTOTNGHIEP + "," + fresh.XEPLOAI + "," +
                   fresh.TRUONGTOTNGHIEP;
                    infroCandidate = "2," + infroCandidate + "," + infor;
                }
                else if (candidate is INTERN)
                {
                    INTERN inter = (INTERN)candidate;
                    infor = inter.NAMDULIENTOTNGHIEP + "," + inter.NGANHHOC + "," +
                   inter.HOCKY + "," + inter.TRUONG;
                    infroCandidate = "3," + infroCandidate + "," + infor;
                }
                write.WriteLine(infroCandidate);
            }//end foreach
            write.Close();
        }//end writedata
        public LISTCANDIDATE()
        {
            liststaff = new Dictionary<string, CANDIDATE>();
        }
        public void Nhap()
        {
            char c = 'y';
            while (c == 'y')
            {
                Console.Write("Nhap ky tu 'E' EXPERIENCE 'F' FRESHER và 'I' INTERN");
                char type = Console.ReadLine().ToUpper().ToCharArray()[0];
                CANDIDATE candidate = null;
                switch (type)
                {
                    case 'E':
                        candidate = new EXPERIENCE();
                        break;
                    case 'F':
                        candidate = new FRESHER();
                        break;
                    case 'I':
                        candidate = new INTERN();
                        break;
                    default:
                        Console.Write("Nhap sai ky tu ");
                        break;
                }//end switch
                candidate.Nhap();
                this.liststaff.Add(candidate.STAFFCODE, candidate);
                Console.Write("Nhap ky tu 'y' de tiep tuc va phim bat ky de thoat:");
                c = Console.ReadLine().ToLower().ToCharArray()[0];
            }//end while
        }//end Nhap()
        public void Xuat()
        {
            foreach (CANDIDATE candidate in this.liststaff.Values)
                candidate.Xuat();
        }//end Xuat()
        public CANDIDATE Tim()
        {
            Console.Write("Nhap staffcode can tim:");
            String staffcode = Console.ReadLine();
            return this.liststaff[staffcode];
        }
        public void Xoa()
        {
            Console.Write("Nhap staffcode can xoa:");
            String staffcode = Console.ReadLine();
            this.liststaff.Remove(staffcode);
        }
        public void ThongKe()
        {
            int countEXPERIENCE = 0;
            int countFRESHER = 0;
            int countINTERN = 0;
            foreach (CANDIDATE candidate in liststaff.Values)
            {
                if (candidate is EXPERIENCE)
                    countEXPERIENCE++;
                else if (candidate is FRESHER)
                    countFRESHER++;
                else
                    countINTERN++;
            }
            Console.WriteLine("Tong so ung cu vien EXPERIENCE: {0}, FRESHER: {1}, INTERN: {2}", countEXPERIENCE, countFRESHER, countINTERN);
        }//end method ThongKe
    }//End Class

}
