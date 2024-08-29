using CinemaWebApp.Models;

namespace CinemaWebApp.Services
{
    public static class MovieService
    {
        public static List<Moviescs> Movies { get; set; }
        static int nextId = 0;

        static MovieService()
        {
            Movies = new List<Moviescs>();
            SeedData();
        }

        public static List<Moviescs> GetAll() => Movies;

        public static Moviescs? GetById(int id) => Movies.FirstOrDefault(m => m.Id == id);

        public static void Add(Moviescs movie)
        {
            movie.Id = ++nextId;
            Movies.Add(movie);
        }

        public static void Delete(int id)
        {
            var movie = GetById(id);
            if (movie is null) return;
            Movies.Remove(movie);
        }

        public static void SeedData()
        {
            Movies.Add(new Moviescs()
            {
                Id = ++nextId,
                Title = "Title1",
                Director = "Author1",
                Style = "Thriller",
                ShortDescription = "Info...",
                PosterUrl = "/Images/img1.jpg",
                Sessions = new List<Session>() {
                    new Session()
                    {
                        Id=1,
                        DateSession = new DateTime(2024,08,24),
                        TimeSession = new TimeOnly(10,30)
                    },
                    new Session()
                    {
                        Id=2,
                        DateSession = new DateTime(2024,08,25),
                        TimeSession = new TimeOnly(13,30)
                    },
                }
            });

            Movies.Add(new Moviescs()
            {
                Id = ++nextId,
                Title = "Title2",
                Director = "Author2",
                Style = "Thriller",
                ShortDescription = "Info...",
                PosterUrl = "/Images/img2.jpg",
                Sessions = new List<Session>() {
                    new Session()
                    {
                        Id=1,
                        DateSession = new DateTime(2024,08,24),
                        TimeSession = new TimeOnly(10,30)
                    },
                    new Session()
                    {
                        Id=2,
                        DateSession = new DateTime(2024,08,25),
                        TimeSession = new TimeOnly(13,30)
                    },
                }
            });
        }
    }
}
