using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDataAccess.Model
{
    internal class Car
    {
        public Car() 
        {
        }

        public Car(string name) 
        {
            Name = name;
        }

        public Car(int carId, string name)
        {
            CarId = carId;
            Name = name;

        }

        public int CarId { get; set; }
        public string Name { get; set; }
    }
}
