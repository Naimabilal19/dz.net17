using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    //srp ocp
    class Card
    {
        public string number { get; set; }
        public int money { get; set; }
        public int cvv { get; set; }

        public Card() { }
        public Card(string n, int c, int m)
        {
            number = n;
            cvv = c;
            money = m;
        }
        public void Printmoney()
        {
            Console.WriteLine(money);
        }
    }
    class ATM : Card
    {
        private int amount;

        public ATM() { }
        public ATM(int a) 
        {
            amount = a;
        }
        public void Add(Card Obj, int a)
        {
            money += a;
        }
        public void Take(Card Obj, int a)
        {
            money -= a;
        }
    }
    class Bill
    {
        private bool bill;
        public Bill() { }
        public Bill(bool b)
        {
            bill = b;
        }
        public void PrintBill()
        {
            if (bill == true)
                Console.WriteLine("Чек распечатан");
            else
                Console.WriteLine("Не удалось распечатать чек");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card("123456", 235000, 123);
            c.number = "123456";
            c.money = 23500;
            c.cvv = 123;

            ATM a = new ATM();
            int e = 1000;
            a.Add(c, e);
            a.Take(c,e);

            Bill b = new Bill();
            b.PrintBill();
        }
    }
}
