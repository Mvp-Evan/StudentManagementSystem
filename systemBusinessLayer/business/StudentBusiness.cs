using ClassManagementSystem.Interface;
using dataAccessLayer.entity;
using dataAccessLayer.functionInterface;
using Microsoft.Extensions.DependencyInjection;

namespace ClassManagementSystem.business
{
    public class StudentBusiness : IStudentBusiness
    {
        private IStudentFunctions isf = new ServiceCollection()
            .AddSingleton<IStudentFunctions, StudentFunctions>()
            .BuildServiceProvider()
            .GetService<IStudentFunctions>();

        private IClassFunctions icf = new ServiceCollection()
            .AddSingleton<IClassFunctions, ClassFunctions>()
            .BuildServiceProvider()
            .GetService<IClassFunctions>();
        
        public void CreateStudent(int id, string name, string subject, string sex)
        {
            StudentEntity student = new StudentEntity
            {
                id = id,
                name = name,
                subject = subject,
                sex = sex
            };
            isf.InsertStudent(student);
        }

        public bool DeleteStudentById(int id)
        {
            StudentEntity student = isf.SelectStudentById(id);
            
            if (student != null)
            {
                isf.DeleteStudentById(id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddStudentIntoClass(int classId, int studentId)
        {
            ClassEntity classEntity = icf.SelectClass(classId);
            StudentEntity student = isf.SelectStudentById(studentId);
            
            if (classEntity != null && student != null)
            {
                isf.DeleteStudentById(studentId);
                student.classId = classId;
                isf.InsertStudent(student);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveStudentFormClass(int id)
        {
            StudentEntity student = isf.SelectStudentById(id);
            if (student != null && student.classId != 0)
            {
                isf.DeleteStudentById(id);
                student.classId = 0;
                isf.InsertStudent(student);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeStudentId(int id, int newId)
        {
            StudentEntity student = isf.SelectStudentById(id);
            StudentEntity notExistStudent = isf.SelectStudentById(newId);
            
            if (student != null && notExistStudent == null)
            {
                isf.DeleteStudentById(id);
                student.id = newId;
                isf.InsertStudent(student);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}