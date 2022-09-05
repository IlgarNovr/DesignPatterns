using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_SOLID
{
    class LiskovSubstitution
    {
        public abstract class Drink
        {
            public abstract string GetComposition();
        }

        public class Cola :Drink 
        {
            public override string GetComposition()
            {
                return "Carbonated water, Sugar, Caramel colour, Phosphoric Acid, Caffeine, Natural flavours";
            }

        }

        public class Fanta : Drink
        {
            public override string GetComposition()
            {
                return "Carbonated Water, Orange Fruit from Concentrate (4%), Citric Acid, Sweeteners (Acesulfame K, Aspartame), Preservative (Potassium Sorbate), Malic Acid, Natural Orange Flavouring with Other Natural Flavourings, Vegetable Concentrates (Carrot, Pumpkin), Antioxidant (Ascorbic Acid), Stabiliser (Guar Gum).";
            }
        }
    }
}
