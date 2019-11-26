using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechnologyService.Models
{
    [Table("Userdtl")]
    public class Userdtl
    {
        [Key]
        public string UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(5)]
        public string Password { get; set; }
        [MaxLength(10)]
        public string ContactNo { get; set; }

        public string Role { get; set; }

        public string Active { get; set; }

        public IEnumerable<Training> Trainings { get; set; }

        public IEnumerable<Payment> Payments { get; set; }

    }
}
