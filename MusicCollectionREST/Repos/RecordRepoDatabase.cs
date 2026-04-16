using MusicCollectionREST.Models;

namespace MusicCollectionREST.Repos
{
    public class RecordRepoDatabase :IRecordRepo
    {
        private readonly RecordDbContext _context;

        public RecordRepoDatabase(RecordDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Record>? GetAll(string title, string artist)
        {
           return _context.Records.Where(r => (title == null || (r.Title != null && r.Title.Contains(title, StringComparison.OrdinalIgnoreCase)))
                                            && (artist == null || (r.Artist != null && r.Artist.Contains(artist, StringComparison.OrdinalIgnoreCase))));
        }

        public Record? Add(Record record)
        {
            _context.Records.Add(record);
            _context.SaveChanges();
            return record;
        }
    }
}
