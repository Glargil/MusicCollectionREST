using MusicCollectionREST.Repos;

namespace RecordTest
{
    public class RecordTest
    {
        [Fact]
        public void GetAllTest()
        {
            // Arrange
            var recordRepo = new MusicCollectionREST.Repos.RecordRepo();
            // Act
            var result = recordRepo.GetAll("", "");
            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void GetAllTestWithTitle()
        {
            // Arrange
            var recordRepo = new MusicCollectionREST.Repos.RecordRepo();
            // Act
            var result = recordRepo.GetAll("Dark", "");
            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void AddTest()
        {
            // Arrange
            var recordRepo = new MusicCollectionREST.Repos.RecordRepo();
            var record = new MusicCollectionREST.Models.Record("Test Title", "Test Artist", 300, 2024);
            // Act
            var result = recordRepo.Add(record);
            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void DeleteTest()
        {
            // Arrange
            var recordRepo = new MusicCollectionREST.Repos.RecordRepo();
            var record = new MusicCollectionREST.Models.Record("Test Title", "Test Artist", 300, 2024);
            var addedRecord = recordRepo.Add(record);
            // Act
            var result = recordRepo.Delete(addedRecord.Id);
            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void UpdateTest()
        {
            // Arrange
            var recordRepo = new MusicCollectionREST.Repos.RecordRepo();
            var record = new MusicCollectionREST.Models.Record("Test Title", "Test Artist", 300, 2024);
            var addedRecord = recordRepo.Add(record);
            var newRecord = new MusicCollectionREST.Models.Record("Updated Title", "Updated Artist", 350, 2025);
            // Act
            var result = recordRepo.Update(addedRecord.Id, newRecord);
            // Assert
            Assert.NotNull(result);
        }
    }
}
