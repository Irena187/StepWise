using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepWise.Data.Models
{
    public enum StepType
    {
        Course,
        Book,
        Internship,
        Job,
        Certification,
        Degree,
        Documentation,
        Other
    }

    [Comment("Career steps for each career path.")]
    public class CareerStep
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Title { get; set; } = null!;

        [MaxLength(300)]
        public string? Description { get; set; }

        [Comment("The type of step(Course, Book, Job...)")]
        public StepType Type { get; set; }

        [MaxLength(2048)]
        [Comment("The url address to the reference.")]
        public string? Url { get; set; }

        [Comment("Did the user complete this step?")]
        public bool IsCompleted { get; set; }

        [Comment("When is the time this step should be completed?")]
        public DateTime? Deadline { get; set; }

        [Required]
        public Guid CareerPathId { get; set; }
        [Comment("The career path that this step belongs to")]
        public CareerPath? CareerPath { get; set; }
    }
}
