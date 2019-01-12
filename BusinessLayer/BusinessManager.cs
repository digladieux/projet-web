using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using StubDataAccessLayer;

namespace BusinessLayer
{
    public class BusinessManager
    {
        protected List<Fight> _fights;
        //  protected DalManager dalManager;
          protected DataAccessLayer.DalManagerBdd dalManager;

        public BusinessManager()
        {
            dalManager = new DataAccessLayer.DalManagerBdd();
            _fights = new List<Fight>();

            List<House> houses = dalManager.getAllHouses();

            Fight bataille1 = new Fight(houses[0], houses[1], houses[0]);
            _fights.Add(bataille1);
        }

        public List<Fight> getAllFights()
        {
            return _fights;
        }

        public List<Character> getAllCharacters()
        {
            return dalManager.getAllCharacters();
        }

        public List<House> getAllHouses()
        {
            return dalManager.getAllHouses();
        }
        /*
        public List<House> getAllBigHouses()
        {
            return dalManager.getAllBigHouses();
        }
        */
        public List<Character> getStrongNMidLifeCharacters()
        {
            return (from character in dalManager.getAllCharacters() where character.Strength > 3 && character.Pv > 500 select character).ToList();
        }

        public List<Territory> getAllTerritories()
        {
            return dalManager.getAllTerritories();
        }

        public List<Fight> Fights { get => _fights; set => _fights = value; }
    }
}
