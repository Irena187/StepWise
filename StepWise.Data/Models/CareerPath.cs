using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepWise.Data.Models
{
    [Comment("Career paths, created by users")]
    public class CareerPath
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Title { get; set; } = null!;

        [MaxLength(300)]
        public string? Description { get; set; }

        [Comment("Did the user make this career path public or private?")]
        public bool IsPublic { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Comment("The user who created this career path")]
        public ApplicationUser? User { get; set; }

        [Required]
        [MaxLength(256)]
        [Comment("The final profession that this career path leads to.")]
        public string GoalProfession { get; set; } = null!; // "Game Developer", "Doctor", etc.

        [Comment("Collection of the steps in one path.")]
        public ICollection<CareerStep> Steps { get; set; } = new List<CareerStep>();
    }
}
