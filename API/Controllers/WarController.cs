using API.Models;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class WarController : ApiController
    {
        public List<WarAPI> GetAllWars()
        {
            List<WarAPI> list = new List<WarAPI>();
            BusinessLayer.BusinessManager bm = new BusinessLayer.BusinessManager();

            foreach (War wa in bm.GetAllWars())
            {
                list.Add(new WarAPI(wa));
            }

            return list;
        }

    }

}
