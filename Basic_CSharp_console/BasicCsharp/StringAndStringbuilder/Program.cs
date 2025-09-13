using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        int year = 2005;
                        string sex = "male";
                        //phép nối chuỗi
                        Console.WriteLine("Please enter a greeting: ");
                        string greetings = Console.ReadLine();
                        Console.WriteLine("Please enter your full name: ");
                        string fullName = Console.ReadLine();
                        string newString = greetings + " " + fullName;
                        Console.WriteLine(newString);
                        Console.WriteLine("\\ \' \"");
                        Console.WriteLine(@"Xin chao     2025

                        Csharp
                    ");
                        Console.WriteLine($"hello {fullName}");
                        Console.WriteLine($"hello {fullName, 10} hello ");
                        //Có thể dùng @ hoặc $ cùng một lúc 
                        Console.WriteLine(
                            $@" 
                            full name: {fullName,3}
                            year of birth: {year,3}
                            sex: {sex,3}    
                        ");
             */
            string Notification = "hello everyone, my full name is Tran Van Tho Khang !";
            int theLength = Notification.Length;
            char c = Notification[4];
            Console.WriteLine(Notification);//xuất dữ liệu string
            Console.WriteLine(theLength);// Xuất độ dài string
            Console.WriteLine(c);// Xuất vị trí ký tự của string
            foreach (char count in Notification)
            {
                Console.WriteLine(count);
            }
        }
    }
}
