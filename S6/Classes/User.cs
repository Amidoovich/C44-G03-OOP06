using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6.Classes
{
    internal abstract class User
    {
        #region Properties

        public string? Name { get; set; }

        #endregion

        public abstract Discount GetDiscount();
    }
}
