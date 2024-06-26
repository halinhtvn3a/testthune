﻿using BusinessObjects;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebApplication2.Data
{
	public class CourtCallerDbContext : IdentityDbContext
	{
		public CourtCallerDbContext(DbContextOptions<CourtCallerDbContext> options)
			: base(options)
		{
		}
		public CourtCallerDbContext()
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

			IConfigurationRoot configurationRoot = builder.Build();
			optionsBuilder.UseSqlServer(configurationRoot.GetConnectionString("CourtCallerDb"));

		}

		public DbSet<Review> Reviews { get; set; }
		public DbSet<IdentityRole> Roles { get; set; }
		public DbSet<IdentityUser> Users { get; set; }
		public DbSet<UserDetail> UserDetails { get; set; }
		public DbSet<Branch> Branches { get; set; }
		public DbSet<Court> Courts { get; set; }
		public DbSet<TimeSlot> TimeSlots { get; set; }
		public DbSet<Booking> Bookings { get; set; }
		public DbSet<Payment> Payments { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Seed roles
			modelBuilder.Entity<IdentityRole>().HasData(
				new IdentityRole
				{
					Id = "R001",
					Name = "Admin",
					NormalizedName = "ADMIN",
					ConcurrencyStamp = Guid.NewGuid().ToString()
				},
				new IdentityRole
				{
					Id = "R002",
					Name = "Staff",
					NormalizedName = "STAFF",
					ConcurrencyStamp = Guid.NewGuid().ToString()
				},
				new IdentityRole
				{
					Id = "R003",
					Name = "Customer",
					NormalizedName = "CUSTOMER",
					ConcurrencyStamp = Guid.NewGuid().ToString()
				}
			);
		}
	}
}
