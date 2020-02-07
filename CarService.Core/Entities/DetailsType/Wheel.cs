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
    }
}
