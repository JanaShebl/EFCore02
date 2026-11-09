using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Models
{
    public class Badge
    {
        public int Id { get; set; }
        public int AttendeeId { get; set; } 
        public Attendee Attendee { get; set; }
        public Tier Tier { get; set; }
        public DateTime Date { get; set; }
        public int BadgeNumber { get; set; }
    }
}
