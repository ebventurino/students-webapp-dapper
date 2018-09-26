using System.ComponentModel.DataAnnotations;
using Dapper;
using Microsoft.Data.Sqlite;

namespace Workforce.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Slack handle")]
        [MaxLength(20)]
        public string SlackHandle { get; set; }

        [Required]
        [Display(Name = "Specialty")]
        [MaxLength(20)]
        public string Specialty { get; set; }

        [Required]
        public int CohortId { get; set; }

        public Cohort Cohort { get; set; }
    }
}
