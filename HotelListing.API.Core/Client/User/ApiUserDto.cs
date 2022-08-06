﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Core.Client.User
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
