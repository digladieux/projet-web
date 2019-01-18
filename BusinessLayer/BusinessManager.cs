using System.Collections.Generic;
using System.Linq;
using EntitiesLayer;

namespace BusinessLayer
{
    public class BusinessManager
    {
        public List<Character> GetAllCharacterFort()
        {
            DataAccessLayer.DALManager manager = DataAccessLayer.DALManager.Instance;
            List<Character> list = manager._DALServer.GetCharacters();
            return list.Where(c => c._pv > 50 && c._bravoury > 3).ToList();
        }

        public IEnumerable<War> GetAllWars()
        {
            DataAccessLayer.DALManager manager = DataAccessLayer.DALManager.Instance;
            List<War> list = manager._DALServer.GetWars();

            return list;
        }

        public IEnumerable<Fight> GetAllFights()
        {
            DataAccessLayer.DALManager manager = DataAccessLayer.DALManager.Instance;
            List<Fight> list = manager._DALServer.GetFights();

            return list;
        }


        public IEnumerable<object> GetAllCharacters()
        {
            DataAccessLayer.DALManager manager = DataAccessLayer.DALManager.Instance;
            List<Character> list = manager._DALServer.GetCharacters();
            return list;
        }

        public List<House> GetAllHouses()
        {
            DataAccessLayer.DALManager manager = DataAccessLayer.DALManager.Instance;
            return manager._DALServer.GetHouses();
        }


        public List<EntitiesLayer.House> GetAllHousesWith200Units()
        {
            DataAccessLayer.DALManager manager = DataAccessLayer.DALManager.Instance;
            List<House> list = manager._DALServer.GetHouses();
            return list.Where(c => c._numberOfUnities > 200).ToList();
        }


        public List<Territory> GetAllTerritories()
        {
            DataAccessLayer.DALManager manager = DataAccessLayer.DALManager.Instance;
            return manager._DALServer.GetTerritories();
        }
    }
}
