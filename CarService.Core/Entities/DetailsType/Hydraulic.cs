using CarService.Core.Entities.VehicleType;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Core.Entities.DetailsType
{
    public class Hydraulic : IBaseDetail
    {
        public Hydraulic() { }
        public byte HydraulicCondition { get; set; }
        public int Id { get; set; }
        public double RepairPrice { get; set; }
        public Truck Truck { get; set; }
    }
}
