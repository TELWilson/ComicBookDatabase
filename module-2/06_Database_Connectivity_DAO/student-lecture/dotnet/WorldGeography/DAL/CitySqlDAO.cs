using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAO
    {
        private string connectionString;

        private string sqlGetCitiesByCountryCode = "SELECT * FROM city WHERE countrycode = @countrycode;";

        /// <summary>
        /// Creates a new sql-based city dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CitySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public void AddCity(City city)
        {
            throw new NotImplementedException();
        }

        public IList<City> GetCitiesByCountryCode(string countryCode)
        {
            IList<City> cities = new List<City>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sqlGetCitiesByCountryCode, conn);

                command.Parameters.AddWithValue("@countrycode", countryCode);
                

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    City city = new City();
                   
                    city.CityId = Convert.ToInt32(reader["id"]);
                    city.Name = Convert.ToString(reader["name"]);
                    city.CountryCode = Convert.ToString(reader["countrycode"]);
                    city.District = Convert.ToString(reader["district"]);
                    city.Population = Convert.ToInt32(reader["population"]);


                    cities.Add(city);
                }
            }





            return cities;
        }
    }

    }

