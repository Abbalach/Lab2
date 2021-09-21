using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task8
{
    class Invoice
    {
        public string Customer { get; }
        public string Provider { get; }
        public int Account { get; }
        private string Article { set; get; }
        private int Quantity { set; get; }
        private double ArticlePrice { get; set; }
        private double ProductPrice { get; set; }
        private double VAT { get; }
        public Invoice(string customer, string provider, int account)
        {
            Customer = customer;
            Provider = provider;
            if (account <= 0)
            {
                Console.WriteLine("Неправильно введен счет.");
            }
            else
                Account = account;
            VAT = 0.2;
        }
        public void SetArticle(string articlename, int articlecount, double price)
        {
            Article = articlename;
            Quantity = articlecount;
            ProductPrice = price;
        }
        public void OrderWithVAT()
        {
            ArticlePrice = ProductPrice * Quantity * (1 - VAT);
            if (Account > ArticlePrice)
            {
                Console.WriteLine("Со счета " + Customer + " компания " + Provider + " сняла " + ArticlePrice + " грн. Заказ был оформлен.");
            }
            else
            {
                Console.WriteLine("На вашем счете недостаточно денег (стоимость заказа " + ArticlePrice + " грн.)");
            }
        }
        public void OrderWithoutVAT()
        {
            ArticlePrice = ProductPrice * Quantity;
            if (Account > ArticlePrice)
            {
                Console.WriteLine("Со счета " + Customer + " компания " + Provider + " сняла " + ArticlePrice + " грн. Заказ был оформлен.");
            }
            else
            {
                Console.WriteLine("На вашем счете недостаточно денег (стоимость заказа " + ArticlePrice + " грн.)");
            }
        }
    }
}
