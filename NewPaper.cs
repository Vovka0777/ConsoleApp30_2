using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3x
{
    internal class NewPaper : PrintedProducts
    {
        private int listcount;
        private int tiraj;
        private int listprice;

        public int Listcount { get => listcount; set => listcount = value; }
        public int Tiraj { get => tiraj; set => tiraj = value; }
        public int Listprice { get => listprice; set => listprice = value; }

        public NewPaper() { }
        public NewPaper(string name, int listcount, int tiraj, int listprice) : base (name) 
        {
            this.Listcount = listcount;
            this.Tiraj = tiraj;
            this.Listprice = listprice;
            this.Name = name;
        }

        public override void TirajPrice()
        {
            int tirajprice = Listcount * Tiraj * Listprice;
            Console.WriteLine($"Стоимость газеты: {tirajprice} рублей");
        }
        public override void Info()
        {
            Console.WriteLine($"Название газеты: {Name}\nКоличество листов: {Listcount}\nТираж: {Tiraj}\nЦена: {Listprice}");
        }
    }
}
