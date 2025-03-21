using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3x
{
    internal class Magazine : PrintedProducts
    {
        private int tiraj;
        private int price;

        public int Tiraj { get => tiraj; set => tiraj = value; }
        public int Price { get => price; set => price = value; }

        public Magazine() { }
        public Magazine(string name, int tiraj, int price) : base(name)
        {
            this.Tiraj = tiraj;
            this.Price = price;
            this.Name = name;
        }
        public override void TirajPrice()
        {
            int tirajprice = Price * Tiraj;
            Console.WriteLine($"Стоимость журнала: {tirajprice} рублей");
        }
        public override void Info()
        {
            Console.WriteLine($"Название журнала: {Name}\nЦена: {Price}\nТираж: {Tiraj}");
        }
    }
}
