using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ModelsST
{
    public class Team : ITeam
    {
        public List<IPerson> TeamPersons { get; set; }
        public int Members { get; set; }

        public void Add(IPerson person)
        {
            TeamPersons.Add(person);
            Members =+ 1;
        }

        public void Quit(IPerson person)
        {
            foreach (var p in TeamPersons)
            {
                
            }
            {
                
            }
        }
    }
}
