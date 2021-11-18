using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanSu
{
    class KhachHang : PhuongThucNhap
    {
        public string type;

        //nhập thông tin khách hàng 
        public new void Accept(string id)
        {
            base.Accept(id);
            Console.Write("Nhập loại khách hàng (vip, new, normal): ");
            this.type = Console.ReadLine();
            Console.WriteLine("Đã nhập xong");
        }
        //hiển thị thông tin khách hàng
        public new void Display()
        {
            Console.WriteLine("*****");
            base.Display();
            Console.WriteLine("Loại khách hàng {0}", this.type);
            Console.WriteLine("*****");
        }
    }
}