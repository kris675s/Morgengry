using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        public Merchandise GetMerchandise(string itemId)
        {
            return merchandises.Find(x => x.ItemId == itemId);
        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            for (int i = 0; i < merchandises.Count; i++)
            {
                totalValue += Utility.GetValueOfMerchandise(merchandises[i]);
            }
            return totalValue;
        }

    }
}
