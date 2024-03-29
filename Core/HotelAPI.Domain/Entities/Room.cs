﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities;
[Table("Rooms", Schema = "Hotel")]
public class Room:BaseEntity
{
    public int Number { get; set; }
    public int Floor { get; set; }
    public string Phone { get; set; }
    public double Price { get; set; }
    public RoomState RoomState { get; set; } = RoomState.Available;
    public List<Equipment> Equipments { get; set; }  


    //Relations
    public int RoomTypeId { get; set; }
    public RoomType RoomType { get; set; }
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; }
    public List<Reservation> Reservations { get; set; }
    public List<RoomImage> RoomImages { get; set; }

}
