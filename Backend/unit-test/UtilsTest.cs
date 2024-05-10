using Microsoft.VisualBasic;
using Newtonsoft.Json.Schema;
namespace WebApp;

/*
public class UtilsTest(Xlog Console)
{


    [Fact]
    public void TestSumInt()
    {
        Assert.Equal(12, Utils.SumInts(7, 5));
    }


    [Fact]
    public void TestPassword_ReturnsTrue()
    {
        // Arrange
        string exampleValidPassword = "Abcdefgh123!";

        // Act
        bool result = WebApp.Utils.IsPasswordGoodEnough(exampleValidPassword);

        // Assert
        Assert.True(result);
        
        if (result == true){
            Console.WriteLine("test successful");
        }
    }
        
    [Fact]
    public void TestPassword_TooShort()
    {
        string exampleShortPassword = "Ab12!";

        bool result = WebApp.Utils.IsPasswordGoodEnough(exampleShortPassword);

        Assert.True(result);
    }


    [Fact]

    public void TestPassword_NoCapitals()
    {
        string exampleLongPassword = "abcdefg123!";

        bool result = WebApp.Utils.IsPasswordGoodEnough(exampleLongPassword);

        Assert.True(result);
    }
    

    [Fact]
    public void TestCreateMockUsers()
    {
        // Read all mock users from the file
        var read = File.ReadAllText(Path.Combine("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);

        // get all users from the db
        Arr usersInDb = SQLQuery("SELECT * FROM users");

        Arr emailsInDb = usersInDb.Map(user => user.email);
        Arr mockUsersNotInDb = mockUsers.Filter(mockUsers => !emailsInDb.Contains(mockUsers.email));

        var result = Utils.CreateMockUsers();

        // Log("Calculated by test", mockUsersNotInDb);
        // Log("reported by method", result);

        //assert the same length
        //Assert.Equal(mockUsersNotInDb.Length, result.Length);

        // check requivelancy for each user
        // INTERPOLERA INTE IN VÄRDEN I DATABASEN.
    }
    
}


*/