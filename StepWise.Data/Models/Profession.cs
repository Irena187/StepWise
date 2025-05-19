using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepWise.Data.Models
{
    [Comment("All of the professions")]
    public class Profession
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        [Comment("The industry of this profession")]
        public string Industry { get; set; } = null!;

        [MaxLength(300)]
        public string? Description { get; set; }

        [Comment("Collection of the required skills to get a profession.")]
        public ICollection<Skill> RequiredSkills { get; set; } = new List<Skill>();
    }
}
