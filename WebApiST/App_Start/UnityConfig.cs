using System.Web.Mvc;
using ModelsST;
using ServicesST.Factory;
using ServicesST.Repository;
using ServicesST.Specification;
using Unity;
using Unity.Mvc5;

namespace WebApiST
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IPlayerFactory, PlayerFactory>();
            container.RegisterType<IPlayer, Player>();
            container.RegisterType<ITeam, Team>();
            container.RegisterType<IPersonSpecification, PlayerSpecification>();
            container.RegisterType<IRepository, APIRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}