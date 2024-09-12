using System.ComponentModel.DataAnnotations;

namespace CinemaWebApp.Models
{
    public class Session
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateSession { get; set; }

        public TimeOnly TimeSession { get; set; }

    }
}
