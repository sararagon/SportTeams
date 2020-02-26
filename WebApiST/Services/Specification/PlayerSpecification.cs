using System;
using ModelsST;
using CrossCutting.Exceptions;

namespace WebApiST.Specification
{
    public class PlayerSpecification : IPersonSpecification
    {
        public bool IsSatisfiedBy(IPerson p)
        {
            try
            {
                return p is Player pl && (!(p.Name.StartsWith("Z")) &&
                                          (pl.Valuation >= 1 &&
                                           pl.Valuation <= 10) && (pl.Country != "USA")
                                           && pl.Number >= 0 && pl.Number < 100);
            }
            catch (Exception ex)
            { 
                throw new IsNotPlayerException("La persona introducida no puede ser un jugador correcto", ex);
                

            }

            
        }

       
    }
}
