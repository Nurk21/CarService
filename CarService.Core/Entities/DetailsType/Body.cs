using CarService.Core.Entities.VehicleType;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Core.Entities.DetailsType
{
    public class Body : IBaseDetail
    {
        public Body() { }
        public byte BodyCondition { get; set; }
        public int Id { get; set; }
        public double RepairPrice { get; set; }
        public Car Car { get; set; }
        public Bus Bus { get; set; }
        public Truck Truck { get; set; }
    }
}
