using Microsoft.EntityFrameworkCore;

namespace DB_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new MyDbContext())
            {
                Car newCar1 = new Car { RegPlate = "1E15871", Brand = "Toyota", Model = "Corolla", Purchased = DateTime.Now };
                dbContext.Cars.Add(newCar1);

                Car newCar2 = new Car { RegPlate = "4L29114", Brand = "Volkswagen", Model = "Golf", Purchased = DateTime.Now };
                dbContext.Cars.Add(newCar2);
                dbContext.SaveChanges();

                Console.WriteLine("Výpis aut");

                var cars = dbContext.Cars.ToList();
                foreach (var car in cars)
                    Console.WriteLine($"{car.Brand} {car.Model} ({car.RegPlate})");

                Console.WriteLine();
                Console.WriteLine("Výpis řidiču s auty");

                Driver newDriver1 = new Driver { Name = "John", Surname = "Doe", Car = newCar2};
                dbContext.Drivers.Add(newDriver1);
                Driver newDriver2 = new Driver { Name = "Tom", Surname = "Black"};
                dbContext.Drivers.Add(newDriver2);
                dbContext.SaveChanges();

                var drivers = dbContext.Drivers.ToList();
                foreach (var driver in drivers)
                {
                    Console.WriteLine($"{driver.Surname}, {driver.Name} ({driver.Car?.RegPlate})");

                }


                //rozšíření o zpětné vazby - eager loading
                Console.WriteLine();
                Console.WriteLine("Výpis aut s řidiči");

                cars = dbContext.Cars.Include(c => c.Driver).ToList();
                foreach (var car in cars)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} ({car.RegPlate}) : {car.Driver?.Surname}, {car.Driver?.Name}");
                }

                //Uklidím po sobě
                var allDrivers = dbContext.Drivers.ToList();
                foreach (var driver in allDrivers)
                {
                    dbContext.Drivers.Remove(driver);
                }
                dbContext.SaveChanges();


                var allCars = dbContext.Cars.ToList();
                foreach (var car in allCars)
                {
                    dbContext.Cars.Remove(car);
                }

                dbContext.SaveChanges();
            }


        }
    }
}
