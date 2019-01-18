using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class TerritoryAPI
    {
        public HouseAPI _owner { get; private set; }
        public TerritoryTypeEnum _territoryType;

        public TerritoryAPI() { }
        public TerritoryAPI(HouseAPI owner, TerritoryTypeEnum territoryType)
        {
            _owner = owner;
            _territoryType = territoryType;
        }

        public TerritoryAPI(Territory ter)
        {
            _owner = new HouseAPI(ter._owner);
            _territoryType = ter._territoryType;
        }
    }

}