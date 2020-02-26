using System.Collections.Generic;
using ModelsST;

namespace ServicesST.Repository
{
    public interface IRepository
    {
        List<IPerson> ReadPersons();
    }
}