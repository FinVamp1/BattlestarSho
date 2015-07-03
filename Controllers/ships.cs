using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

using BattleStarSho.Models;

namespace BattleStarSho.Controllers
{
    [RouteAttribute("api/[Controller]")]
    public class ShipsController : Controller
    {
        [HttpGet]
        public IEnumerable<Ships> Get()
        {
            return new Ships[]{
                new Ships { Id=1,Name="Galactica", Class="BattleStar", Function="Military", Race="Colonial", ImageUrl="images/galactica.png"},
                new Ships { Id=2,Name="Atlantis", Class="BattleStar", Function="Military", Race="Colonial", ImageUrl="images/Atlantis.png"},
                new Ships { Id=3,Name="CylonBase", Class="BaseStar", Function="Military", Race="Cylon", ImageUrl="images/basetar.png"},
                new Ships { Id=4,Name="TheHub", Class="ResurrectionShip", Function="Military", Race="Cylon", ImageUrl="images/thehub.png"}
            };
        }

    }
}
