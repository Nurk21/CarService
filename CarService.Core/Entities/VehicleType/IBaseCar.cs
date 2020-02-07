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

    }
}
