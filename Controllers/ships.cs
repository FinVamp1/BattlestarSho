using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BattleStarSho.Models;

namespace BattleStarSho.Controllers
{
    public class ShipsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Ships> Get()
        {
            return new Ships[]{
                new Ships { Id=1,Name="Galactica", Class="BattleStar", Function="Military", Race="Colonial", ImageUrl="images/galactica.png"},
                new Ships { Id=1,Name="Atlantis", Class="BattleStar", Function="Military", Race="Colonial", ImageUrl="images/Atlantis.png"},
                new Ships { Id=1,Name="CylonBase", Class="BaseStar", Function="Military", Race="Cylon", ImageUrl="images/basetar.png"},
                new Ships { Id=1,Name="TheHub", Class="ResurrectionShip", Function="Military", Race="Cylon", ImageUrl="images/thehub.png"}
            };
        }

    }
}
