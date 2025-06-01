﻿namespace Authentication.Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string? Name { get; set; } // Name of the room
        public string FacilityId { get; set; } // Foreign key to Facility
        public Facility Facility { get; set; } // Navigation property to Facility
        public YoungPerson YoungPerson { get; set; }
    }
}
