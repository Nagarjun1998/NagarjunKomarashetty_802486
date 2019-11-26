using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingService.Models
{
    [Table("Training")]
    public class Training
    {
        [Key]
        public string TrainingId { get; set; }
        public string TrainingName { get; set; }
        [ForeignKey("Userdtl")]
        public string UserId { get; set; }
        [ForeignKey("MentorDtl")]
        public string MentorId { get; set; }
        [ForeignKey("Skill")]
        public string SkillId { get; set; }
        public string timeslot { get; set; }
        public string status { get; set; }
        public string progress { get; set; }
        public string rating { get; set; }
        [Column(TypeName = "Date")]

        public Nullable<System.DateTime> startDate { get; set; }
        [Column(TypeName = "Date")]

        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<bool> requested { get; set; }
        public Nullable<bool> rejectNotify { get; set; }
        public Nullable<bool> paymentStatus { get; set; }

        public IEnumerable<Payment> Payments { get; set; }
        public Userdtl Userdtl { get; set; }

        public MentorDtl MentorDtl { get; set; }

        public Skill Skill { get; set; }
    }
}
