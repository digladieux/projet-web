using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class FightAPI
    {
        public HouseAPI _houseChallenger1 { get; private set; }
        public HouseAPI _houseChallenger2 { get; private set; }

        public HouseAPI _winningHouse { get; private set; }

        public FightAPI() { }
        public FightAPI(HouseAPI houseChallenger1, HouseAPI houseChallenger2, HouseAPI winningHouse)
        {
            _houseChallenger1 = houseChallenger1;
            _houseChallenger2 = houseChallenger2;
            _winningHouse = winningHouse;
        }

        public FightAPI(Fight fi)
        {
            _houseChallenger1 = new HouseAPI(fi._houseChallenger1);
            _houseChallenger2 = new HouseAPI(fi._houseChallenger2);
            _winningHouse = new HouseAPI(fi._winningHouse);
        }
    }

}