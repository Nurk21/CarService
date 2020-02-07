using CarService.Core.Entities.DetailsType;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Core.Entities.VehicleType
{
    public class Bus : IBaseCar
    {
        public int Id { get; set; }
        public int BodyId { get; set; }
        public Body Body { get; set; }
        public int BrakesId { get; set; }
        public Brakes Brakes { get; set; }
        public int UndercarriageId { get; set; }
        public Undercarriage Undercarriage { get; set; }
        public int HandrailId { get; set; }
        public List<Handrail> Handrail { get; set; }
        public int CabinId { get; set; }
        public Cabin Cabin { get; set; }
    }
}
