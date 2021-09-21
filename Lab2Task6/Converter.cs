using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task6
{
    class Converter
    {
        public double Usd { get; }
        public double Eur { get; }
        public double Rub { get; }
        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }
        public double ConvertToUE(double count, string currtype)
        {
            switch (currtype)
            {
                case "usd":
                    {
                        return count * Usd;
                    }
                case "eur":
                    {
                        return count * Eur;
                    }
                case "rub":
                    {
                        return count * Rub;
                    }
                default:
                    {
                        Console.WriteLine("Введено неправильное название валюты");
                        return 0;
                    }
            }
        }
        public double ConvertFromUE(double count, string currtype)
        {
            switch (currtype)
            {
                case "usd":
                    {
                        return count / Usd;
                    }
                case "eur":
                    {
                        return count / Eur;
                    }
                case "rub":
                    {
                        return count / Rub;
                    }
                default:
                    {
                        Console.WriteLine("Введено неправильное название валюты");
                        return 0;
                    }
            }
        }
    }
}
