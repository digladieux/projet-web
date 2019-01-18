using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Character : EntityObject
    {
        public int _id { get; private set; }
        public int _bravoury { get; private set; }
        public int _crazyness { get; private set; }
        public string _firstName { get; private set; }
        public string _lastName { get; private set; }
        public int _pv { get; private set; }
        public Dictionary<Character, RelationShipEnum> _relationships { get; private set; }

        public Character(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _bravoury = 0;
            _crazyness = 0;
            _relationships = new Dictionary<Character, RelationShipEnum>();
        }

        public Character(string firstName, string lastName, int pv)
        {
            _firstName = firstName;
            _lastName = lastName;
            _pv = pv;
            _bravoury = 0;
            _crazyness = 0;
            _relationships = new Dictionary<Character, RelationShipEnum>();
        }

        public Character(string firstName, string lastName, int pv, int bravoury, int crazyness, Dictionary<Character, RelationShipEnum> relationships = null)
        {
            _firstName = firstName;
            _lastName = lastName;
            _pv = pv;
            _bravoury = bravoury;
            _crazyness = crazyness;
            _relationships = relationships;
        }

        public Character(int id, string firstName, string lastName, int pv, int bravoury, int crazyness, Dictionary<Character, RelationShipEnum> relationships = null)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _pv = pv;
            _bravoury = bravoury;
            _crazyness = crazyness;
            _relationships = relationships;
        }

        public void addRelatives(Character relatives, RelationShipEnum relation)
        {
            _relationships.Add(relatives, relation);
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName + " : " + _pv + "hp / " + _crazyness + " / " + _bravoury;
        }
    }
}
