using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class CharacterAPI
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Pv { get; set; }

        public CharacterAPI() { }

        public CharacterAPI(Character cha)
        {
            Id = cha._id;
            FirstName = cha._firstName;
            LastName = cha._lastName;
            Pv = cha._pv;
        }
    }


}