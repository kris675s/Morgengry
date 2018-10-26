using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public abstract class Merchandise
    {
        private string item;
        public string ItemId
        {
            get => item;
            set { item = value; }
        }
        /*
         * constructor er blevet unødvændig efter opgave3 i ex17
        public Merchandise(string item)
        {
            ItemId = item;
        }
        */
        public override string ToString()
        {
            return ("ItemId: " + ItemId);
        }

    }
}
