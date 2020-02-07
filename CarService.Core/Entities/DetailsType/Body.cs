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
    }
}
