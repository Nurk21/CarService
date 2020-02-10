using CarService.Core.Entities.DetailsType;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder
                .Entity<Body>(x =>
                {
                    x.HasKey(y => y.Id);
                    x.ToTable("Bodies");

                    x.HasOne(u => u.Car)
                     .WithOne(p => p.Body)
                     .HasForeignKey<Car>(p => p.BodyId)
                     .OnDelete(DeleteBehavior.Cascade);

                    x.HasOne(u => u.Bus)
                     .WithOne(p => p.Body)
                     .HasForeignKey<Bus>(p => p.BodyId)
                     .OnDelete(DeleteBehavior.Cascade);

                    x.HasOne(u => u.Truck)
                     .WithOne(p => p.Body)
                     .HasForeignKey<Truck>(p => p.BodyId)
                     .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder
                .Entity<Brakes>(x =>
                {
                    x.HasKey(y => y.Id);
                    x.ToTable("Brakess");

                    x.HasOne(u => u.Car)
                     .WithOne(p => p.Brakes)
                     .HasForeignKey<Car>(p => p.BrakesId)
                     .OnDelete(DeleteBehavior.Cascade);

                    x.HasOne(u => u.Bus)
                     .WithOne(p => p.Brakes)
                     .HasForeignKey<Bus>(p => p.BrakesId)
                     .OnDelete(DeleteBehavior.Cascade);

                    x.HasOne(u => u.Truck)
                     .WithOne(p => p.Brakes)
                     .HasForeignKey<Truck>(p => p.BrakesId)
                     .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder
                .Entity<Undercarriage>(x =>
                {
                    x.HasKey(y => y.Id);
                    x.ToTable("Undercarriages");

                    x.HasOne(u => u.Car)
                     .WithOne(p => p.Undercarriage)
                     .HasForeignKey<Car>(p => p.UndercarriageId)
                     .OnDelete(DeleteBehavior.Cascade);

                    x.HasOne(u => u.Bus)
                     .WithOne(p => p.Undercarriage)
                     .HasForeignKey<Bus>(p => p.UndercarriageId)
                     .OnDelete(DeleteBehavior.Cascade);

                    x.HasOne(u => u.Truck)
                     .WithOne(p => p.Undercarriage)
                     .HasForeignKey<Truck>(p => p.UndercarriageId)
                     .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder
                .Entity<Wheel>(x =>
                {
                    x.HasKey(y => y.Id);
                    x.ToTable("Wheels");                 

                    x.HasOne(u => u.Car)
                     .WithMany(p => p.Wheels)
                     .HasForeignKey(p => p.CarId)
                     .OnDelete(DeleteBehavior.NoAction);

                    x.HasOne(u => u.Bus)
                     .WithMany(p => p.Wheels)
                     .HasForeignKey(p => p.BusId)
                     .OnDelete(DeleteBehavior.NoAction);

                    x.HasOne(u => u.Truck)
                     .WithMany(p => p.Wheels)
                     .HasForeignKey(p => p.TruckId)
                     .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder
                .Entity<Cabin>(x =>
                {
                    x.HasKey(e => e.Id);
                    x.ToTable("Cabins");                    

                    x.HasOne(u => u.Bus)
                     .WithOne(u => u.Cabin)
                     .HasForeignKey<Bus>(t => t.CabinId)
                     .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder
                .Entity<Handrail>(x =>
                {
                    x.HasKey(y => y.Id);
                    x.ToTable("Handrails");

                    x.HasOne(b => b.Bus)
                     .WithMany(h => h.Handrail)
                     .HasForeignKey(k => k.Id)
                     .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder
                .Entity<Hydraulic>(x =>
                {
                    x.ToTable("Hydraulics");
                    x.HasKey(u => u.Id);

                    x.HasOne(u => u.Truck)
                     .WithOne(u => u.Hydraulic)
                     .HasForeignKey<Truck>(u => u.Id)
                     .OnDelete(DeleteBehavior.Cascade); ;                     
                });

            modelBuilder
                .Entity<Car>(car =>
                {
                    car.HasKey(x => x.Id);
                    car.ToTable("Cars");
                });

            modelBuilder
                .Entity<Bus>(bus =>
                {
                    bus.HasKey(x => x.Id);
                    bus.ToTable("Buses");
                });
            modelBuilder
                .Entity<Truck>(truck =>
                {
                    truck.HasKey(y => y.Id);
                    truck.ToTable("Truckes");
                });
        }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-126LHOT8\\SQLEXPRESS; Initial Catalog=CarService;Integrated Security=True");
            // optionsBuilder.UseSqlServer(@"Server=LAPTOP-126LHOT8\SQLEXPRESS;Database=CarService;Trusted_Connection=True;");
        }
    }
   
}

