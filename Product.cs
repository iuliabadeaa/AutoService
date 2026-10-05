using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceCuNET
{
    internal class Product
    {
        string name;
        int price;
        public string Name 
        {
            get { return name; }
            set { name = value; } 
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(string n="", int pr=0)
        {
            this.name = n;
            this.price = pr;
        }
        public float ConvertToEuro(int price)
        {
            float PriceInEuro;
            float Currency = 4.98f;
            PriceInEuro = price / Currency;

            return PriceInEuro;
        }
    }
}
