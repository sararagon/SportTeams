using System.Collections.Generic;

namespace ModelsST
{
    public interface ITeam
    {
        List<IPerson> TeamPersons { get; set; }
        int Members { get; set; }
    }
}