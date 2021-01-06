namespace systemControlLyar.functionInterface
{
    public interface IStudentFunctions
    {
        bool InsertStudent(StudentEntity student);
        StudentEntity SelectStudentById(int id);
        bool DeleteStudentById(int id);
        bool StudentLogin(int id, string passwd);
    }
}