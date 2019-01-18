using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Territory : EntityObject
    {
        public House _owner { get; private set; }
        public TerritoryTypeEnum _territoryType;

        public Territory(House owner, TerritoryTypeEnum territoryType)
        {
            _owner = owner;
            _territoryType = territoryType;
        }

        public override string ToString()
        {
            return _owner + " " + _territoryType.ToString();
        }
    }
}
