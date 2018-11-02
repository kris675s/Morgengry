using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class ValuableRepository
    {
        private List<IValuable> valueables = new List<IValuable>();

        public void AddValuable(IValuable valueable)
        {
            valueables.Add(valueable);
        }
        public IValuable GetValuable(string id)
        {
            IValuable result = null;
            foreach (IValuable valueable in valueables)
            {
                if (valueable is Merchandise merchandise)
                {
                    if (merchandise.ItemId.Equals(id)) result = merchandise;
                    return result;
                }
                else if (valueable is Course course)
                {
                    if (course.Name.Equals(id)) result = course;
                    return result;
                }
            }
            return result;
        }
            
        public double GetTotalValue()
        {
            double totalValue = 0;
            for (int i = 0; i < valueables.Count; i++)
            {
                if (valueables[i] is Course course)
                {
                    totalValue += course.GetValue();
                }
                else if (valueables[i] is Book book)
                {
                    totalValue += book.GetValue();
                }
                else if (valueables[i] is Amulet amulet)
                {
                    totalValue += amulet.GetValue();
                }
            }
            return totalValue;
        }
        public int Count()
        {
            return valueables.Count;
        }
    }
}