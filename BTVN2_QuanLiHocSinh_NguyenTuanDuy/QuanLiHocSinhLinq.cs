using System;
using System.Collections.Generic;
using System.Linq;

namespace BTVN2_QuanLiHocSinh_NguyenTuanDuy
{
    public class QuanLiSinhVien
    {
        private List<Student> students;

        public QuanLiSinhVien(List<Student> students)
        {
            this.students = students;
        }

        
        public void NhapSinhVien()
        {
            Console.Write("\nNhập ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nhập Tên: ");
            string name = Console.ReadLine();

            Console.Write("Nhập Tuổi: ");
            int age = int.Parse(Console.ReadLine());

            students.Add(new Student(id, name, age));
            Console.WriteLine("→ Đã thêm sinh viên thành công!");
        }

       
        public void InDanhSach()
        {
            Console.WriteLine("\n--- Danh sách học sinh ---");
            students.ForEach(s => Console.WriteLine(s));
        }

       
        public void TimTuoi15Den18()
        {
            var result = students.Where(s => s.Age >= 15 && s.Age <= 18);

            Console.WriteLine("\n--- Học sinh tuổi từ 15 đến 18 ---");
            foreach (var s in result)
                Console.WriteLine(s);
        }

       
        public void TimTenBatDauA()
        {
            var result = students.Where(s => s.Name.StartsWith("A"));

            Console.WriteLine("\n--- Học sinh có tên bắt đầu bằng 'A' ---");
            foreach (var s in result)
                Console.WriteLine(s);
        }

       
        public void TongTuoi()
        {
            int total = students.Sum(s => s.Age);
            Console.WriteLine($"\nTổng tuổi các học sinh = {total}");
        }

       
        public void TimLonTuoiNhat()
        {
            int maxAge = students.Max(s => s.Age);
            var result = students.Where(s => s.Age == maxAge);

            Console.WriteLine("\n--- Học sinh lớn tuổi nhất ---");
            foreach (var s in result)
                Console.WriteLine(s);
        }

       
        public void SapXepTheoTuoi()
        {
            var result = students.OrderBy(s => s.Age);

            Console.WriteLine("\n--- Danh sách sắp xếp theo tuổi ---");
            foreach (var s in result)
                Console.WriteLine(s);
        }
    }
}
