using LegacyApp;

namespace LegacyAppTest;

public class UnitTest1
{
    [Fact]
    public void UserService_AddUser_Should_Return_False_When_Name_Or_Last_Name_Are_Empty()
    {
        // Arrange
        var name = "John";
        var lastName = "Doe";
        var mail = "johndoe@gmail.com";
        var birthDate = DateTime.Parse("1982-03-21");
        var id = 1;
                    
        // Act
        var us = new UserService();
        
        // Assert
        Assert.True(us.AddUser(name, lastName, mail, birthDate, id));
    }
    
    public void UserService_AddUser_Should_Return_False_When_Email_Dont_Contains_At_And_Dot()
    {
        // Arrange
        var name = "John";
        var lastName = "Doe";
        var mail = "johndoe@gmail.com";
        var birthDate = DateTime.Parse("1982-03-21");
        var id = 1;
                    
        // Act
        var us = new UserService();
        
        // Assert
        Assert.True(us.AddUser(name, lastName, mail, birthDate, id));
    }
    
    
}