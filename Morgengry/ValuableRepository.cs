using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class ValuableRepository : IValuable
    {
        private List<IValuable> valueables = new List<IValuable>();

        public AddValuable(valuables);
        public string GetValuable : IValuable;
        public double GetTotalValue()
        {
            double totalValue = 0;
            for (int i = 0; i < valueables.Count; i++)
            {
                if (valueables == Course course)
                totalValue += IValuable.GetValue(valueables[i]);
            }
            return totalValue;
        }
        public int Count;
        

    }
}
