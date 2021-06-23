using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Atm
{
    class Card
    {
        public string FullName { get; set; }
        public string Pan { get; set; }
        public string Pin { get; set; }
        public string Cvc { get; set; }
        public DateTime ExpireDate { get; set; }
        public double Balance { get; set; }
    }
}
