using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public Course GetCourse(string name)
        {
            return courses.Find(x => x.Name == name);
        }
        /*public double GetTotalValue()
        {
            double totalValue = 0;

            for (int i = 0; i < courses.Count; i++)
            {
                totalValue += Utility.GetValueOfCourse(courses[i]);
            }
            return totalValue;
        }*/
    }
}
