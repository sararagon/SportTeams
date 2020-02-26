using ModelsST;

namespace WebApiST.Factory
{
    public interface IPlayerFactory
    {
        IPlayer RegisterPlayer(string name, double valuation, string country, double playerNumber);
        IPlayer RegisterPlayer(ArrayOfJugadoresJugadores j);
    }
}