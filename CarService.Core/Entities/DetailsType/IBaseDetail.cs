using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarService.Core.Entities.DetailsType
{
    public interface IBaseDetail
    {
        [Key]
        public int Id { get; set; }
        public double RepairPrice { get; set; } 
    }
}
