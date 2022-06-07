﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2019, DailyPrice = 350000, Description = "Hibrit Araba" },
                new Car{Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2021, DailyPrice = 850000, Description = "Elektrikli Araba" },
                new Car{Id = 3, BrandId = 2, ColorId = 1, ModelYear = 2020, DailyPrice = 650000, Description = "Hibrit Araba" },
                new Car{Id = 4, BrandId = 2, ColorId = 2, ModelYear = 2019, DailyPrice = 950000, Description = "Elektrikli Araba" },
                new Car{Id = 5, BrandId = 3, ColorId = 1, ModelYear = 2022, DailyPrice = 850000, Description = "Benzinli Araba" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
