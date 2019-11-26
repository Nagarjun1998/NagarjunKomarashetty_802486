using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Models
{
    [Table("Mentordtl")]
    public class MentorDtl
    {
        [Key]
        public string MentorId { get; set; }
        [Required]
        public string MentorName { get; set; }
        [Required]
        public string Email { get; set; }
        [MaxLength(10)]
        public string ContactNo { get; set; }
        [Required]
        [MaxLength(5)]
        public string Password { get; set; }

        public string TimeSlot { get; set; }

        public int? YearsOfExperience { get; set; }

        public string Facilities { get; set; }

        public string Technologies { get; set; }

        public string linkedInUrl { get; set; }
        public string Role { get; set; }

        public string Active { get; set; }

        public IEnumerable<Training> Trainings { get; set; }

        public IEnumerable<Payment> Payments { get; set; }
    }
}
