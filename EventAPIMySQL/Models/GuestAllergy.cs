﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventAPIMySQL.Models
{
    public class GuestAllergy
    {
        public int GuestId { get; set; }
        public int AllergyId { get; set; }
        public Guest Guest { get; set; } 
        public Allergy Allergy { get; set; }

    }
}
