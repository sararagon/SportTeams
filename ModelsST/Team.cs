using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsST
{
    public class Team : ITeam
    {
        public List<IPerson> TeamPersons { get; set; }
        public int Members { get; set; }
    }
}
