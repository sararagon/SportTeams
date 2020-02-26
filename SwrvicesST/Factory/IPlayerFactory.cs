using ModelsST;

namespace ServicesST.Factory
{
    public interface IPlayerFactory
    {
        IPlayer RegisterPlayer(string name, double valuation, string country, double playerNumber);
    }
}