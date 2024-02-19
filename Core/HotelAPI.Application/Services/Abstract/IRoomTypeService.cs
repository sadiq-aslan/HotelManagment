﻿using HotelAPI.Application.DTOs.RoomTypes;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IRoomTypeService
    {
        Task AddAsync(RoomTypeAddRequest roomTypeAddRequest);
        Task EditAsync(RoomTypeUpdateRequest roomTypeUpdateRequest);
        Task<RoomTypeTableResponse> GetById(int id);
        Task<List<RoomTypeTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
