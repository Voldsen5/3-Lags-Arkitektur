using CarDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDataAccess.Mappers
{
    internal class CarMapper
    {
        public static DTO.Model.Car Map(Car car)
        {
            return new DTO.Model.Car(car.CarId, car.Name);
        }
        public static Car Map(DTO.Model.Car car)
        {
            return new Car(car.CarId, car.Name);
        }
    }
}
