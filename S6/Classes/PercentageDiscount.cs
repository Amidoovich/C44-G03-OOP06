using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6.Classes
{
    internal class PercentageDiscount : Discount
    {

        #region Properties

        public decimal Percentage { get; set; }

        #endregion

        #region Cosntructor


        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
            Name = "Percentage Discount";
        }

        #endregion

        #region Methods
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage/100);
        } 
        #endregion
    }
}
