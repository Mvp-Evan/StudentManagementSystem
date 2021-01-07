using System;
using ClassManagementSystem.Interface;
using dataAccessLayer.entity;
using dataAccessLayer.functionInterface;
using Microsoft.Extensions.DependencyInjection;

namespace ClassManagementSystem.business
{
    public class TeacherBusiness : ITeacherBusiness
    {
        private ITeacherFunctions itf = new ServiceCollection()
            .AddSingleton<ITeacherFunctions, TeacherFunctions>()
            .BuildServiceProvider()
            .GetService<ITeacherFunctions>();
        
        public void AddTeacher(int id, string name, string major, string passwd)
        {
            TeacherEntity teacher = new TeacherEntity
            {
                id = id,
                name = name,
                major = major,
                passwd = passwd
            };
            itf.InsertTeacher(teacher);
        }

        public bool TeacherLogin(int id, string passwd)
        {
            return itf.TeacherLogin(id, passwd);
        }

        public void SelectTeacher(int id)
        {
            TeacherEntity teacher = itf.SelectTeacherById(id);
            Console.WriteLine(teacher.ToString());
        }
    }
}