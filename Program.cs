// Thành viên 1: Nguyễn Thanh nam - 31241024675
// Menu chính
using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Quản Lý Thư Viện ===");
            Console.WriteLine("1. Quản Lý Sách");
            Console.WriteLine("2. Quản Lý Thành Viên");
            Console.WriteLine("3. Quản Lý Mượn Trả Sách");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn một tùy chọn (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BookManagementMenu.Show();
                    break;
                case "2":
                    MemberManagementMenu.Show();
                    break;
                case "3":
                    BorrowReturnManagementMenu.Show();
                    break;
                case "4":
                    Console.WriteLine("Thoát chương trình...");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}