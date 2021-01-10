using System;
using ClassManagementSystem.business;
using ClassManagementSystem.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace systemDisplayLayer
{
    class Program
    {
        private static ITeacherBusiness itb = new ServiceCollection()
            .AddSingleton<ITeacherBusiness, TeacherBusiness>()
            .BuildServiceProvider()
            .GetService<ITeacherBusiness>();

        private static IStudentBusiness isb = new ServiceCollection()
            .AddSingleton<IStudentBusiness, StudentBusiness>()
            .BuildServiceProvider()
            .GetService<IStudentBusiness>();
        
        static void Main(string[] args)
        {
            Login();
        }

        // Teacher login and start Work() after login correctly
        static void Login()
        {
            int id;
            string idTry, passwd;
            bool loop = true;

            while (loop)
            {
                while (true)
                {
                    Console.WriteLine(
                        "////////////////////////////////////////////////////////////////////////////////////" + "\n" +
                        "/*                Welcome to Hebut Student Management System                      */" + "\n" +
                        "/*                                                                                */" + "\n" +
                        "/*                                                                                */" + "\n" +
                        "/*                             Please Enter Your ID                               */" + "\n" +
                        "/*                                                                                */" + "\n" +
                        "////////////////////////////////////////////////////////////////////////////////////" + "\n");
                    idTry = Console.ReadLine();
                    try
                    {
                        id = Int32.Parse(idTry);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a number !");
                        continue;
                        throw;
                    }
                }

                Console.WriteLine(
                    "////////////////////////////////////////////////////////////////////////////////////" + "\n" +
                    "/*                Welcome to Hebut Student Management System                      */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "/*                         Please Enter Your Password                             */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "////////////////////////////////////////////////////////////////////////////////////" + "\n");

                passwd = Console.ReadLine();

                loop = !itb.TeacherLogin(id, passwd);
                
                if (loop)
                {
                    Console.WriteLine("ID error or password error");
                }
                
            }
            Work();
        }

        // Display work choice select 
        static int SelectWork()
        {
            int choice = 0;
            string choiceTry;
            bool loop = true;
            
            while (loop)
            {
                Console.WriteLine(
                    "////////////////////////////////////////////////////////////////////////////////////" + "\n" +
                    "/*                Welcome to Hebut Student Management System                      */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "/*                             1. Create Student                                  */" + "\n" +
                    "/*                             2. Delete Student                                  */" + "\n" +
                    "/*                             3. Modify Student                                  */" + "\n" +
                    "/*                             4. Create Class                                    */" + "\n" +
                    "/*                             5. Delete Class                                    */" + "\n" +
                    "/*                             6. Modify Class                                    */" + "\n" +
                    "/*                             7. Add Student into Class                          */" + "\n" +
                    "/*                             8. Remove Student From Class                       */" + "\n" +
                    "/*                             9. Create Teacher Account                          */" + "\n" +
                    "/*                             10. Delete Teacher Account                         */" + "\n" +
                    "/*                             11. Exit                                           */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "/*                   Please Enter The Number of Your Choice                       */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "////////////////////////////////////////////////////////////////////////////////////" + "\n");
                choiceTry = Console.ReadLine();
                try
                {
                    choice = Int32.Parse(choiceTry);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("<--------------Please Enter Number !!!------------------>");
                    continue;
                    throw;
                }
            }

            return choice;
        }

        // Start work and use functions about work
        static void Work()
        {
            while (true)
            {
                int choice = SelectWork();
                if (choice == 1)
                {
                    CreateStudent();
                }
                else if (choice == 2)
                {
                    DeleteStudent();
                }
                else if (choice == 3)
                {
                    ModifyStudent();
                }
                else if (choice == 4)
                {
                    CreateClass();
                }
                else if (choice == 5)
                {
                    DeleteClass();
                }
                else if (choice == 6)
                {
                    ModifyClass();
                }
                else if (choice == 7)
                {
                    AddStudentIntoClass();
                }
                else if (choice == 8)
                {
                    RemoveStudentFromClass();
                }
                else if (choice == 9)
                {
                    CreateTeacherAccount();
                }
                else if (choice == 10)
                {
                    DeleteTeacherAccount();
                }
                else if (choice == 11)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The Number " + choice + " Task Is Not Exists, Please enter again !");
                }
            }
            Login();
        }

        static void CreateStudent()
        {
            int id;
            string idTry, name, subject, sex;

            while (true)
            {
                Console.WriteLine("Please Enter The New Student ID: ");
                idTry = Console.ReadLine();
                try
                {
                    id = Int32.Parse(idTry);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Enter An Int! ");
                    continue;
                    throw;
                }
            }

            Console.WriteLine("Please Enter The New Student Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter The New Student Subject: ");
            subject = Console.ReadLine();
            Console.WriteLine("Please Enter The New Student Sex: ");
            sex = Console.ReadLine();
            
            isb.CreateStudent(id, name, subject, sex);
        }

        static void DeleteStudent()
        {
            int id;
            string idTry;

            while (true)
            {
                Console.WriteLine("Please Enter Student ID: ");
                idTry = Console.ReadLine();

                try
                {
                    id = Int32.Parse(idTry);
                    if (isb.DeleteStudentById(id))
                    {
                        Console.WriteLine("Student " + id + " Delete Successful !");
                    }
                    else
                    {
                        Console.WriteLine("Delete Error, Student ID Is Not Exists! ");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Enter ID As Int type!");
                    continue;
                    throw;
                }
            }
        }

        static void ModifyStudent()
        {
            int choice, id;
            string choiceTry, idTry;
            while (true)
            {
                while (true)
                {
                    while (true)
                    {
                        Console.WriteLine("Please Enter Student ID: ");
                        idTry = Console.ReadLine();
                        try
                        {
                            id = Int32.Parse(idTry);
                            if (isb.StudentIsExists(id))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("This ID Is Not Exists! ");
                            }
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Please Enter A Number!");
                            continue;
                            throw;
                        }
                    }
                    Console.WriteLine(
                        "////////////////////////////////////////////////////////////////////////////////////" + "\n" +
                        "/*                                Modify Student                                  */" + "\n" +
                        "/*                                                                                */" + "\n" +
                        "/*                                                                                */" + "\n" +
                        "/*                              1. Change Student ID                              */" + "\n" +
                        "/*                              2. Change Student Name                            */" + "\n" +
                        "/*                              3. Change Student Subject                         */" + "\n" +
                        "/*                              4. Change Student Sex                             */" + "\n" +
                        "/*                              5. Change Student Class Belong                    */" + "\n" +
                        "/*                              6. Exit                                           */" + "\n" +
                        "/*                                                                                */" + "\n" +
                        "/*                             Please Enter The Number                            */" + "\n" +
                        "/*                                                                                */" + "\n" +
                        "////////////////////////////////////////////////////////////////////////////////////" + "\n");
                    choiceTry = Console.ReadLine();
                    try
                    {
                        choice = Int32.Parse(choiceTry);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please Enter A Number!");
                        continue;
                        throw;
                    }
                }

                if (choice == 1)
                {
                    int newId;
                    string newIdTry;
                    while (true)
                    {
                        Console.WriteLine("Please Enter New ID of Student: ");
                        newIdTry = Console.ReadLine();
                        try
                        {
                            newId = Int32.Parse(newIdTry);
                            isb.ChangeStudentId(id, newId);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("New ID Must Be A Number! ");
                            continue;
                            throw;
                        }
                    }
                }
                else if (choice == 2)
                {
                    string newName;
                    Console.WriteLine("PLease Enter The New Name For This Student: ");
                    newName = Console.ReadLine();
                    isb.ChangeStudentName(id, newName);
                    Console.WriteLine("Name Changed Successful! ");
                }
                else if (choice == 3)
                {
                    string newSubject;
                    Console.WriteLine("PLease Enter The New Subject: ");
                    newSubject = Console.ReadLine();
                    isb.ChangeStudentName(id, newSubject);
                    Console.WriteLine("Subject Changed Successful!");
                }
                else if (choice == 4)
                {
                    string newSex;
                    Console.WriteLine("Please Enter The New Sex: ");
                    newSex = Console.ReadLine();
                    isb.ChangeStudentSex(id, newSex);
                    Console.WriteLine("Sex Changed Successful!");
                }
                else if (choice == 5)
                {
                    int newClassId;
                    string newClassIdTry;
                    while (true)
                    {
                        Console.WriteLine("Please Enter New Class ID: ");
                        newClassIdTry = Console.ReadLine();
                        try
                        {
                            newClassId = Int32.Parse(newClassIdTry);
                            if (isb.AddStudentIntoClass(newClassId, id))
                            {
                                Console.WriteLine("Change Student Class Belong Successful!");
                            }
                            else
                            {
                                Console.WriteLine("Changed Error, New Class ID Is Not Exists! ");
                            }
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Class ID Must Be A Number!");
                            continue;
                            throw;
                        }
                    }
                }
                else if (choice == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("This Choice is Not Exists! ");
                }
            }
            Work();
        }
        
        static void CreateClass(){}
        
        static void DeleteClass(){}
        
        static void ModifyClass(){}

        static void AddStudentIntoClass()
        {
            int classId, studentId;
            string classIdTry, studentIdTry;
            
            while (true)
            {
                Console.WriteLine("Please Enter The Student ID: ");
                studentIdTry = Console.ReadLine();
                try
                {
                    studentId = Int32.Parse(studentIdTry);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Student ID Must Be Int! ");
                    continue;
                    throw;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Enter The Class ID: ");
                classIdTry = Console.ReadLine();
                try
                {
                    classId = Int32.Parse(classIdTry);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Class ID Must Be Int!");
                    continue;
                    throw;
                }
            }

            if (!isb.AddStudentIntoClass(classId, studentId))
            {
                Console.WriteLine("This Student Or Class Is Not Exists! ");
            }
            else
            {
                Console.WriteLine("Add Student " + studentId + " Into Class " + classId + " Successful!");
            }

        }

        static void RemoveStudentFromClass()
        {
            int id;
            string idtry;

            while (true)
            {
                Console.WriteLine("Please Enter Student ID: ");
                idtry = Console.ReadLine();

                try
                {
                    id = Int32.Parse(idtry);
                    if (isb.RemoveStudentFormClass(id))
                    {
                        Console.WriteLine("Remove Successful!");
                    }
                    else
                    {
                        Console.WriteLine("Remove Error, Student ID Is Not Exists Or Student Is Not In Any Class");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Enter Student ID As Int Type!");
                    continue;
                    throw;
                }
            }
        }

        static void CreateTeacherAccount()
        {
            int id;
            string idTry, name, passwd, major;

            while (true)
            {
                Console.WriteLine("Please Enter ID: ");
                idTry = Console.ReadLine();
                try
                {
                    id = Int32.Parse(idTry);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Enter ID As Int: ");
                    continue;
                    throw;
                }
            }

            Console.WriteLine("Please Enter Your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter Your Major: ");
            major = Console.ReadLine();
            Console.WriteLine("Please Enter Your Password: ");
            passwd = Console.ReadLine();
            
            itb.AddTeacher(id, name, major, passwd);
            Console.WriteLine("Create Teacher Account Successful!");
        }

        static void DeleteTeacherAccount()
        {
            int id;
            string idTry;

            while (true)
            {
                Console.WriteLine("Please Enter The ID Which You Want To Delete: ");
                idTry = Console.ReadLine();
                try
                {
                    id = Int32.Parse(idTry);
                    if (!itb.DeleteTeacherById(id))
                    {
                        Console.WriteLine("Delete Error, This ID Is Not Exists !");
                    }
                    else
                    {
                        Console.WriteLine("Delete Successful! ");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Enter a Number! ");
                    continue;
                    throw;
                }
            }

        }
    }
}