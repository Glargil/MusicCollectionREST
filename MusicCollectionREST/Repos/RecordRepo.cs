using MusicCollectionREST.Models;
namespace MusicCollectionREST.Repos
{
    public class RecordRepo : IRecordRepo
    {
        private int _nextId = 1;
        private List<Record> _record = new List<Record>();

        public RecordRepo()
        {
            Add(new Record("Thriller", "Michael Jackson", 162, 1982));
            Add(new Record("Abbey Road", "The Beatles", 167, 1969));
            Add(new Record("Thriller", "Michael Jackson", 162, 1982));
            Add(new Record("Another Brick in The Wall", "Pink Floyd", 161, 1979));
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

        public Record? Add(Record record)
        {
            record.Id = _nextId++;
            _record.Add(record);
            return record;
        }
        public Record? Delete(int id)
        {
            Record? record = _record.Find(r => r.Id == id);
            if (record == null)
            {
                return null;
            }
            _record.Remove(record);
            return record;
        }
        public Record? Update(int id, Record record)
        {
            Record? existingRecord = _record.Find(r => r.Id == id);
            if (existingRecord == null)
            {
                return null;
            }
            existingRecord.Title = record.Title;
            existingRecord.Artist = record.Artist;
            existingRecord.Duration = record.Duration;
            existingRecord.PublicationYear = record.PublicationYear;
            return existingRecord;
        }
    }
}