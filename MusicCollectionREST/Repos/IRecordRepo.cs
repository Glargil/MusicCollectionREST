using MusicCollectionREST.Models;
namespace MusicCollectionREST.Repos
{
    public interface IRecordRepo
    {
        public IEnumerable<Record>? GetAll(string title, string artist);
    }
}
