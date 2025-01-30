using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAP_BaiTap_01
{
    /// <summary>
    /// Summary description for WorldService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WorldService : System.Web.Services.WebService
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["WorldDb"].ConnectionString;
        [WebMethod]
        public List<Country> GetAllCountries()
        {
            var countries = new List<Country>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM country";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    countries.Add(new Country
                    {
                        Code = reader["Code"].ToString(),
                        Name = reader["Name"].ToString(),
                        Continent = reader["Continent"].ToString(),
                        Population = Convert.ToInt32(reader["Population"])
                    });
                }
            }
            return countries;
        }

        [WebMethod]
        public Country GetCountryByCode(string countryCode)
        {
            Country country = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM country WHERE Code = @Code";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Code", countryCode);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    country = new Country
                    {
                        Code = reader["Code"].ToString(),
                        Name = reader["Name"].ToString(),
                        Continent = reader["Continent"].ToString(),
                        Population = Convert.ToInt32(reader["Population"])
                    };
                }
            }
            return country;
        }

        [WebMethod]
        public List<City> GetCitiesByCountry(string countryCode)
        {
            var cities = new List<City>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM city WHERE CountryCode = @CountryCode";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CountryCode", countryCode);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cities.Add(new City
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Name = reader["Name"].ToString(),
                        District = reader["District"].ToString(),
                        Population = Convert.ToInt32(reader["Population"])
                    });
                }
            }
            return cities;
        }

        [WebMethod]
        public City GetCityByName(string cityName)
        {
            City city = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM city WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", cityName);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    city = new City
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Name = reader["Name"].ToString(),
                        District = reader["District"].ToString(),
                        Population = Convert.ToInt32(reader["Population"])
                    };
                }
            }
            return city;
        }
        [WebMethod]
        public List<string> GetAllContinents()
        {
            var continents = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT DISTINCT Continent FROM country";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    continents.Add(reader["Continent"].ToString());
                }
            }
            return continents;
        }
    }

}
