using CarService.Core.Entities.VehicleType;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.DataAccess.DataBase
{
    public class DataContext : DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        
        
    }
}
