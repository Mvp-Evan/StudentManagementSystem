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
            TeacherEntity teacher = itf.SelectTeacherById(id);

            if (teacher != null)
            {
                if (teacher.passwd == passwd)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string SelectTeacher(int id)
        {
            TeacherEntity teacher = itf.SelectTeacherById(id);
            return teacher.ToString();
        }

        public bool DeleteTeacherById(int id)
        {
            TeacherEntity teacher = itf.SelectTeacherById(id);
            if (teacher != null)
            {
                itf.DeleteTeacherById(id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}