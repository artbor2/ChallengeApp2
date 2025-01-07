namespace ChallengeApp2.Tests
{
    public class Tests
    {

        [Test]
        public void WhenUserGetsPoints_ShouldReturnSum()
        {
            // Arrange
            var user = new User("Adam", "sdghil;dhg");
            user.AddScore(5);
            user.AddScore(6);

            // Act
            var result = user.Result;

            // Assert
            Assert.AreEqual(11, result);
            
        }
    }
}