using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DetailedDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }
        public int OrganizerId { get; set; } // FK
        public Organizer Organizer { get; set; } // Navigation property
    }
}
