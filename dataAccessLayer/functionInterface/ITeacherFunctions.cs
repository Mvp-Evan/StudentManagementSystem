using dataAccessLayer.entity;

namespace dataAccessLayer.functionInterface
{
    public interface ITeacherFunctions
    {
        bool InsertTeacher(TeacherEntity student);
        TeacherEntity SelectTeacherById(int id);
        bool DeleteTeacherById(int id);
        bool TeacherLogin(int id, string passwd);
    }
}