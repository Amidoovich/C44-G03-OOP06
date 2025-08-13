using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6.Classes
{
    internal class FlatDiscount : Discount
    {



        #region Properties


        public decimal FlatAmount { get; set; }


        #endregion

        #region Constructor

        public FlatDiscount(decimal amount)
        {

            FlatAmount = amount;
            Name = "Flat Discount";   
        }
        #endregion


        #region Methods
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return  FlatAmount * Math.Min(quantity,1);
        } 
        #endregion
    }
}
