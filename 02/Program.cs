using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {

        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити клас Converter.
        // У тілі класу створити користувальницький конструктор, який приймає три речові аргументи,
        // і ініціалізує поля, що відповідають курсу 3-х основних валют,
        // по відношенню до гривні – public Converter (double usd, double eur, double gbt).
        // Написати програму, яка виконуватиме конвертацію з гривні в одну із зазначених валют,
        // також програма повинна проводити конвертацію із зазначених валют у гривню.

        class Converter
        {
            readonly double usd;
            readonly double eur;
            readonly double gbt;

            public Converter(double usd, double eur, double gbt)
            {
                this.usd = usd;
                this.eur = eur;
                this.gbt = gbt;
            }

            private double uahAmount;
            public double UAH
            {
                get { return uahAmount; }
                set { uahAmount = value; }
            }


            public double USD
            {
                get { return uahAmount / usd; }
                set { uahAmount = value * usd; }
            }
            public double EUR
            {
                get { return uahAmount / eur; }
                set { uahAmount = value * eur; }
            }
            public double GBT
            {
                get { return uahAmount / gbt; }
                set { uahAmount = value * gbt; }
            }

        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // 840	USD	1	Долар США	41,2250
            // 978	EUR	1	Євро	44,6467
            // 826	GBP	1	Фунт стерлінгів	52,5207

            Converter converter = new Converter(41.2250, 44.6467, 52.5207);

            while (true)
            {
                Console.Write("Введіть валюту(UAH, USD, EUR, GBP): ");
                string currency;
                currency = Console.ReadLine();

                Console.Write("Введіть суму: ");

                switch (currency)
                {
                    case "UAH":
                        converter.UAH = double.Parse(Console.ReadLine());
                        Console.WriteLine("в долларах {0}, в євро {1}, в фунтах стерлінгів {2}", converter.USD, converter.EUR, converter.GBT);
                        break;
                    case "USD":
                        converter.USD = double.Parse(Console.ReadLine());
                        Console.WriteLine("в гривнях {0}", converter.UAH);
                        break;
                    case "EUR":
                        converter.EUR = double.Parse(Console.ReadLine());
                        Console.WriteLine("в гривнях {0}", converter.UAH);
                        break;
                    case "GBP":
                        converter.GBT = double.Parse(Console.ReadLine());
                        Console.WriteLine("в гривнях {0}", converter.UAH);
                        break;
                }

                Console.WriteLine(new string('-', 30));
            }

            Console.ReadKey();

        }
    }
}
