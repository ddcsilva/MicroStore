﻿using MicroStore.Services.CouponAPI.Application.DTOs;

namespace MicroStore.Services.CouponAPI.Application.Interfaces;

public interface ICouponService
{
    Task<ResponseDTO> GetAllCouponsAsync();
    Task<ResponseDTO> GetCouponByIdAsync(int id);
    Task<ResponseDTO> GetCouponByCodeAsync(string code);
    Task<ResponseDTO> CreateCouponAsync(CouponDTO couponDTO);
    Task<ResponseDTO> UpdateCouponAsync(CouponDTO couponDTO);
    Task<ResponseDTO> DeleteCouponAsync(int id);
}

