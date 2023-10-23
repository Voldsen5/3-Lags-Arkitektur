using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Car
    {
        public Car(int carId, string name) 
        {
            CarId = carId;
            Name = name;
        }

        public int CarId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0,50)]
        public int ModelYear { get; set; }
    }
}
