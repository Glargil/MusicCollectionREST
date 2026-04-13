namespace MusicCollectionREST.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }

        public Record(string? title, string? artist, int duration, int publicationYear)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }
        public override string ToString()
        {
            return $"Record [Id={Id}, Title={Title}, Artist={Artist}, Duration={Duration}, PublicationYear={PublicationYear}]";
        }
    }
}
