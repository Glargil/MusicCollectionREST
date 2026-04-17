using MusicCollectionREST.Models;
namespace MusicCollectionREST.Repos
{
    public interface IRecordRepo
    {
        public IEnumerable<Record>? GetAll(string title, string artist);
        public Record? Add(Record record);
        public Record? Update(Record record);
        public Record? Delete(int id);
    }
}
