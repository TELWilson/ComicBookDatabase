using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using WorldGeography.DAL;
using WorldGeography.Models;

namespace World_GeographyTest
{
    [TestClass]
    public class CitySqlDAOTest
    {
        private string connectionString = "Server=.\\SQLEXPRESS;Database=World;Trusted_Connection=True;";

        [TestMethod]
        public void AddCityTest()
        {
            int countBefore = 0;
            int countAfter = 0;
            //Arrange
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction;
                conn.Open();
                transaction = conn.BeginTransaction();

                
                SqlCommand command = new SqlCommand("SELECT count(*) FROM city;", conn, transaction);

                countBefore = (int)command.ExecuteScalar();



                CitySqlDAO dao = new CitySqlDAO(connectionString);
                City city = new City();
                city.Name = "Johntown";
                city.CountryCode = "GBR";
                city.Population = 4;
                city.District = "England";


                //Act
                dao.AddCity(city);


               
                command = new SqlCommand("SELECT count(*) FROM city;", conn, transaction);

                countAfter = (int)command.ExecuteScalar();


                //Assert
                Assert.AreEqual(countBefore + 1, countAfter);

                transaction.Rollback();
            }
        }
    }
}
