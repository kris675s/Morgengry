using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    /*
     enum lavet uden for class
     da enum påvirker hele classen
     kunne være skrævet inden i men nu er den lagt her for at være mere synlig
    */
    public enum Level { low, medium, high }

    public class Amulet : Merchandise

    /*
    for at lave et mellemled hvor vi sikre at man ikke piller ved amulet classens metoder
    oprettes en private instance af metoderne som sikre dette.
    de private metoder giver information til public metoderne
    */
    {
        private string design;
        private Level quality;

        public string Design
        {
            get => design;
            set { design = value; }
        }
        public Level Quality
        {
            get => quality;
            set { quality = value; }
        }
        /*
        main constructor
        */
        public Amulet(string item, Level quality, string design)// : base(item)
        {
            Quality = quality;
            ItemId = item;
            Design = design;
        }
        /*
        sub constructor
        */
        public Amulet(string item, Level quality) : this(item, quality, "")
        {
            //tom krop for at afslutte 
        }
        /*
         sub constructor
        */ 
        public Amulet(string item) : this(item, Level.medium)
        {
            //tom krop for at afslutte
        }
        public override string ToString()
        {
            return ("ItemId: " + ItemId + ", " + "Quality: " + Quality + ", " + "Design: " + Design);
        }

    }
}
