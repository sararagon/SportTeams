using System.Collections.Generic;
using ModelsST;


namespace WebApiST.Factory
{
    public class TeamFactory
    {
        private IPlayerFactory _playerFactory;

        public ITeam RegisterTeam()
        {
            return new Team() {Members = 0};
        }

        public ITeam RegisterTeam(List<IPerson> players)
        {
            var team = new Team();
            foreach (var p in players)
            {
                team.Add(p);
            }

            return team;
        }

        public ITeam RegisterTeam(ArrayOfJugadores jugadores)
        {
            var team = new Team();
            foreach (var j in jugadores.Jugadores)
            {
                var player = _playerFactory.RegisterPlayer(j);
                team.Add(player);
            }

            return team;
        }
    }
}