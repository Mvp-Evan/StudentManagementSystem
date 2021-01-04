using System;

namespace systemControlLyar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create database");
            using (var db = new StudentContext())
            {
                db.Add(new StudentEntity
                {
                    id = 111,
                    name = "Evan",
                    passwd = "root",
                    sex = "male",
                    subject = "computer"
                });
                db.SaveChanges();
                Console.WriteLine("Creat finished");
            }
        }
    }
}