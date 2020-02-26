using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsST
{
    public class Player : IPerson, IPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Valuation { get; set; }
        public string Country { get; set; }
        public int Number { get; set; }
    }
}
