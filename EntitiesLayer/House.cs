using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class House : EntityObject
    {
        public List<Character> _housers { get; private set; }
        public string _name { get; private set; }
        public int _numberOfUnities { get; private set; }

        public House(string name)
        {
            _name = name;
            _housers = new List<Character>();
            _numberOfUnities = 0;
        }

        public House(string name, List<Character> housers)
        {
            _name = name;
            _housers = housers;
            _numberOfUnities = housers.Count;
        }

        public void AddHousers(Character chararacter)
        {
            _housers.Add(chararacter);
            ++_numberOfUnities;
        }

        public override string ToString()
        {
            return _name + " : " + _numberOfUnities;
        }
    }
}
