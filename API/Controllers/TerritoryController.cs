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
    public class TerritoryController : ApiController
    {
        public List<TerritoryAPI> GetAllTerritories()
        {
            List<TerritoryAPI> list = new List<TerritoryAPI>();
            BusinessLayer.BusinessManager bm = new BusinessLayer.BusinessManager();

            foreach (Territory ter in bm.GetAllTerritories())
            {
                list.Add(new TerritoryAPI(ter));
            }

            return list;
        }

    }

}
