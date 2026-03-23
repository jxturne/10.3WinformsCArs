using _10._3WinformsCArs.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace _10._3WinformsCArs.Services
{
    public class CRUD
    {
        public void AddCar(Car car)
        {
            Records.context.Cars.Add(car);
            Records.context.SaveChanges();

        }

        public List<Car> GetAllCars()
        {
            return Records.context.Cars.ToList();
        }

        public Car? FindCar(string vin)
        {
            return Records.context.Cars.Find(vin);
        }

        public void DeleteCar(string VIN)
        {
            var carinfo = Records.context.Cars.Find(VIN);
            if (carinfo != null)
            {
                Records.context.Cars.Remove(carinfo);
                Records.context.SaveChanges();
            }
        }

        public void UpdateCar(Car car)
        {
            var existingCar = Records.context.Cars.Find(car.VIN);
            if (existingCar != null)
            {
                existingCar.Make = car.Make;
                existingCar.Model = car.Model;
                existingCar.Year = car.Year;
                existingCar.Price = car.Price;
                Records.context.SaveChanges();
                
            }
            else
            {
                MessageBox.Show(" Vehicle information not found.");
            }
        }
    }
}

