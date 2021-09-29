using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace projektas
{
    public class CarService
    {
        private string _connection;
        public CarService()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .Build();

            _connection = config.GetValue<string>("ConnectionStrings:DefaultConnection");
        }

        public List<Car> GetCars()
        {
            MySqlConnection conn = new MySqlConnection(_connection);

            conn.Open();

            var cars = new List<Car>();

            using(var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT documentId, name, price, carDate FROM cars";

                var reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var car = new Car(
                            Convert.ToInt32(reader.GetString(0)),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3)
                            );

                        cars.Add(car);
                    }
                }
            }
            return cars;
        }

        public Car GetCars(string documentId)
        {
            MySqlConnection conn = new MySqlConnection(_connection);

            conn.Open();

            using(var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT documentId, name, price, carDate FROM cars WHERE documentId = @documentId";

                cmd.Parameters.Add(
                  new MySqlParameter()
                  {
                      ParameterName = "@documentId",
                      DbType = System.Data.DbType.String,
                      Value = documentId
                  }
                );


                var reader = cmd.ExecuteReader();
                using (reader)
                {
                    reader.Read();

                    return new Car(
                      Convert.ToInt32(reader.GetString(0)),
                      reader.GetString(1),
                      reader.GetInt32(2),
                      reader.GetInt32(3)
                     ); ;
                }
            }

        }

        public void CreateCar(Car car)
        {
            MySqlConnection conn = new MySqlConnection(_connection);

            conn.Open();

            using(var cmd = conn.CreateCommand())
                { 
                cmd.CommandText = "INSERT INTO cars (documentId, name, price, carDate) " + 
                    "VALUES(@documentId, @name, @price, @carDate)";

                cmd.Parameters.Add(
               new MySqlParameter()
               {
                   ParameterName = "@documentId",
                   DbType = System.Data.DbType.String,
                   Value = car.DocumentId
               }
             );

                cmd.Parameters.Add(
                new MySqlParameter()
                {
                    ParameterName = "@name",
                    DbType = System.Data.DbType.String,
                    Value = car.Name
                }
              );

                cmd.Parameters.Add(
                new MySqlParameter()
                {
                    ParameterName = "@price",
                    DbType = System.Data.DbType.String,
                    Value = car.Price
                }
              );

                cmd.Parameters.Add(
                new MySqlParameter()
                {
                    ParameterName = "@carDate",
                    DbType = System.Data.DbType.DateTime,
                    Value = car.CarDate
                }
              );

                cmd.ExecuteNonQuery();
            }
        }
    }
}
