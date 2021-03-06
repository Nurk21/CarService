﻿using CarService.Core.Entities.DetailsType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarService.Core.Entities.VehicleType
{
    
    public interface IBaseCar
    {
        [Key]
        public int Id { get; set; }
        public int BodyId { get; set; }
        public Body Body { get; set; }    
        public int BrakesId { get; set; }
        public Brakes Brakes { get; set; }
        public int UndercarriageId { get; set; }
        public Undercarriage Undercarriage { get; set; }

    }
}
