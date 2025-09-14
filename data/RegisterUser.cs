namespace MusicStoreApp.data;

public class RegisterUser
{
    public void Register(string firstName, string lastName, string email, int phoneString, string streetName,
        string houseNumber, string zipCode, string city, string dateOfBirthString, string username, string password,
        bool isAdmin)
    {
        if (DateTime.TryParse(dateOfBirthString, out var dateOfBirth))
        {
            // Create the User object with the new ID
            var newUser = new User();

            // Validate user data
            DatabaseHandler.Instance.RegisterUser(newUser);
        }
        else
        {
            throw new Exception("Invalid date format. Please enter a valid date.");
        }
    }
}