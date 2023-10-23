using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDataAccess.Context
{
    internal class CarInitializer : CreateDatabaseIfNotExists<CarContext>
    {
        protected override void Seed(CarContext context)
        {
            context.Cars.Add(new Model.Car("Mercedes"));
            context.Cars.Add(new Model.Car("Audi"));
            context.Cars.Add(new Model.Car("Volvo"));
            context.SaveChanges();
        }

        private void dummy()
        {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }
    }
}
