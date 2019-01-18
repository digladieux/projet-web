using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class War : EntityObject
    {
        public List<Fight> _listFights { get; private set; }

        public War()
        {
            _listFights = new List<Fight>();
        }

        public War(List<Fight> listFights)
        {
            _listFights = listFights;
        }

        public void AddFight(Fight fight)
        {
            _listFights.Add(fight);
        }
    }
}
