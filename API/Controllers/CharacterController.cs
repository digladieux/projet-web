using API.Models;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class CharacterController : ApiController
    {
        public List<CharacterAPI> GetAllCharacter()
        {
            List<CharacterAPI> liste = new List<CharacterAPI>();
            BusinessLayer.BusinessManager bm = new BusinessLayer.BusinessManager();

            foreach(Character character in bm.GetAllCharacters())
            {
                liste.Add(new CharacterAPI(character));
            }
            return liste;
        }
    }
}
