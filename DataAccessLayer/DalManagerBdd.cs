using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalManagerBdd
    {

        private List<Character> _characters;
        private List<House> _houses;
        private List<Territory> _territories;

        public DalManagerBdd()
        {

            _characters = new List<Character>();
            _houses = new List<House>();
            _territories = new List<Territory>();

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "serveur-projet-web.database.windows.net";
            builder.UserID = "ServeurAdmin";
            builder.Password = "Groupe9!";
            builder.InitialCatalog = "BddGameOfThrones";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT *");
                sb.Append("FROM [dbo].[Characters]");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _characters.Add(new Character(reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5)));
                        }
                    }
                }

                sb.Clear();

                sb.Append("SELECT *");
                sb.Append("FROM [dbo].[Houses]");
                sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _houses.Add(new House(reader.GetString(1), reader.GetInt32(2)));
                        }
                    }
                }


            }
        }

        public List<Character> getAllCharacters()
        {
            return _characters;
        }

        public List<House> getAllHouses()
        {
            return _houses;
        }
        public List<Territory> getAllTerritories()
        {
            return _territories;
        }
        

    }
}
