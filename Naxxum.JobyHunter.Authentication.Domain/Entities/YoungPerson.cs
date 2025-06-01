namespace Authentication.Domain.Entities
{
    public class YoungPerson
    {
        public string Id { get; set; } // Unique identifier (GUID or string)
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string FacilityId { get; set; }
        public Facility Facility { get; set; }

        public int? RoomId { get; set; }
        public Room Room { get; set; }

        public ICollection<UserYoungPerson> UserYoungPersons { get; set; }

    }
}
