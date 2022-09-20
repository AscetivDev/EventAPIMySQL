﻿using EventAPIMySQL.Models;
using System.ComponentModel.DataAnnotations;

namespace EventAPIMySQL.Dtos
{
    public class CreateGuestDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }

        //optional, can have many
        public List<Allergy>? Allergies { get; set; }

    }
}
