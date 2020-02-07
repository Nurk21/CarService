using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Core.Entities.DetailsType
{
    public class Undercarriage : IBaseDetail
    {
        public Undercarriage() { }
        public byte UndercarriageCondition { get; set; }
        public int Id { get; set; }
        public double RepairPrice { get; set; }
    }
}
