using CarService.Core.Entities.VehicleType;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Core.Entities.DetailsType
{
    public class Undercarriage : IBaseDetail
    {
        public byte UndercarriageCondition { get; set; }
        public int Id { get; set; }
        public double RepairPrice { get; set; }
        public Car Car { get; set; }
        public Bus Bus { get; set; }
        public Truck Truck { get; set; }
    }
}
