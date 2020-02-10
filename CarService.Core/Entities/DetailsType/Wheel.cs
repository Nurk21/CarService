using CarService.Core.Entities.VehicleType;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Core.Entities.DetailsType
{
    public class Wheel : IBaseDetail
    {
        public Wheel() { }
        public byte WheelCondition { get; set; }
        public int Id { get; set; }
        public double RepairPrice { get; set; }

        public Car Car { get; set; }
        public int CarId { get; set; }
        public Bus Bus { get; set; }
        public int BusId { get; set; }
        public Truck Truck { get; set; }
        public int TruckId { get; set; }
    }
}
