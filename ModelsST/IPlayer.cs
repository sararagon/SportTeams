using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsST
{
    interface IPlayer : IPerson
    {
        double Valuation { get; set; }
        string Country { get; set; }
        int Number { get; set; }
    }
}
