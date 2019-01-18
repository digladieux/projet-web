using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class HouseAPI
    {
        public List<CharacterAPI> _housers { get; private set; }
        public string _name { get; private set; }
        public int _numberOfUnities { get; private set; }
        public HouseAPI() { }

        public HouseAPI(List<CharacterAPI> housers, string name, int numberOfUnites)
        {
            _housers = housers;
            _name = name;
            _numberOfUnities = numberOfUnites;
        }

        public HouseAPI(House hou)
        {
            List<CharacterAPI> other_housers = new List<CharacterAPI>();
            foreach (Character ch in hou._housers)
            {
                other_housers.Add(new CharacterAPI(ch));
            }
            _housers = other_housers;
            _name = hou._name;
            _numberOfUnities = hou._numberOfUnities;
        }

    }

}