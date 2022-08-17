﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VShop.DiscountApi.Context;
using VShop.DiscountApi.DTOs;

namespace VShop.DiscountApi.Repositories
{
    public class CouponRepository : ICouponRepository
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;

        public CouponRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CouponDTO> GetCouponByCode(string couponCode)
        {
            return _mapper.Map<CouponDTO>(await _context.Coupons.FirstOrDefaultAsync(c => c.CouponCode == couponCode));
        }
    }
}
