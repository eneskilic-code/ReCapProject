using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentaCarDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (RentaCarDbContext context = new RentaCarDbContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.Id
                             join u in context.Users
                             on c.UserId equals u.Id
                             join cr in context.Cars
                             on r.CarId equals cr.Id
                             join b in context.Brands
                             on cr.BrandId equals b.Id
                             join cl in context.Colors
                             on cr.ColorId equals cl.Id
                             select new RentalDetailDto()
                             {
                                 RentalId = r.Id,
                                 CustomerId = c.Id,
                                 CompanyName = c.CompanyName,
                                 UserId = c.UserId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 EMail = u.Email,
                                 CarId = r.CarId,
                                 CarName = cr.Description,
                                 BrandId = cr.BrandId,
                                 BrandName = b.Name,
                                 ColorId = cr.ColorId,
                                 ColorName = cl.Name,
                                 ModelYear = cr.ModelYear,
                                 DailyPrice = cr.DailyPrice,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
