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
        public static List<Moviescs> SerachMovieByTitle(string title) => Movies.Where(m => m.Title.ToLower().Contains(title.ToLower())).ToList();
        public static List<Moviescs> SerachMovieByStyle(string style) => Movies.Where(m => m.Style.ToLower().Contains(style.ToLower())).ToList();
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
        public static void Update(Moviescs movie)
        {
            int index = Movies.FindIndex(m => m.Id == movie.Id);
            if (index == -1) return;
            Movies[index] = movie;
        }
        public static void AddSessionToMovie(Session session, int idMovie)
        {
            int index = Movies.FindIndex(m => m.Id == idMovie);
            if (index == -1) return;
            List<Session> oldSessions = Movies[index].Sessions;
            if (oldSessions.Count == 0)
            {
                session.Id = 1;
                Movies[index].Sessions.Add(session);
            }
            else
            {
                session.Id = oldSessions.Last<Session>().Id + 1;
                Movies[index].Sessions.Add(session);

            }

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
