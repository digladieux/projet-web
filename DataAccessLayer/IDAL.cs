using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDAL
    {
        List<EntitiesLayer.Character> GetCharacters();
        EntitiesLayer.Character MajCharacter(EntitiesLayer.Character ch);

        List<EntitiesLayer.House> GetHouses();
        EntitiesLayer.House MajHouse(EntitiesLayer.House ho);

        List<EntitiesLayer.Territory> GetTerritories();
        EntitiesLayer.Territory MajTerritory(EntitiesLayer.Territory te);

        List<EntitiesLayer.Fight> GetFights();
        List<EntitiesLayer.War> GetWars();


        /* List<Entities.Fight> GetFights();
         Entities.Fight MajFight(Entities.Fight fi);

         List<Entities.War> GetWars();
         Entities.War MajWar(Entities.War wa);*/

    }
}
