using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Fight : EntityObject
    {
        public House _houseChallenger1 { get; private set; }
        public House _houseChallenger2 { get; private set; }

        public House _winningHouse { get; private set; }

        public Fight(House challenger1, House challenger2)
        {
            _houseChallenger1 = challenger1;
            _houseChallenger2 = _houseChallenger2;
        }

        public void SetWinner(House winner)
        {
            if (winner.Equals(_houseChallenger1) || winner.Equals(_houseChallenger2))
            {
                _winningHouse = winner;
            }
        }
    }
}
