using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(26.69, 31.29, 0.37);
            double curr = 1000;
            Console.WriteLine("Из евро в гривны " + converter.ConvertToUE(curr, "eur") + ", из гривны в евро " + converter.ConvertFromUE(curr, "eur"));
            Console.WriteLine("Из долларов в гривны " + converter.ConvertToUE(curr, "usd") + ", из гривны в доллары " + converter.ConvertFromUE(curr, "usd"));
            Console.WriteLine("Из рублей в гривны " + converter.ConvertToUE(curr, "rub") + ", из гривны в рубли " + converter.ConvertFromUE(curr, "rub"));
            Console.ReadKey();
        }
    }
}
