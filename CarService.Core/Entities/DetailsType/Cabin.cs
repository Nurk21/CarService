using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Core.Entities.DetailsType
{
    public class Cabin : IBaseDetail
    {
        public Cabin() { }
        public byte CabinCondition {get;set;}
        public int Id { get; set; }
        public double RepairPrice { get; set; }
    }
}
