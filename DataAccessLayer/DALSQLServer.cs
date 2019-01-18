using EntitiesLayer;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class DALSQLServer : IDAL
    {
        public List<EntitiesLayer.Character> GetCharacters()
        {
            List<EntitiesLayer.Character> list = new List<EntitiesLayer.Character>();
            DataAccessLayer.BddGameOfThronesEntities bdd = new BddGameOfThronesEntities();

            foreach (DataAccessLayer.Characters ch in bdd.Characters)
            {
                list.Add(GetCharacter(ch));
            }

            return list;
        }

        private EntitiesLayer.Character GetCharacter(DataAccessLayer.Characters chr)
        {
            EntitiesLayer.Character ch = new EntitiesLayer.Character(chr.firstname, chr.lastname, chr.pv.Value, chr.bravoury.Value, chr.crazyness.Value);
            return ch;
        }

        public List<EntitiesLayer.House> GetHouses()
        {
            List<EntitiesLayer.House> list = new List<EntitiesLayer.House>();
            DataAccessLayer.BddGameOfThronesEntities bdd = new BddGameOfThronesEntities();

            foreach (DataAccessLayer.Houses ho in bdd.Houses)
            {
                list.Add(GetHouse(ho));
            }

            return list;
        }

        private EntitiesLayer.House GetHouse(DataAccessLayer.Houses hou)
        {
            EntitiesLayer.House ho = new EntitiesLayer.House(hou.name);
            return ho;
        }

        public List<EntitiesLayer.Territory> GetTerritories()
        {
            List<EntitiesLayer.Territory> list = new List<EntitiesLayer.Territory>();
            DataAccessLayer.BddGameOfThronesEntities bdd = new BddGameOfThronesEntities();

            foreach (DataAccessLayer.Territories te in bdd.Territories)
            {
                list.Add(GetTerritory(te, bdd));
            }

            return list;
        }

        private EntitiesLayer.Territory GetTerritory(DataAccessLayer.Territories ter)
        {
            throw new System.NotImplementedException();

            /*House house = bdd.House.Where(hou => hou.Id = ter.idHouse);
            Entities.Territory te = new Entities.Territory();*/

            return null;
        }

        public EntitiesLayer.Character MajCharacter(EntitiesLayer.Character ch)
        {
            throw new System.NotImplementedException();
        }

        public EntitiesLayer.House MajHouse(EntitiesLayer.House ho)
        {
            throw new System.NotImplementedException();
        }

        public EntitiesLayer.Territory MajTerritory(EntitiesLayer.Territory te)
        {
            throw new System.NotImplementedException();
        }

        public List<Fight> GetFights()
        {
            throw new System.NotImplementedException();
        }

        public List<War> GetWars()
        {
            throw new System.NotImplementedException();
        }
    }
}
