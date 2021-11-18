using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanSu
{
    class NhanVien : PhuongThucNhap
    {
        string qualification;
        //nhập thông tin nhân viên
        public new void Accept(string id)
        {
            base.Accept(id);
            Console.Write("Nhập bằng cấp: ");
            this.qualification = Console.ReadLine();
            Console.WriteLine("Đã nhập xong");
        }
        //hiển thị thông tin nhân viên
        public new void Display()
        {
            Console.WriteLine("*****");
            base.Display();
            Console.WriteLine("Bằng cấp {0}", this.qualification);
            Console.WriteLine("*****");
        }

    }
}
