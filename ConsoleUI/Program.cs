using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

           CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("isim        Id     Model      Günlük Ücreti     Açıklama");
            Console.WriteLine("___________________________________________________________");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + "      " + car.Id + "      " + car.ModelYear + "           " + car.DailyPrice + "         " + car.Description);
            }

            Console.WriteLine("\n\nBrandId'si 2 Olan Araçların Listelenmesi");
            Console.WriteLine("__________________________________________________");
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.CarName + "      " + car.Id + "      " + car.ModelYear + "           " + car.DailyPrice + "         " + car.Description);
            }

            Console.WriteLine("\n\nColorId'si 2 Olan Araçların Listelenmesi");
            Console.WriteLine("___________________________________________________");
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.CarName + "           " + car.Id + "      " + car.ModelYear + "           " + car.DailyPrice + "         " + car.Description);
            }
            Console.WriteLine("\n\nYeni Araç Ekleme Ve Tüm Listenin Tekrar Listelenmesi");
            Console.WriteLine("__________________________________________________");
            carManager.Add(new Car {CarName = "Nissa", BrandId = 2, ColorId = 2, DailyPrice = 1000, Description = "Nissan Juke", ModelYear = 2015 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + "      " + car.Id + "      " + car.ModelYear + "           " + car.DailyPrice + "         " + car.Description);
            }









            /*CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("------------GetAll--------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç : " + car.Description + " , Model : " +car.ModelYear + " , Günlük Fiyatı :  " + car.DailyPrice + " TL" );
            }

            Console.WriteLine("-------------GetById--------------");

           //foreach (var car in carManager.GetById(6))
           // {
                //Console.WriteLine("Araç : " + car.Description + " , Model : " + car.ModelYear + " , Günlük Fiyatı :  " + car.DailyPrice + " TL");
            //}

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
            Console.WriteLine(car2.Description + " Aracı silindi");*/









        }
    }
}
