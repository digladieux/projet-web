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
    public class FightController : ApiController
    {
        public List<FightAPI> GetAllFights()
        {
            List<FightAPI> list = new List<FightAPI>();
            BusinessLayer.BusinessManager bm = new BusinessLayer.BusinessManager();

            foreach (Fight fi in bm.GetAllFights())
            {
                list.Add(new FightAPI(fi));
            }

            return list;
        }
    }

}
