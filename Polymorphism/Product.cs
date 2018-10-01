using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Product
    {
        protected string Name { get; set; }
        protected int Price { get; set; }
        protected int Number { get; set; }

        public Product(string name, int price, int number)
        {
            Name = name;
            Price = price;
            Number = number;
        }
        public virtual double Q()
        {
            return Price / (double)Number;
        }
        public virtual string[] Output()
        {
            string[] lines = new string[4];
            lines[0] = "Название: " + Name.ToString();
            lines[1] = "Цена: " + Price.ToString();
            lines[2] = "Кол-во: " + Number.ToString();
            lines[3] = "Q = " + Q().ToString();
            return lines;
        }
    }
}
