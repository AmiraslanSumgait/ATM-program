using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Atm
{
    class CardList
    {
        public Card card1 = new Card
        {
            FullName = "Nebi Nebili",
            Pan = "5103025393850375",
            Pin="8888",
            Balance = 430.70,
            Cvc = "383",
            ExpireDate = new DateTime(2005, 5, 01)

        };
        public Card card2 = new Card    
        {
            FullName = "Kenan Idayatov",
            Pan = "4859203839486048",
            Pin = "9045",
            Balance = 300,
            Cvc = "893",
            ExpireDate = new DateTime(2007, 7, 01)
        };
        public Card card3 = new Card
        {
            FullName = "Kamal Eliyev",
            Pan = "3840239429304930",
            Pin = "2002",
            Balance = 150,
            Cvc = "108",
            ExpireDate = new DateTime(2020, 3, 01)
        };
        public Card card4 = new Card
        {
            FullName = "Tural Novruzov",
            Pan = "493593049306840",
            Pin = "5103",
            Balance = 2599.99,
            Cvc = "446",
            ExpireDate = new DateTime(2018, 3, 01)
        };
        public Card card5 = new Card
        {
            FullName = "Hormet Hemidov",
            Pan = "3850370294303820",
            Pin = "7205",
            Balance = 730.20,
            Cvc = "330",
            ExpireDate = new DateTime(2009, 3, 01)
        };

    }
}
