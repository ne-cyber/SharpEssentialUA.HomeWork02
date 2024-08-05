using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно створити клас Employee.
        // У тілі класу створити користувальницький конструктор,
        // який приймає два рядкові аргументи, та ініціалізує поля, що відповідають прізвищу та імені співробітника.
        // Створити метод, що розраховує оклад співробітника (залежно від посади та стажу)
        // та податковий збір.
        // Написати програму, яка виводить на екран інформацію про співробітника (прізвище, ім'я, посада), оклад та податковий збір. 

        class Employee
        {
            readonly string surname;
            readonly string firstName;

            public Employee(string firstname, string surname)
            {
                this.firstName = firstname;
                this.surname = surname;
            }

            public double Salary(string position, double experience)
            {
                EmployeeSalary employeeSalary = new EmployeeSalary(position, experience);
                return employeeSalary.Salary;
            }

            public string Surname { get { return surname; } }
            public string FirstName { get { return firstName; } }
        }

        class EmployeeSalary
        {
            readonly string position;
            readonly double experience;

            public EmployeeSalary(string position, double experience)
            {
                this.position = position;
                this.experience = experience;
            }

            public double Salary
            {
                get
                {
                    double baseSalary = 0;
                    switch (position)
                    {
                        case "Менеджер":
                            baseSalary = 12000;
                            break;

                        case "Секретар":
                            baseSalary = 15000;
                            break;
                    }

                    if (experience < 5)
                        return baseSalary * 1;
                    else if (experience < 10)
                        return baseSalary * (1 + 0.5);
                    else if (experience < 15)
                        return baseSalary * (1 + 0.75);
                    else
                        return baseSalary * (1 + 1);

                }
            }
        }

        class Tax
        {
            private readonly double ПДФО = 18;
            private readonly double ВЗ = 1.5;

            public double CalculateTax(double salary)
            {
                return salary * (ПДФО + ВЗ) / 100;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Employee employee = new Employee("Андрій", "Шевченко");

            Console.WriteLine("Працівник {0} {1}, на посаді Менеджер, стаж 4 роки, оклад {2} податковий збір {3}", employee.Surname, employee.FirstName, employee.Salary("Менеджер", 4), new Tax().CalculateTax(employee.Salary("Менеджер", 4)));

            Console.ReadKey();

        }
    }
}
