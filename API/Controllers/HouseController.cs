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
    public class HouseController : ApiController
    {
        public List<HouseAPI> GetAllHouses()
        {
            List<HouseAPI> list = new List<HouseAPI>();
            BusinessLayer.BusinessManager bm = new BusinessLayer.BusinessManager();

            foreach (House hou in bm.GetAllHouses())
            {
                list.Add(new HouseAPI(hou));
            }

            return list;
        }
    }

}
