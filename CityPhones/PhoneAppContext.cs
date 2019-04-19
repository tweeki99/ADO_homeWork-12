﻿using System.Data.Entity;

namespace CityPhones
{

    public class PhoneAppContext : DbContext
    {
        public PhoneAppContext()
            : base("name=PhoneAppContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Number> Numbers { get; set; }
    }
}