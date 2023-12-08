﻿using CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CouponAPI.Data
{
    public class AppDbcontext : DbContext
    {
        // where
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {
            
        }

        // what
        public DbSet<Coupon> Coupons { get; set; }

        // how 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "10OFF",
                DiscountAmount= 10,
                MinAmount = 20,
                Description = "10 % off"
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "20OFF",
                DiscountAmount = 20,
                MinAmount = 40,
                Description = "20 % off"
            });

        }
    }
}
