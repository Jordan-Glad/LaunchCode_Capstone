﻿namespace Capstone_Project.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Zipcode { get; set; }
        public string[] SavedDrugs { get; set; }

    }
}
