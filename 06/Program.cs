using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити клас User, що містить інформацію про користувача (логін, ім'я, прізвище, вік, дату заповнення анкети).
        // Поле дата заповнення анкети має бути проініціалізоване лише один раз (при створенні екземпляра цього класу)
        // без можливості його подальшої зміни. Реалізуйте виведення на екран інформації про користувача.

        class User
        {
            readonly private string login;
            readonly private string firstname;
            readonly private string surname;
            readonly private int age;
            readonly private DateTime dateFilling;

            public string Login { get { return login; } }
            public string Firstname { get { return firstname; } }
            public string Surname { get { return surname; } }
            public int Age { get { return age; } }
            public DateTime DateFilling { get { return dateFilling; } }

            public User(string login, string firstname, string surname, int age)
            {
                this.login = login;
                this.firstname = firstname;
                this.surname = surname;
                this.age = age;
                this.dateFilling = DateTime.Now;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            User user = new User("nick", "Володимир", "Висоцький", 82);

            Console.WriteLine("Логін: {0}, ім'я {1} {2}, вік {3}, дата заповнення {4}", user.Login, user.Surname, user.Firstname, user.Age, user.DateFilling);

            Console.ReadKey();
        }
    }
}
