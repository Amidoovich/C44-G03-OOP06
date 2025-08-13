using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6.Classes
{
    internal class PermiumUser : User
    {

        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}
