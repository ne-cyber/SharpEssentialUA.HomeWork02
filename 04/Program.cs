using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        // Потрібно: Створити клас Invoice.
        // У тілі класу створити три поля int account, string customer, string provider,
        // які мають бути проініціалізовані один раз (при створенні екземпляра даного класу) без можливості їхньої подальшої зміни.
        // У тілі класу створити два закриті поля string article, int quantity
        // Створити метод розрахунку вартості замовлення з ПДВ та без ПДВ. Написати програму,
        // яка виводить на екран суму оплати замовленого товару з ПДВ чи без ПДВ.

        class Invoice
        {
            readonly int account;
            readonly string customer;
            readonly string provider;

            public int Account { get { return account; } }
            public string Customer { get { return customer; } }
            public string Provider { get { return provider; } }

            public Invoice(int account, string customer, string provider)
            {
                this.account = account;
                this.customer = customer;
                this.provider = provider;
            }

            private string article;
            private int quantity;

            public string Article
            {
                get { return article; }
                set { article = value; }
            }
            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }


            public double OrderPrice()
            {
                double articlePrice = 1000;
                return articlePrice * Quantity;
            }
        }

        class Tax
        {
            readonly double ПДВ = 20;
            public double CalculateWithoutTax(double money)
            {
                return money * (100 - ПДВ)/100;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Invoice invoice = new Invoice(1, "шевченко", "магазин");
            invoice.Article = "флеш пам'ять";
            invoice.Quantity = 2;

            Console.WriteLine("Заказ {0}, покупець {1}, продавець {2}, товар {3}, кількість {4} ", invoice.Account, invoice.Customer, invoice.Provider, invoice.Article, invoice.Quantity);
            Console.WriteLine("сума з ПДВ {0}", invoice.OrderPrice());
            Console.WriteLine("сума без ПДВ {0}", new Tax().CalculateWithoutTax(invoice.OrderPrice()));

            Console.ReadKey();
        }
    }
}
