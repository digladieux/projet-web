using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class WarAPI
    {
        public List<FightAPI> _listFights { get; private set; }

        public WarAPI() { }

        public WarAPI(War wa)
        {
            List<FightAPI> liste_fight = new List<FightAPI>();
            foreach (Fight fi in wa._listFights)
            {
                liste_fight.Add(new FightAPI(fi));
            }
            _listFights = liste_fight;
        }
    }

}