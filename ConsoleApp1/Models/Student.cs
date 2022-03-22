using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int  Point { get; set; }

        public Student(string fullname,int  point)
        {
            this.FullName = fullname;
            this.Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"ID:{Id}");
            Console.WriteLine($"FullName{FullName}");
            Console.WriteLine($"Point:{Point}");
        }
    }
}