﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities;
[Table("Hotels", Schema = "Hotel")]
public class Hotel:BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string WebSite { get; set; }
    public Grade Grade { get; set; }


    //Relations
    public List<HotelRating> Ratings { get; set; }
    public int CityId { get; set; }
    public City City { get; set; }
    public List<Review> Reviews { get; set; }
    public List<Room> Rooms { get; set; }
    public List<HotelImage> HotelImages { get; set; }

}
