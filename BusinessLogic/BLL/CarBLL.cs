using DTO.Model;
using CarDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BLL
{
    public class CarBLL
    {
        public Car getCar(int id)
        {
            if (id < 0) throw new IndexOutOfRangeException();
            return CarRepository.getCar(id);
        }

        public void AddCar(Car car)
        {
            CarRepository.AddCar(car);
        }

        public void EditCar(Car car)
        {

        }
    }
}
