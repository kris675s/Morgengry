using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class ValuableRepository
    {
        private List<IValuable> valueables = new List<IValuable>();

        public AddValuable(valuables);
        public string GetValuable; IValuable
        public double GetTotalValue()
        {
            double totalValue = 0;
            for (int i = 0; i < valueables.Count; i++)
            {
                if (valueables[i] is Course course)
                {
                    totalValue += course.GetValue(valueables[i]);
                }
                else if (valueables[i] is Book book)
                {
                    totalValue += book.GetValue(valueables[i]);
                }
                else if (valueables[i] is Amulet amulet)
                {
                    totalValue += amulet.GetValue(valueables[i]);
                }

            }
            return totalValue;
        }
        public int Count;
        

    }
}
