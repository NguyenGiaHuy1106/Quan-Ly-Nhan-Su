using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanSu
{
    class HienThi
    {
        static void Main(string[] args)
        {
            //hiển thị tiếng việt
            Console.OutputEncoding = Encoding.UTF8;
            string option;
            //danh sách nhân viên
            List<NhanVien> empLst = new List<NhanVien>();
            //danh sách khách hàng 
            List<KhachHang> cusLst = new List<KhachHang>();
            //mã
            int cusID = 0, empID = 0;

            do
            {
                //hiển thị tính năng của chương trình 
                Console.WriteLine("------Quản lý nhân sự trong công ty------");
                Console.WriteLine("Thêm khách hàng (nhập: ac)");
                Console.WriteLine("Thêm nhân viên (nhập: ae)");
                Console.WriteLine("Hiển thị thông tin nhân viên (nhập: dae)");
                Console.WriteLine("Hiển thị thông tin  khách hàng (nhập: dac)");
                Console.WriteLine("Thông kê khách hàng (nhập: cs)");
                Console.WriteLine("Thoát chương trình (nhập: ea)");
                Console.WriteLine("Chọn tính năng: ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "ac":
                        KhachHang customer = new KhachHang();
                        cusID++;
                        customer.Accept("c" + cusID);
                        cusLst.Add(customer);
                        break;
                    case "ae":
                        NhanVien employee = new NhanVien();
                        empID++;
                        employee.Accept("e" + empID);
                        empLst.Add(employee);
                        break;
                    case "dae":
                        foreach (NhanVien emp in empLst)
                        {
                            emp.Display();
                        }
                        break;

                    case "dac":
                        foreach (KhachHang cus in cusLst)
                        {
                            cus.Display();
                        }
                        break;
                    case "cs":
                        int vipCnt = 0, newCnt = 0, normalCnt = 0;
                        foreach (KhachHang cus in cusLst)
                        {
                            switch (cus.type)
                            {
                                case "vip":
                                    vipCnt++;
                                    break;
                                case "new":
                                    newCnt++;
                                    break;
                                case "normal":
                                    normalCnt++;
                                    break;

                            }
                        }
                        Console.WriteLine("Khách hàng vip: {0}", vipCnt);
                        Console.WriteLine("Khách hàng new: {0}", newCnt);
                        Console.WriteLine("Khách hàng normal: {0}", normalCnt);
                        break;
                }
            } while (!option.Equals("ea"));
        }
    }
}