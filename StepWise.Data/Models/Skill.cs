using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepWise.Data.Models
{
    [Comment("Skill in a profession")]
    public class Skill
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = null!;

        [Comment("The professions this skill is in.")]
        public ICollection<Profession> Professions { get; set; } = new List<Profession>();
    }
}
