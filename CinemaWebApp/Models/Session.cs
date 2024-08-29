namespace CinemaWebApp.Models
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime DateSession { get; set; }

        public TimeOnly TimeSession { get; set; }

    }
}
