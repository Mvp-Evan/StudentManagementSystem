using System;
using dataAccessLayer.entity;
using dataAccessLayer.functionInterface;

namespace dataAccessLayer.test
{
    class ControlLayerTest
    {
        static void Main(string[] args)
        {
            //insertTest();
            //insertStudent();
            selectStudent(111);
            //studentLogin();
            //addClass();
        }
        static void insertTest()
        {
            Console.WriteLine("insert student");
            using (var db = new EntityContext())
            {
                db.Add(new StudentEntity
                {
                    id = 111,
                    name = "Evan",
                    passwd = "root",
                    sex = "male",
                    subject = "computer",
                    classId = 111
                });
                db.SaveChanges();
            }
            Console.WriteLine("insert teacher");
            using (var db = new EntityContext())
            {
                db.Add(new TeacherEntity()
                {
                    id = 222,
                    name = "Evan",
                    passwd = "root",
                    major = "computer"
                });
                db.SaveChanges();
            }
            Console.WriteLine("insert class");
            using (var db = new EntityContext())
            {
                db.Add(new ClassEntity
                {
                    id = 111,
                    name = "SinoFranComput181",
                    teacherId = 111
                });
                db.SaveChanges();
            }
        }

        static void insertStudent()
        {
            using (var db = new EntityContext())
            {
                db.Add(new StudentEntity
                {
                    id = 222,
                    name = "Jhon",
                    passwd = "111",
                    sex = "male",
                    subject = "computer",
                    classId = 111
                });
                db.SaveChanges();
            }
        }

        static void selectStudent(int id)
        {
            IStudentFunctions isf = new StudentFunctions();
            Console.WriteLine(isf.SelectStudentById(id).name);
        }

        static void studentLogin()
        {
            IStudentFunctions isf = new StudentFunctions();
            Console.WriteLine(isf.StudentLogin(111, "root"));
        }

        static void addClass()
        {
            ClassEntity classEntity = new ClassEntity
            {
                id = 222,
                name = "SinoFranComput182",
                teacherId = 111
            };
            IClassFunctions icf = new ClassFunctions();
            icf.AddClass(classEntity);
        }
    }
}