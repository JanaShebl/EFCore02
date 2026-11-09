using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Models
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        public int id { get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(150)]
        public string? company { get; set; }
        public bool isVerified { get; set; }
    }
}
