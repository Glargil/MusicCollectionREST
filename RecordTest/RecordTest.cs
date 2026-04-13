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
            var result = recordRepo.GetAll();
            // Assert
            Assert.NotNull(result);
        }
    }
}
