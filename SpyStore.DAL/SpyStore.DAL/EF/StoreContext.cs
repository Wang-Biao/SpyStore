using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SpyStore.Models.Entities;

namespace SpyStore.DAL.EF
{
    class StoreContext : DbContext
    {

        public StoreContext() {

        }
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                @"Server=(localhost)\SQLEXPRESS;Database=SpyStore;Trusted_Connection=True;MultipleActiveResultSets=true;", options => options.EnableRetryOnFailure());
            }
        }

        public DbSet<Category> Categories { get; set; }

    }
}
