using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task7
{
    class Employee
    {
        public string Name { get; }
        public string SecondName { get; }
        public byte Experience { private set; get; }
        public string[] PossiblePosts { get; }
        public string Post { private set; get; }
        public double Taxes { get; }
        public double Salary { private set; get; }
        public Employee(string name, string secondname)
        {
            Name = name;
            SecondName = secondname;
            Post = "Нет информации";
            Experience = 0;
            PossiblePosts = new string[]
            {
                "Водитель",
                "Кассир",
                "Инкассатор",
                "Менеджер отделения",
                "Главный экономист",
                "Администратор отделения",
                "Начальник отделения"
            };
            Salary = 0;
            Taxes = 0.3;
        }
        public void SetExpirience(byte exp)
        {
            if (exp > 50)
            {
                Console.WriteLine("Введен слишком большой возраст.");
            }
            Experience = exp;
            
        }
        public void SetPost(string post)
        {
            if (PossiblePosts.Any(possiblepost => possiblepost.Equals(post, StringComparison.OrdinalIgnoreCase)))
            {
                Post = post;
            }
            else
            {
                Console.WriteLine("Данной должности нет в моих списках.");
            }
        }
        public double SalaryCounter()
        {
            int index = 0;
            for (int i = 0; i < PossiblePosts.Length; i++)
            {
                
                if (Post == PossiblePosts[i])
                {
                    index = i + 1;
                }
            }
            if (Experience > 0 && Experience <= 5)
            {
                Salary = Math.Sqrt(index) * 10000 * (1 - Taxes);
                return Salary;
            }
            if (Experience > 5 && Experience <= 10)
            {
                Salary = Math.Sqrt(index) * 10000 * (1 - Taxes) * 1.2;
                return Salary;
            }
            if (Experience > 10 && Experience <= 20)
            {
                Salary = Math.Sqrt(index) * 10000 * (1 - Taxes) * 1.4;
                return Salary;
            }
            if (Experience > 20)
            {
                Salary = Math.Sqrt(index) * 10000 * (1 - Taxes) * 1.6;
                return Salary;
            }
            return 0;
        }
        public void GetPosts()
        {
            for (int i = 0; i < PossiblePosts.Length - 1; i++)
            {
                Console.WriteLine(PossiblePosts[i]);
            }
        }
        public void GetEmployeeInfo()
        {
            Console.WriteLine("Имя сотрудника - " + Name + " " + SecondName);
            Console.WriteLine("Должность сотрудника - " + Post);
            if (Experience == 0)
                Console.WriteLine("Опыт сотрудника - не назначен");
            else
                Console.WriteLine("Опыт сотрудника - " + Experience);
            Console.WriteLine("Оклад сотрудника - " + Math.Round(Salary,0) + " грн");
        }
    }
}
