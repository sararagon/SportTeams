﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ModelsST;
using  ServicesST.Specification;
using CrossCutting.Exceptions;

namespace ServicesST.Factory
{
    class PlayerFactory : IPlayerFactory
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

     
       
    }
}
