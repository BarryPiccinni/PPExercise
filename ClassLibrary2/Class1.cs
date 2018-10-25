using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary2
{
    public class Checkout
    {
        private readonly List<product> items = new List<product>();

        public void scan(product item)
        {
            items.Add(item);
        }

        public double Total()
        {
            double total = 0.00;
            int tea = 0;
            int strawb = 0;
            foreach (product p in items)
            {
                switch (p.Code)
                {
                    case "FR1":
                        tea++;
                        if (tea % 2 == 0)
                        {
                            break;
                        }
                        else
                        {
                            total += p.Price;
                            break;
                        }
                        
                    case "SR1":
                        strawb++;
                        total += p.Price;
                        if (strawb > 2)
                        {
                            total -= strawb * 0.50;
                        }
                        break;
                    default:
                        total += p.Price;
                        break;
                }
            }
            return total;
        }
    }

    public class product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public product(string code, string name, double price)
        {
            Code = code;
            Name = name;
            Price = price;
        }
    }
}
