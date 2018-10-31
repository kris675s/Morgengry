using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        private static double lowQualityValue = 12.5;
        private static double mediumQualityValue = 20.0;
        private static double highQualityValue = 27.5;
        private static double courseHourValue = 875.0;

        public static double LowQualityValue
        {
            get => lowQualityValue;
            set { lowQualityValue = value; }
        }

        public static double MediumQualityValue
        {
            get => mediumQualityValue;
            set { mediumQualityValue = value; }
        }
        public static double HighQualityValue
        {
            get => highQualityValue;
            set { highQualityValue = value; }
        }
        public static double CourseHourValue
        {
            get => courseHourValue;
            set { courseHourValue = value; }
        }

        public static double GetValueOfMerchandise(Merchandise merchandise)
        {
            double price = 0;

            if (merchandise is Book book)
            {
                price = book.Price;
            }
            else if(merchandise is Amulet amulet)
            {
                if (amulet.Quality == Level.low)
                {
                    price = LowQualityValue;
                }
                if (amulet.Quality == Level.medium)
                {
                    price = MediumQualityValue;
                }
                if (amulet.Quality == Level.high)
                {
                    price = HighQualityValue;
                }
            }
            return price;
        }
        public static double GetValueOfCourse(Course course)
        {
            double DurMin = course.DurationInMinutes;
            double hoursInitialized = Math.Ceiling(DurMin / 60);
            double Price = hoursInitialized * CourseHourValue;
            return Price;
        }
        /*public static double GetValueOfBook(Book book)
        {
            double price = book.Price;
            return price;
        }
        
        public static double GetValueOfAmulet (Amulet amulet)
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
        }*/
    }
}
