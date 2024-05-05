namespace WebApp;

public static class Utils
{
    public static int SumInts(int a, int b)
    {
        return a + b;
    }

    public static bool IsPasswordGoodEnough(string password)
    {
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
        if (Regex.IsMatch(password, pattern)){
            Console.WriteLine("true");
            return true;
        }
        else {
            Console.WriteLine("false");
            return false;
        }
    }

    

    public static Arr CreateMockUsers()
    {
        var read = File.ReadAllText(Path.Combine("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);
        Arr successFullyWrittenUsers = Arr();
        foreach(var user in mockUsers)
        {

            user.password = "12345678";
            var result = SQLQueryOne(@"
                INSERT INTO users(firstName, lastName, email, password)
                VALUES($firstName, $lastName, $email, $password)
            ", user);
            // if we get an error from the DB then we haven't added the mock user, if not we have so add to successful list
            if (!result.HasKey("error"))
            {
                // the specification says return the user list without the password
                user.Delete("password"); 
                successFullyWrittenUsers.Push(user);
            }

        }
        return successFullyWrittenUsers;
    }
}