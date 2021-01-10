using ClassManagementSystem.Interface;
using dataAccessLayer.entity;
using dataAccessLayer.functionInterface;
using Microsoft.Extensions.DependencyInjection;

namespace ClassManagementSystem.business
{
    public class ClassBusiness : IClassBusiness
    {
        private IClassFunctions icf = new ServiceCollection()
            .AddSingleton<IClassFunctions, ClassFunctions>()
            .BuildServiceProvider()
            .GetService<IClassFunctions>();

        public bool ClassIsExists(int id)
        {
            ClassEntity classEntity = icf.SelectClass(id);
            return classEntity != null;
        }

        public void CreateClass(int id, string name)
        {
            ClassEntity classEntity = new ClassEntity
            {
                id = id,
                name = name
            };
            icf.AddClass(classEntity);
        }

        public void DeleteClass(int id)
        {
            icf.DeleteClassById(id);
        }

        public bool ChangeClassId(int id, int newId)
        {
            if (ClassIsExists(id) && !ClassIsExists(newId))
            {
                ClassEntity classEntity = icf.SelectClass(id);
                icf.DeleteClassById(id);
                classEntity.id = newId;
                icf.AddClass(classEntity);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ChangeClassName(int id, string newName)
        {
            ClassEntity classEntity = icf.SelectClass(id);
            icf.DeleteClassById(id);
            classEntity.name = newName;
            icf.AddClass(classEntity);
        }

        public void ChangeClassTeacherBelong(int id, int newTeacherId)
        {
            ClassEntity classEntity = icf.SelectClass(id);
            icf.DeleteClassById(id);
            classEntity.teacherId = newTeacherId;
            icf.AddClass(classEntity);
        }
    }
}