using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Core.Entities.DetailsType
{
    public class Handrail : IBaseDetail 
    {
        public Handrail() { }
        public byte HandrailCondition { get; set; }
        public int Id { get; set; }
        public double RepairPrice { get; set; }
    }
}
