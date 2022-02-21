using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Invoice : IPay
    {
        public decimal ValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
