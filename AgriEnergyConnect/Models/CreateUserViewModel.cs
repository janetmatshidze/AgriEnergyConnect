﻿namespace AgriEnergyConnect.Models
{
    public class CreateUserViewModel
    {
      
        public string Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }

        public string PasswordHash { get; set; }
    }
}