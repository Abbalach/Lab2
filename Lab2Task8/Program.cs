using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("Bill White", "DistributionUA", 10000);
            invoice.SetArticle("Принтер", 6, 1800);
            invoice.OrderWithVAT();
            invoice.OrderWithoutVAT();
            Console.ReadKey();
        }
    }
}
