﻿namespace HotelAPI.Application.Identity.Concrete
{

    public class UserClaimsOptions : IUserClaimsOptions
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
