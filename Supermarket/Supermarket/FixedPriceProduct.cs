using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price + (decimal)((decimal)(Tax)*Price); 
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n     Value......: {$"{ValueToPay():C2}",15}";
        }
    }
}
