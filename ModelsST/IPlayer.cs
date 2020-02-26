using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsST
{
    public interface IPlayer : IPerson
    {
        double Valuation { get; set; }
        string Country { get; set; }
        int Number { get; set; }
    }
}
