using CarService.Core.Entities.VehicleType;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Services
{
    public interface IBaseService<T> where T : IBaseCar 
    {
        public int EstimatePrice();
        public void Repair();
    }
}
