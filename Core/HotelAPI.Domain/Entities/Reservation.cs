﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities;
[Table("Reservations", Schema = "Hotel")]
public class Reservation : BaseEntity
{
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }

    //Relations
    public int RoomId { get; set; }
    public Room Room { get; set; }
    public int HotelUserId { get; set; }
    public HotelUser HotelUser { get; set; }
}
