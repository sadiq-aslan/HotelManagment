﻿using HotelAPI.Application.DTOs.Reservators;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IReservatorService
    {
        Task AddAsync(ReservatorAddRequest reservatorAddRequest);
        Task EditAsync(ReservatorUpdateRequest reservatorUpdateRequest);
        Task<ReservatorUpdateRequest> GetForUpdateById(int id);
        Task<List<ReservatorTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
