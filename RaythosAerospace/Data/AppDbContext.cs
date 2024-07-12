using System;
using Microsoft.EntityFrameworkCore;
using RaythosAerospace.Models;

namespace RaythosAerospace.Data
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{
		}

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{

		//	base.OnModelCreating(modelBuilder);
		//}

		//public DbSet<AdminDashboard> AdminDashboard { get; set; }
        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<Customization> Customization { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<ManufacturingTrack> ManufacturingTrack { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Payment> Payment { get; set; }
        //public DbSet<Report> Report { get; set; }
        public DbSet<Shipping> Shipping { get; set; }

    }
}

