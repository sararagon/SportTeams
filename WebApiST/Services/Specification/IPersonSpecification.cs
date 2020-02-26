using System;
using System.Collections.Generic;
using System.Text;
using ModelsST;

namespace WebApiST.Specification
{
    public interface IPersonSpecification
    {
        bool IsSatisfiedBy(IPerson p);

    }
}
