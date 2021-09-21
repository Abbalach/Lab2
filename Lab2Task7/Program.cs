using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string SecondName = Console.ReadLine();
            Employee employee = new Employee(Name, SecondName);
            Console.WriteLine("Введите опыт");
            byte Exp = 0;
            try
            {
                Exp = Convert.ToByte(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Неправильно введен опыт");
                return;
            }
         
            
            Console.WriteLine("Введите должность");
            string Post = Console.ReadLine();
            employee.SetExpirience(Exp);
            employee.SetPost(Post);
            employee.SalaryCounter();
            employee.GetEmployeeInfo();
            Console.ReadKey();
        }
    }
}
