﻿namespace CouponAPI.Models
{
    public class Coupon
    {
        public int CouponId { get; set; }

        public string CouponCode { get; set; }

        public double MinAmount { get; set; }

        public double DiscountAmount { get; set; }

        public string Description { get; set; }
    }
}
