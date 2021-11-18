using System;

namespace QuanLyNhanSu
{
    class PhuongThucNhap
    {
        //khai báo thuộc tính
        string id, ten, gioitinh, ngaysinh;
        //phương thức nhập thông tin
        protected void Accept(string id)
        {
            this.id = id;
            Console.Write("Nhập tên:");
            this.ten = Console.ReadLine();
            Console.Write("Nhập giới tính:");
            this.gioitinh = Console.ReadLine();
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            this.ngaysinh = Console.ReadLine();
        }
        //phương thức hiển thị thông tin
        protected void Display()
        {
            Console.WriteLine("Mã: {0},", this.id);
            Console.WriteLine("Tên: {0},", this.ten);
            Console.WriteLine("Giới Tính: {0},", this.gioitinh);
            Console.WriteLine("Ngày Sinh: {0},", this.ngaysinh);


        }
    }
}