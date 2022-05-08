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
     
            //UserTest();
            //ColorTest();

            //BrandTest();

            //CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.Id + "--" + car.ModelYear + "--" + car.DailyPrice);

            }
        }

        private static void BrandTest()
        {
            BrandManeger brandManeger = new BrandManeger(new EfBrandDal());
            //brandManeger.Add(new Brand { Id = 11, Name = "Alfa Romeo" });
            //brandManeger.Delete(new Brand{ Id = 11, Name = "Alfa Romeo"});

            var result = brandManeger.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.Name);
                }
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { Id = 5, Name = "Turuncu" });
            //colorManager.Delete(new Color { Id = 5, Name = "Turuncu" });

            var result = colorManager.Delete(new Color { Id = 5, Name = "Turuncu" });

            Console.WriteLine(result.Message);
        }

        //private static void UserTest()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    //var result = userManager.Add(new User { Id = 2, FirstName = "Enes", LastName = "KILIÇ", Email = "asdadafca@Gmail.com", Password = "123" });
        //    var result = userManager.GetAll();
        //    foreach (var user in result.Data)
        //    {
        //        Console.WriteLine(user.Id + "--" + user.FirstName + "--" + user.LastName + "--" + user.Email + "--" + user.Password);
        //    }
        //}

    }
   
        
    }

