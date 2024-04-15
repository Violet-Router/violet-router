using VIOLET.ROUTER.Domain.Catalog;

namespace VIOLET.ROUTER.Domain.Tests;

[TestClass]
public class RatingTests
{
    [TestMethod]
    public void Can_Create_New_Rating()
    {
        // Arrange
        var rating = new Rating(5, "John Doe", "Great!");

        // Act (nothing to act on)

        // Assert
        Assert.AreEqual(5, rating.Stars);
        Assert.AreEqual("John Doe", rating.UserName);
        Assert.AreEqual("Great!", rating.Review);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Rating_With_Zero_Stars_Throws_Exception()
    {
        // Arrange - should throw an argument exception
        var rating = new Rating(0, "John Doe", "Great!");
    }
}