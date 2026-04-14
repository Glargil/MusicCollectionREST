using MusicCollectionREST.Models;
namespace MusicCollectionREST.Repos
{
    public class RecordRepo : IRecordRepo
    {
        private int _nextId = 1;
        private List<Record> _record = new List<Record> {
             new Record("The Dark Side of the Moon", "Pink Floyd", 163, 1973),
             new Record("Another Brick in The Wall", "Pink Floyd", 161, 1979),
             new Record("Abbey Road", "The Beatles", 167, 1969),
             new Record("Thriller", "Michael Jackson", 162, 1982)
            };

        public RecordRepo()
                    {
            //Add(new Record(0, "The Dark Side of the Moon", "Pink Floyd", 163, 1973));
            //Add(new Record(0, "Abbey Road", "The Beatles", 167, 1969));
            //Add(new Record(0, "Thriller", "Michael Jackson", 162, 1982));
                    }

        public IEnumerable<Record>? GetAll(string title, string artist)
        {
            IEnumerable<Record> result = _record;

            if (title != null)
            {
                result = result.Where(r => r.Title != null && r.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
            }
            if (artist != null)
                {
                    result = result.Where(r => r.Artist != null && r.Artist.Contains(artist, StringComparison.OrdinalIgnoreCase));
            } 
            return result;
        }



    }
}
