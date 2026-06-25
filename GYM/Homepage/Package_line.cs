using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homepage
{
    public class Package_line
    {
        public string Package_name { get; set; }
        public string Duration { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public double Minprice { get; set; }
        public double Maxprice { get; set; }


        public Package_line(double minprice, double maxprice)
        {
            Minprice = minprice;
            Maxprice = maxprice;
        }
        public Package_line(string package_name)
        {
            Package_name = package_name;
        }
        public Package_line(string category, double minprice)
        {
            Category = category;
            Minprice = minprice;
        }
        public Package_line(string package_name, string duration, double price, string category)
        {
            Package_name = package_name;
            Duration = duration;
            Price = price;
            Category = category;
        }
    }
}