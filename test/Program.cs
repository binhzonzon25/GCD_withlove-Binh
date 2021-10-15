using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*NHAP VAO TU CHUONG TRINH *");
            Console.Write("Campus:");
                string campus = Console.ReadLine();

            Console.Write("Address:");
                string add = Console.ReadLine();

            Console.WriteLine("-----------------------");
            Console.Write("Nhap vao cac thong tin sau: ");
            Console.Write("Fullname: ");
                string fullname = Console.ReadLine();

            Console.Write("Birthday: ");
                string birthday = Console.ReadLine();

            Console.Write("Age: ");
                string age = Console.ReadLine();

            Console.Write("Email: ");
                string email = Console.ReadLine();

            Console.Write("Boyfriend/Girl: ");
                string bg = Console.ReadLine();

            Console.WriteLine("--------------------------");
    
            Console.WriteLine("*IN RA TU CHUONG TRINH *");
            Console.WriteLine("University of Greenwich               Campus: ",campus);
            Console.WriteLine("Address: ",add);
            Console.WriteLine("-----------------------");
            Console.WriteLine("*Nhap vao cac thong tin sau*");
            Console.WriteLine("Fullname: ",fullname);
            Console.WriteLine("Birthday: ", birthday);
            Console.WriteLine("Age: ",age);
            Console.WriteLine("Email: ",email);
            Console.WriteLine("Boyfriend/Girl: ",bg);
            Console.WriteLine("--------------------------");
            Console.ReadLine();

        }
    }
}
