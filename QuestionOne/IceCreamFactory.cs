using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    public class IceCreamFactory
    {
        public void OrderIceCream(string flavor, string type)
        {

            Console.WriteLine($"Your order is confirmed with flavor {flavor} in {type}");
        }

        public IceCream GetIceCreamFlavorInstance(string flavor)
        {
            IceCream iceCream = null;
            if (string.Equals(flavor, "Vanila", StringComparison.OrdinalIgnoreCase))
            {
                iceCream = new Valina();
            }
            return iceCream;
        }
    }
}
