using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails (Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentaCarDbContext context = new RentaCarDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join clr in context.Colors on c.ColorId equals clr.Id
                             join ci in context.CarImages on c.Id equals ci.Id

                             select new CarDetailDto()
                             {
                                 Id = c.Id,
                                 BrandId = c.BrandId,
                                 BrandName = b.Name,
                                 ColorId = clr.Id,
                                 ColorName = clr.Name,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 Images = (from i in context.CarImages where i.CarId == c.Id select i.ImagePath).ToList()
                             };

                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }

 
    }
}