//Tento projekt vyžaduje v nuget manageru přidat balíčky 
//- EntityFrameworkCore
//- EntityFrameworkCore.Relational
//- EntityFrameworkCore.SqlServer

using Microsoft.EntityFrameworkCore;

namespace DB_EF_Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vložím do db
            using (var dbContext = new MyDbContext())
            {
                Car newCar;

                newCar = new Car { RegPlate = "1E15871", Brand = "Toyota", Model = "Corolla", Purchased = DateTime.Now };
                dbContext.Cars.Add(newCar);
                dbContext.SaveChanges();

                newCar = new Car { RegPlate = "4L29114", Brand = "Volkswagen", Model = "Golf", Purchased = DateTime.Now };
                dbContext.Cars.Add(newCar);
                dbContext.SaveChanges();
            }


            //vylistuju
            using (var dbContext = new MyDbContext())
            {
                var cars = dbContext.Cars.ToList();
                foreach (var car in cars)
                    Console.WriteLine($"{car.Brand} {car.Model} ({car.RegPlate})");

                Console.WriteLine();
            }

            //vyberu konkrétní
            using (var dbContext = new MyDbContext())
            {
                var car = dbContext.Cars.FirstOrDefault(c => c.Brand == "Toyota");
                Console.WriteLine($"{car.Brand} {car.Model} ({car.RegPlate})"); //vypíšu ho
                Console.WriteLine();

                car.Model = "Yaris";
                dbContext.SaveChanges();
            }

            //vylistuju
            using (var dbContext = new MyDbContext())
            {
                var cars = dbContext.Cars.ToList();
                foreach (var car in cars)
                    Console.WriteLine($"{car.Brand} {car.Model} ({car.RegPlate})");

                Console.WriteLine();
            }

            //uklidím po sobě - to bych v realitě nedělal, tam chci mít data trvalá
            using (var dbContext = new MyDbContext())
            {
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
