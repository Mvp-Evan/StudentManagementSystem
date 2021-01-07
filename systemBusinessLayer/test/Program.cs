using System;
using ClassManagementSystem.business;

namespace systemControlLyar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //selectTeacher(222);
            //addTeacher();
        }

        static void addTeacher()
        {
            TeacherBusiness teacherBusiness = new TeacherBusiness();
            teacherBusiness.AddTeacher(111, "YJX", "computer","root");
        }
        static void selectTeacher(int id)
        {
            TeacherBusiness teacherBusiness = new TeacherBusiness();
            teacherBusiness.SelectTeacher(id);
        }
    }
}