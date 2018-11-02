using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course : IValuable
    {
        private string name;
        private int durationInMinutes;
        private static double courseHourValue = 875.0;
        public string Name
        {
            get => name;
            set { name = value; }
        }

        public int DurationInMinutes
        {
            get => durationInMinutes;
            set { durationInMinutes = value; }
        }
        public static double CourseHourValue
        {
            get => courseHourValue;
            set { courseHourValue = value; }
        }

        public double GetValue()
        {
             double DurMin = DurationInMinutes;
             double hoursInitialized = Math.Ceiling(DurMin / 60);
             double Price = hoursInitialized * CourseHourValue;
             return Price;
        }

        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }
        public Course(string name) : this (name, 0)
        {

        }

        public override string ToString()
        {
            return ("Name: " + name + ", Duration in Minutes: " + durationInMinutes);
        }
    }
}
