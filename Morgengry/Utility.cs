using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        static public double GetValueOfBook(Book book)
        {
            double price = book.Price;
            return price;
        }
        
        static public double GetValueOfAmulet (Amulet amulet)
        {
            double price = 12.5;
            if (amulet.Quality == Level.medium)
            {
                price = 20.0;
            }
            if (amulet.Quality == Level.high)
            {
                price = 27.5;
            }
            return price;
        }
        static public double GetValueOfCourse (Course course)
        {
            double DurMin = course.DurationInMinutes;
            double hoursInitialized = Math.Ceiling(DurMin / 60);
            double Price = hoursInitialized * 875.00;
            return Price;
        }
    }
}
