using System.Linq;

namespace systemControlLyar.functionInterface
{
    public class StudentFunctions : IStudentFunctions
    {
        public bool InsertStudent(StudentEntity student)
        {
            using (var db = new EntityContext())
            {
                db.Add(student);
                db.SaveChanges();
            }

            return true;
        }

        public StudentEntity SelectStudentById(int id)
        {
            StudentEntity student;
            using (var db = new EntityContext())
            {
                student = db.students.Find(id);
            }

            return student;
        }
        
        public bool DeleteStudentById(int id)
        {
            using (var db = new EntityContext())
            {
                StudentEntity student = db.students.Find(id);
                db.Remove(student);
                db.SaveChanges();
            }

            return true;
        }

        public bool StudentLogin(int id, string passwd)
        {
            StudentEntity student = SelectStudentById(id);
            if (student.passwd == passwd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}