using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.login = "login";
            user.name = "Felix";
            user.secondname = "White";
            user.age = 25;
            Console.WriteLine("Login - " + user.login + ", name - " + user.name + ", secondname - " + user.secondname + ", age - " + user.age + ", date - " + user.date);
            Console.ReadKey();
        }
    }
}
