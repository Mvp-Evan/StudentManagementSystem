using System;
using ClassManagementSystem.business;
using ClassManagementSystem.Interface;
using dataAccessLayer.functionInterface;
using Microsoft.Extensions.DependencyInjection;

namespace systemDisplayLayer
{
    class Program
    {
        private static ITeacherBusiness itb = new ServiceCollection()
            .AddSingleton<ITeacherBusiness, TeacherBusiness>()
            .BuildServiceProvider()
            .GetService<ITeacherBusiness>();
        static void Main(string[] args)
        {
            Login();
        }

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

                loop =  ! itb.TeacherLogin(id, passwd);

                Console.WriteLine("ID error or password error");
            }
        }

    }
}