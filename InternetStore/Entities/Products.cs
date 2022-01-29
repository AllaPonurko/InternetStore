using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore
{
    public class Products
    {
       public Guid Id = new Guid();
       public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Gender { get; set; }
        public string Origin { get; set; }
        public override string ToString()
        {
            return $"{Name}\t"+$"Color-{Color}\n"+ $"{Gender}\t" + $"Size-{Size}\n"+$"{Price} грн.\n"+$"Origin-{Origin}";
        }
    }
}
