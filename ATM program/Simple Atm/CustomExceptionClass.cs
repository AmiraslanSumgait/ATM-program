using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Atm
{
    public class LackOfBalanceException : ApplicationException
    {
        public LackOfBalanceException()
            : base()
        { }

        public LackOfBalanceException(String message)
            : base(message)

        { }

      
    }
}
