using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticateService.Models
{
    [Table("Skill")]
    public class Skill
    {
        [Key]
        public string SkillId { get; set; }

        public string SkillName { get; set; }

        public string toc { get; set; }
        public string prerequisites { get; set; }

        public Nullable<int> fees { get; set; }
        public int duration { get; set; }

        public IEnumerable<Training> Trainings { get; set; }
    }
}
