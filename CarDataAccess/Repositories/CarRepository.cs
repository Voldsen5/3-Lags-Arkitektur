using DTO.Model;
using CarDataAccess.Context;
using CarDataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDataAccess.Repositories
{
    public class CarRepository
    {
        public static Car getCar(int id)
        {
            using (CarContext context = new CarContext())
            {
                return CarMapper.Map(context.Cars.Find(id));
            }
        }
        
        public static void AddCar(Car car)
        {
            using (CarContext context = new CarContext())
            {
                context.Cars.Add(CarMapper.Map(car));
                context.SaveChanges();
            }
        }

    }
}
