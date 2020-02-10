using CarService.Core.Entities.VehicleType;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Core.Entities.DetailsType
{
    public class Cabin : IBaseDetail
    {
        public byte CabinCondition {get;set;}
        public int Id { get; set; }
        public double RepairPrice { get; set; }

        public Bus Bus { get; set; }
        
    }
}
