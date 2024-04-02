//Tento projekt vyžaduje v nuget manageru přidat balíček System.Data.SqlClient
using System.Data.SqlClient;

namespace DB_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PR2Temp2;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            /* Select */

            //Select all
            //ShowAllCars(connectionString);
            //Console.WriteLine();

            ////Select by brand
            //ShowAllCarsByBrand(connectionString, "Škoda");
            //Console.WriteLine();


            /* CRUD */

            //Insert
            //int newCarId = AddCar(connectionString, "1A111A1", "Citroën", "2CV", DateTime.ParseExact("12.7.2023", "d.M.yyyy", null));
            //Console.WriteLine(newCarId);

            //GetAllCars(connectionString);
            //Console.WriteLine();

            ////Update
            //ModifyCar(connectionString, newCarId, "3E33257", "Škoda", "Zadeq", DateTime.ParseExact("1.7.2019", "d.M.yyyy", null));
            //SelectAllCars(connectionString);
            //Console.WriteLine();

            ////Delete
            //DeleteCar(connectionString, newCarId);
            //SelectAllCars(connectionString);
            //Console.WriteLine();


            /* Play with FK: drivers */

            //int carId1 = AddCar(connectionString, "1A111A1", "Citroën", "2CV", DateTime.ParseExact("12.7.2023", "d.M.yyyy", null));
            //int carId2 = AddCar(connectionString, "3E97259", "Ford", "Mondeo", DateTime.ParseExact("29.6.2010", "d.M.yyyy", null));

            //int driverId1 = AddDriver(connectionString, "Thomas", "Pinkerton");
            //int driverId2 = AddDriver(connectionString, "Guybrush", "Threepwood");

            //PutDriverToCar(connectionString, carId1, driverId2);

            //ShowCarsWithDrivers(connectionString);

            //DeleteDriver(connectionString, driverId1);
            //DeleteDriver(connectionString, driverId2);
            //DeleteCar(connectionString, carId1);
            //DeleteCar(connectionString, carId2);
        }

        static void ShowAllCars(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Cars";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);

                            //string regPlate = reader.GetString(1); 
                            //nebo
                            string regPlate = (string)reader["RegPlate"];

                            string brand = reader.GetString(2);
                            string model = reader.GetString(3);
                            DateTime purchased = reader.GetDateTime(4);

                            Console.WriteLine($"Id: {id}, RegPlate: {regPlate}, Brand: {brand}, Model: {model}, Purchased: {purchased}");
                        }
                    }
                }
            }
        }

        static void ShowAllCarsByBrand(string connectionString, string brand)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Cars WHERE Brand=@Brand";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Brand", brand);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string regPlate = reader.GetString(1); //nebo (string)reader["RegPlate"];
                        string model = reader.GetString(3);
                        DateTime purchased = reader.GetDateTime(4);

                        Console.WriteLine($"Id: {id}, RegPlate: {regPlate}, Brand: {brand}, Model: {model}, Purchased: {purchased}");
                    }
                }
                
            }
        }

        static int AddCar(string connectionString, string regPlate, string brand, string model, DateTime purchased)
        { 
            string query = "INSERT INTO Cars (RegPlate, Brand, Model, Purchased) VALUES (@RegPlate, @Brand, @Model, @Purchased); SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RegPlate", regPlate);
                command.Parameters.AddWithValue("@Brand", brand);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@Purchased", purchased);

                connection.Open();
                int insertedId = Convert.ToInt32(command.ExecuteScalar());
                return insertedId;
            }

        }

        static void ModifyCar(string connectionString, int id, string regPlate, string brand, string model, DateTime purchased)
        {
            string query = "UPDATE Cars SET RegPlate=@RegPlate, Brand=@Brand, Model=@Model, Purchased=@Purchased  WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RegPlate", regPlate);
                command.Parameters.AddWithValue("@Brand", brand);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@Purchased", purchased);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        static void DeleteCar(string connectionString, int id)
        {
            string query = "DELETE FROM Cars WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        static int AddDriver(string connectionString, string name, string surname)
        {
            string query = "INSERT INTO Drivers (Name, Surname) VALUES (@Name, @Surname); SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surname", surname);

                connection.Open();
                int insertedId = Convert.ToInt32(command.ExecuteScalar());
                return insertedId;
            }

        }

        static void PutDriverToCar(string connectionString, int carId, int driverId)
        {
            string query = "UPDATE Drivers SET CarId=@CarId WHERE Id=@DriverId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CarId", carId);
                command.Parameters.AddWithValue("@DriverId", driverId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        static void DeleteDriver(string connectionString, int id)
        {
            string query = "DELETE FROM Drivers WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        static void ShowCarsWithDrivers(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT Cars.Id, Cars.RegPlate, Cars.Brand, Cars.Model, Cars.Purchased,
                                    Drivers.Id AS DriverId, Drivers.Name, Drivers.Surname
                             FROM Cars
                             LEFT JOIN Drivers ON Cars.Id = Drivers.CarId";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int carId = reader.GetInt32(0);
                    string regPlate = reader.GetString(1);
                    string brand = reader.GetString(2);
                    string model = reader.GetString(3);
                    DateTime purchased = reader.GetDateTime(4);

                    int? driverId = reader.IsDBNull(5) ? null : (int?)reader.GetInt32(5);
                    string driverName = reader.IsDBNull(6) ? "N/A" : reader.GetString(6);
                    string driverSurname = reader.IsDBNull(7) ? "N/A" : reader.GetString(7);

                    Console.WriteLine($"Car ID: {carId}, RegPlate: {regPlate}, Brand: {brand}, Model: {model}, Purchased: {purchased.ToShortDateString()}, Driver ID: {(driverId.HasValue ? driverId.ToString() : "N/A")}, Driver Name: {driverName}, Driver Surname: {driverSurname}");
                }

                reader.Close();
            }

        }

    }
}
