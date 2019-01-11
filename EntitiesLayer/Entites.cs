using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class EntityObject
    {
        protected int _id;
        private static int _id_count = 0;

        public EntityObject()
        {
            _id = _id_count++;
        }
    }

    // enums
    public enum RelationshipEnum { FRIENDSHIP, LOVE, HATRED, RIVALRY }
    public enum CharacterTypeEnum { WARRIOR, WITCH, TACTICIAN, LEADER, LOSER }
    public enum TerritoryType { SEA, MOUNTAIN, LAND, DESERT }

    public class Character: EntityObject
    {
        protected int _bravoury;
        protected int _crazyness;
        protected string _firstName;
        protected string _lastName;
        protected int _pv;
        protected int _strength;
        protected List<Character> _relationships;
        protected List<RelationshipEnum> _relationshipType;

        public int Bravoury { get => _bravoury; set => _bravoury = value; }
        public int Crazyness { get => _crazyness; set => _crazyness = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Pv { get => _pv; set => _pv = value; }
        public List<Character> Relationships { get => _relationships; set => _relationships = value; }
        public int Strength { get => _strength; set => _strength = value; }

        // ctor
        public Character(string firstname = "", string lastname = "", int pv = 100, int bravoury = 50, int crazyness = 50, int strenght = 50)
        {
            _firstName = firstname;
            _lastName = lastname;
            _pv = pv;
            _bravoury = bravoury;
            _crazyness = crazyness;
            _strength = strenght;
            _relationships = new List<Character>();
            _relationshipType = new List<RelationshipEnum>();
        }
        public void AddRelatives(Character relative, RelationshipEnum type)
        {
            _relationships.Add(relative);
            _relationshipType.Add(type);
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName + " " + _pv + " " + _bravoury + " " + _crazyness + " " + _strength;
        }
    }

    public class House: EntityObject
    {
        protected string _name;
        protected List<Character> _houser;
        protected int _numberOfUnits;

        public string Name { get => _name; set => _name = value; }
        public List<Character> Houser { get => _houser; set => _houser = value; }
        public int NumberOfUnits { get => _numberOfUnits; set => _numberOfUnits = value;  }

        public House(string name = "")
        {
            _name = name;
            _houser = new List<Character>();
        }

        public void AddHouser(Character perso)
        {
            _houser.Add(perso);
        }

        public override string ToString()
        {
            string line = _name+"\n";
            foreach(var houser in _houser)
                line += houser.ToString()+"\n";
            return line;
        }
    }

    public class Fight: EntityObject
    {
        protected House _house1;
        protected House _house2;
        protected House _winner;

        public Fight(House a, House b, House winner)
        {
            _house1 = a;
            _house2 = b;
            _winner = winner;
        }

        public House House1 { get => _house1; set => _house1 = value; }
        public House House2 { get => _house1; set => _house1 = value; }
        public House Winner { get => _winner; set => _winner = value; }

        public override string ToString()
        {
            return _house1.ToString() + "VS\n" + _house2.ToString() + "Winner = " + _winner.ToString();
        }
    }

    public class Territory: EntityObject
    {
        protected TerritoryType _territoryType;
        protected House _owner;

        public House Owner { get => _owner; set => _owner = value; }

        public Territory(TerritoryType type, House owner)
        {
            _territoryType = type;
            _owner = owner;
        }

        public override string ToString()
        {
            return _owner.Name + " own " + _territoryType;
        }
    }

    public class War
    {
        protected List<EntityObject> _obj;

        public War()
        {
            _obj = new List<EntityObject>();
        }

        public void Add(EntityObject o)
        {
            _obj.Add(o);
        }
    }
}
