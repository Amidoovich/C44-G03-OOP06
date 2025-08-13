using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6.Classes
{
    internal class BuyOneGetOneDiscount : Discount
    {


        #region Constructors

        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One Discount";
        }

        #endregion
        #region Methods
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity <= 1)
                return 0;
            else
                return (price / 2) * (quantity / 2);
        } 
        #endregion
    }
}
