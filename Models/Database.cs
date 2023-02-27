using System.Data;
using System.Data.SqlClient;

namespace Recept.Models
{
    public class Database
    {
        public List<Recept> GetRecept()
        {     
        string connectionString = "Data Source=localhost;Initial Catalog=RecipeDB;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM Recipe";

            var reader = cmd.ExecuteReader();

            var recept = new List<Recept>();

            while (reader.Read())
            {
                int = int.Parse(reader[]
            }

        }
       
    }
}
