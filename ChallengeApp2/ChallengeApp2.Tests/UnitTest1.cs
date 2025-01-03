namespace ChallengeApp2.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            // Arrange
            int age1 = 10;
            int age2 = 3;

            // Act
            int result = age1 + age2;

            // Assert
            Assert.AreEqual(13, result);
            
        }
    }
}