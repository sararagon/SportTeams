using ModelsST;

namespace ServicesST.Factory
{
    public class TeamFactory
    {
        public ITeam RegisterTeam()
        {
            return new Team() {Members = 0};
        }
    }
}