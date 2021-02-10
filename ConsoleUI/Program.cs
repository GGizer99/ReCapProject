using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("------------GetAll--------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç : " + car.Description + " , Model : " +car.ModelYear + " , Günlük Fiyatı :  " + car.DailyPrice + " TL" );
            }

            Console.WriteLine("------------GetById--------------");

            foreach (var car in carManager.GetById(6))
            {
                Console.WriteLine("Araç : " + car.Description + " , Model : " + car.ModelYear + " , Günlük Fiyatı :  " + car.DailyPrice + " TL");
            }

            Console.WriteLine("------------Add--------------");

            Car car1 = new Car()
            {
                Id = 7,
                BrandId = 5,
                ColorId = 6,
                ModelYear = 2021,
                DailyPrice = 500,
                Description = "Renault Megane 1.5 DCi Icon EDC"
            };

            carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç : " + car.Description + " , Model : " + car.ModelYear + " , Günlük Fiyatı :  " + car.DailyPrice + " TL");
            }

            Console.WriteLine("------------Update--------------");
            

            Car car2 = new Car() {
            Id = 6,
            BrandId = 4,
            ColorId = 1,
            ModelYear = 2020,
            DailyPrice = 300,
            Description = "Jeep Renegade 1.6 Multijet Limited AT"
            };
           
            carManager.Update(car2);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç : " + car.Description + " , Model : " + car.ModelYear + " , Günlük Fiyatı :  " + car.DailyPrice + " TL");
            }
            Console.WriteLine("---------------------------------");

            Console.WriteLine(" 6 NOLU ARACIN DailyPrice ' ı güncellendi ");

            Console.WriteLine("------------Delete--------------");

            carManager.Delete(car2);
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç : " + car.Description + " , Model : " + car.ModelYear + " , Günlük Fiyatı :  " + car.DailyPrice + " TL");
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine(car2.Description + " Aracı silindi");









        }
    }
}
