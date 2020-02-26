using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ModelsST;
using  ServicesST.Specification;
using CrossCutting.Exceptions;


namespace WebApiST.Factory
{
    public class PlayerFactory : IPlayerFactory
    {
        private IPersonSpecification _specification;

        public IPlayer RegisterPlayer(string name, double valuation, string country, double playerNumber)
        {

            if (Math.Abs(playerNumber % 1) > 0)
            {
                throw new PlayerNumberNotCorrectException();

            }
            var player = new Player()
                {
                    Name = name,
                    Valuation = valuation,
                    Country = country,
                    Number = Convert.ToInt32(playerNumber)
                };

            if (_specification.IsSatisfiedBy(player))
            {
                return player;
            }
            else
            {
                throw new NotCreatedPlayerException();
            }
         
        }

        public IPlayer RegisterPlayer(ArrayOfJugadoresJugadores jugador)
        {

            if (Math.Abs(jugador.Dorsal % 1) > 0)
            {
                throw new PlayerNumberNotCorrectException();

            }
            
            var player = new Player()
            {
                Id = jugador.Id,
                Name = jugador.NombreJugador,
                Valuation = (double) jugador.Valoracion,
                Country = jugador.Pais,
                Number = Convert.ToInt32(jugador.Dorsal)
            };

            if (_specification.IsSatisfiedBy(player))
            {
                return player;
            }
            else
            {
                throw new NotCreatedPlayerException();
            }

        }

    
    }
}
