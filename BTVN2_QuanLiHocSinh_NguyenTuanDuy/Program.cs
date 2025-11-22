using System;
using System.Collections.Generic;

namespace BTVN2_QuanLiHocSinh_NguyenTuanDuy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "An", 16),
                new Student(2, "Binh", 17),
                new Student(3, "Hoa", 14),
                new Student(4, "Anh", 18),
                new Student(5, "Tu", 20)
            };

            QuanLiSinhVien ql = new QuanLiSinhVien(students);

    
            ql.InDanhSach();
            ql.TimTuoi15Den18();
            ql.TimTenBatDauA();
            ql.TongTuoi();
            ql.TimLonTuoiNhat();
            ql.SapXepTheoTuoi();

            Console.ReadLine();
        }
    }
}