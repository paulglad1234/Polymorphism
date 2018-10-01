using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class NotEturnalProduct : Product
    {
        private int ReleaseYear { get; set; }

        public NotEturnalProduct(string name, int price, int number, int year)
        : base(name, price, number)
        {
            ReleaseYear = year;
        }

        public override double Q()
        {
            return base.Q() + 0.5 * (DateTime.Today.Year - ReleaseYear);
        }
        public override string[] Output()
        {
            string[] lines = new string[5];
            lines[0] = "Название: " + Name.ToString();
            lines[1] = "Цена: " + Price.ToString();
            lines[2] = "Кол-во: " + Number.ToString();
            lines[3] = "Год выпуска: " + ReleaseYear.ToString();
            lines[4] = "Qp = " + Q().ToString();
            return lines;
        }
    }
}
