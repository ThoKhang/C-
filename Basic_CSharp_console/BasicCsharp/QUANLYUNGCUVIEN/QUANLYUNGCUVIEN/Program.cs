using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYUNGCUVIEN;

internal class Program
{
    static LISTCANDIDATE listCandidate;
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("CAC CHUC NANG MENU");
        Console.WriteLine("1. Chuc nang nhap ung cu vien.");//chon 1 nhap ung cu vien
    Console.WriteLine("2. Chuc nang xuat ung cu vien.");//chon 2 xuat ung cu vien
    Console.WriteLine("3. Tim ung cu vien.");//chon 3 tim ung cu vien
        Console.WriteLine("4. Xoa ung cu vien.");//chon 4 xoa ung cu vien
        Console.WriteLine("5. Thong ke.");//chon 5 thong ke
        Console.WriteLine("6. Doc tep file .");//chon 5 doc tep file va nap vao danh sach listSatff
    Console.WriteLine("7. Ghi vao tep file .");//chon 6 ghi danh sach ung cu vien vao tep file
    Console.Write("chon chuc nang menu 1-6: ");
        int menuitem = Convert.ToUInt16(Console.ReadLine());
        switch (menuitem)
        {
            case 1:
                listCandidate.Nhap();
                break;
            case 2:
                listCandidate.Xuat();
                break;
            case 3:
                listCandidate.Tim().Xuat();
                break;
            case 4:
                listCandidate.Xoa();
                break;
            case 5:
                listCandidate.ThongKe();
                break;
            case 6:
                listCandidate.WRITEDATA();
                break;
            case 7:
                listCandidate.READDATA();
                break;
        }
    }
       static void Main(string[] args)
        {

            try
            {
                listCandidate = new LISTCANDIDATE();
                char c = 'y';
                while (c == 'y')
                {
                    Menu();
                    Console.WriteLine("Nhap ky tu 'y' de tro ve menu");
                    c = Convert.ToChar(Console.ReadLine().ToLower());
                }
            }
            catch (Exception EX)
            { }
            finally
            { }
        }
    }
//end class program