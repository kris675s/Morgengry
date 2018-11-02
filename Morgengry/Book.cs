using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise, IValuable
    {
        private string title;
        private double price;
        
        public string Title
        {
            get => title;
            set { title = value; }
        }       

        public double Price
        {
            get => price;
            set { price = value; }
        }

        public Book(string item, string bookTitle, double bookPrice)// : base(item)
        {
            ItemId = item;
            Title = bookTitle;
            Price = bookPrice;
        }
        public Book(string item, string booktitle): this(item, booktitle, 0)
        {

        }

        public double GetValue()
        {
            double price = 0;
            price = Price;
            return price;
        }

        public Book(string item) : this(item, "", 0)
        {

        }

        public override string ToString()
        {
            return ("ItemId: "+ ItemId+", "+"Title: "+ Title+", "+"Price: "+ Price);
        }
    }
}