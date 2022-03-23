using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask11._3
{
    internal class Product
    {
        public Product(int no, string name, double price)
        {
            this.No = no;
            this.Name = name;
            this.Price = price;
        }
        public Product(int no, string name, double price, int count)
        {
            this.No = no;
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }
        public int No;
        public string Name;
        public double Price;
        public int Count;
    }
}
