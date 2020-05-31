using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirst
{
    public enum Classification:byte
    {
        Silver = 1,
        Gold = 2,
        Platinum = 3
    }
    public class Video
    {
        //public Video()
        //{
        //    Genres = new List<Genre>();
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; }
        //public ICollection<Genre> Genres { get; set; }
        public Genre Genre { get; set; }

        public Classification Classification { get; set; }

    }

    public  class Genre
    {
        //public Genre()
        //{
        //    Videos = new List<Video>();
        //}
        public byte Id { get; set; }
        public string Name { get; set; }
        public ICollection<Video> Videos { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            using (VidzyContext context = new VidzyContext())
            {
                var action = context.Genres.FirstOrDefault(g => g.Name == "Action");
                var comedy = context.Genres.FirstOrDefault(g => g.Name == "Comedy");
                var family = context.Genres.FirstOrDefault(g => g.Name == "Family");

                context.Videos.Add(new Video { Name = "Bahubali", ReleaseDate = DateTime.Now.AddYears(-4), Classification = Classification.Platinum, Genre = action });
                context.Videos.Add(new Video { Name = "Thanmatra", ReleaseDate = DateTime.Now.AddYears(-20), Classification = Classification.Gold, Genre = family });
                context.Videos.Add(new Video { Name = "Johny English", ReleaseDate = DateTime.Now.AddYears(-6), Classification = Classification.Silver, Genre = comedy });

                context.SaveChanges();
            }
        }
    }
    
}
