using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace StubDataAccessLayer
{
    public class DalManager
    {
        private List<Character> _characters;
        private List<House> _houses;
        private List<Territory> _territories;
        
        public DalManager()
        {
            _characters = new List<Character>();
            _houses = new List<House>();
            _territories = new List<Territory>();

            Character john = new Character("John", "Snow", 100, 100, 30, 100);
            Character aria = new Character("Arai", "Stark", 100, 70, 50, 30);
            aria.AddRelatives(john, RelationshipEnum.FRIENDSHIP);
            john.AddRelatives(aria, RelationshipEnum.FRIENDSHIP);
            Character geofrey = new Character("Geofrey", "Baratheon", 100, 0, 99, 5);
            _characters.Add(john);
            _characters.Add(aria);
            _characters.Add(geofrey);

            House stark = new House("Stark");
            stark.AddHouser(john);
            stark.AddHouser(aria);
            stark.NumberOfUnits = 500;
            House baratheon = new House("Baratheon");
            baratheon.AddHouser(geofrey);
            baratheon.NumberOfUnits = 500;
            _houses.Add(stark);
            _houses.Add(baratheon);

            Territory mountain = new Territory(TerritoryType.MOUNTAIN, stark);
            Territory desert = new Territory(TerritoryType.DESERT, baratheon);
            _territories.Add(mountain);
            _territories.Add(desert);
        }

        public List<Character> getAllCharacters()
        {
            return _characters;
        }

        public List<House> getAllHouses()
        {
            return _houses;
        }

        public List<House> getAllBigHouses()
        {
            return (from house in _houses where house.NumberOfUnits >= 200 select house).ToList();
        }

        public List<Territory> getAllTerritories()
        {
            return _territories;
        }

        /*public ?? getAllCaracteristics()
        {

        }*/
    }
}
