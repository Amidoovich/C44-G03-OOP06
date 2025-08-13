using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6.Classes
{
    internal abstract class Discount
    {

        
        #region Properties

        public string? Name { get; set; }

        #endregion


        #region methods

        public abstract decimal CalculateDiscount(decimal price, int quantity);

        #endregion
    }
}
