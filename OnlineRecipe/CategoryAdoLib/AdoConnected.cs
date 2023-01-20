using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace CategoryAdoLib
{
    public class AdoConnected : IDatabase
    {
        SqlConnection con;

        public AdoConnected()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RecipesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public List<Category> GetCategories()
        {
            var lstCat = new List<Category>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from category";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = con;

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            
            while(sdr.Read())
            {
                var c = new Category
                {
                    categoryId = sdr.GetInt32(0),
                    categoryName = sdr.GetString(1)
                };

                lstCat.Add(c);
            }

            return lstCat;
        }

        public List<Recipe> GetRecipesById(int cid)
        {
            var lstRec = new List<Recipe>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from recipe where categoryid=@cd";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@cd", cid);

            cmd.Connection = con;

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                var c = new Recipe
                {
                   categoryId=sdr.GetInt32(0),
                   recipeName=sdr.GetString(1),
                   picture=sdr.GetString(2),
                   description=sdr.GetString(3)
                };

                lstRec.Add(c);
            }

            return lstRec;
        }
    }
}
