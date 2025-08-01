﻿
using Microsoft.AspNetCore.Identity;

namespace AgriEnergyConnect.Models
{
    public class AgriEnergyConnectUser:IdentityUser
    {
        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string Address { get;set; } = "";

        public DateTime CreatedAt { get; set; }
    }
}
