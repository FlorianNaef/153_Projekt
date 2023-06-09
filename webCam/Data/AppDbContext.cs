﻿using Microsoft.EntityFrameworkCore;
using webCamExample_Florian_Naef.Models;

namespace webCamExample_Florian_Naef.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ImageStore> ImageStores { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);
        }
    }
}
