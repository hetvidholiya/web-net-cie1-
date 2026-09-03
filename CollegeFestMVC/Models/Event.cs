using System.ComponentModel.DataAnnotations;

namespace CollegeFestMVC.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; } = string.Empty;

        public int MaximumParticipants { get; set; }

        public decimal RegistrationFee { get; set; }
    }
}