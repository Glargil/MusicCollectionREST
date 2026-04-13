using MusicCollectionREST.Models;
namespace MusicCollectionREST.Repos
{
    public class RecordRepo : IRecordRepo
    {
        private int _nextId = 1;
        private List<Record> _record = new List<Record> {
             new Record("The Dark Side of the Moon", "Pink Floyd", 163, 1973),
             new Record("Abbey Road", "The Beatles", 167, 1969),
             new Record("Thriller", "Michael Jackson", 162, 1982)
            };

        public RecordRepo()
                    {
            //Add(new Record(0, "The Dark Side of the Moon", "Pink Floyd", 163, 1973));
            //Add(new Record(0, "Abbey Road", "The Beatles", 167, 1969));
            //Add(new Record(0, "Thriller", "Michael Jackson", 162, 1982));
                    }

        public IEnumerable<Record>? GetAll()
        { 
        IEnumerable<Record> result = _record;
            return result;
        }



    }
}
