using System;
using ClassManagementSystem.business;
using ClassManagementSystem.Interface;
using dataAccessLayer.functionInterface;
using Microsoft.Extensions.DependencyInjection;

namespace systemDisplayLayer
{
    class Program
    {
        private ITeacherBusiness itb = new ServiceCollection()
            .AddSingleton<ITeacherBusiness, TeacherBusiness>()
            .BuildServiceProvider()
            .GetService<ITeacherBusiness>();
        static void Main(string[] args)
        {
            Login();
        }

        static int LoginInit()
        {
            int input;
            string inputTry;
            
            while (true)
            { 
                Console.WriteLine(
                    "////////////////////////////////////////////////////////////////////////////////////" + "\n" +
                    "/*                Welcome to Hebut Student Management System                      */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "/*                             1. Teacher Login                                   */" + "\n" +
                    "/*                             2. Student Login                                   */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "/*                                                                                */" + "\n" +
                    "/*                 Please Enter The Number Which Is Your Choose                   */" + "\n" +
                    "////////////////////////////////////////////////////////////////////////////////////" + "\n");
                inputTry = Console.ReadLine();
                try
                {
                    input = Int32.Parse(inputTry);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Enter 1 or 2 !");
                    continue;
                    throw;
                }
            }
            
            return input;
        }

        static void Login()
        {
            while (true)
            {
                var input = LoginInit();

                if (input == 1)
                {
                    Console.WriteLine("teacher");
                    TeacherLogin();
                    break;
                }
                if (input == 2)
                {
                    Console.WriteLine("student");
                    StudentLogin();
                    break;
                }
                
                Console.WriteLine("Please enter 1 or 2 !!!!");
            }
        }

        static void TeacherLogin()
        {
            int id;
            string idTry;
            while (true)
            {
                Console.WriteLine("Please enter your id: ");
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
            
        }

        static void StudentLogin()
        {
            
        }
    }
}