using Xunit;
using Microsoft.EntityFrameworkCore;
using CarDealership.Data;
using CarDealership.Models;

public class CarServiceTests
{
    // Helper method to create an in-memory database context
    private CarDealershipContext GetInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<CarDealershipContext>()
            .UseInMemoryDatabase("CarDealershipTestDb")
            .Options;

        return new CarDealershipContext(options);
    }

    /// <summary>
    /// Verifies that a new car is saved to the database when using the AddCar method.
    /// </summary>
    [Fact]
    public void AddCar_SavesCarToDatabase()
    {
        // Arrange
        // Act
        // Assert
        Assert.Equal(1,0);
    }

    /// <summary>
    /// Verifies that GetCarById returns the correct car for a given valid ID.
    /// </summary>
    [Fact]
    public void GetCarById_ReturnsCorrectCar()
    {
        // Arrange
        // Act
        // Assert
        Assert.Equal(1,0);
    }

    /// <summary>
    /// Verifies that GetCarById returns null when called with a non-existent ID.
    /// </summary>
    [Fact]
    public void GetCarById_ReturnsNullForNonExistentId()
    {
        // Arrange
        // Act
        // Assert
        Assert.Equal(1,0);
    }

    /// <summary>
    /// Verifies that UpdateCar correctly updates the car's details in the database.
    /// </summary>
    [Fact]
    public void UpdateCar_ChangesCarDetails()
    {
        // Arrange
        // Act
        // Assert
        Assert.Equal(1,0);
    }

    /// <summary>
    /// Verifies that properties not included in the update remain unchanged.
    /// </summary>
    [Fact]
    public void UpdateCar_LeavesUnchangedPropertiesIntact()
    {
        // Arrange
        // Act
        // Assert
        Assert.Equal(1,0);
    }

    /// <summary>
    /// Verifies that DeleteCar removes a car from the database when a valid ID is provided.
    /// </summary>
    [Fact]
    public void DeleteCar_RemovesCarFromDatabase()
    {
        // Arrange
        // Act
        // Assert
        Assert.Equal(1,0);
    }

    /// <summary>
    /// Verifies that DeleteCar does not throw an error when trying to delete a car with a non-existent ID.
    /// </summary>
    [Fact]
    public void DeleteCar_NoErrorWhenDeletingNonExistentCar()
    {
        // Arrange
        // Act
        // Assert
        Assert.Equal(1,0);
    }
}
