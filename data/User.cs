namespace MusicStoreApp.data;

public class User
{
    public User()
    {
    }

    public User(string firstName, string lastName, string email, string phone, string addressStreet,
        string addressNumber, string addressCity, string addressZipCode, string username, string password, bool isAdmin,
        string dateOfBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.phone = phone;
        this.addressStreet = addressStreet;
        this.addressNumber = addressNumber;
        this.addressCity = addressCity;
        this.addressZipCode = addressZipCode;
        this.dateOfBirth = dateOfBirth;
        this.username = username;
        this.password = password;
        this.isAdmin = isAdmin;
    }

    public int ID { get; set; } = 1; // Auto incremented
    public string username { get; set; } = string.Empty; // Won't be null
    public string password { get; set; } = string.Empty; // Won't be null
    public bool isAdmin { get; set; } // Default value is false
    public string firstName { get; set; } = string.Empty; // Won't be null
    public string lastName { get; set; } = string.Empty; // Won't be null
    public string email { get; set; } = string.Empty; // Won't be null
    public string phone { get; set; } = string.Empty; // Won't be null
    public string addressStreet { get; set; } = string.Empty; // Won't be null
    public string addressNumber { get; set; } = string.Empty; // Won't be null
    public string addressCity { get; set; } = string.Empty; // Won't be null
    public string addressZipCode { get; set; } = string.Empty; // Won't be null
    public string dateOfBirth { get; set; } = string.Empty; // Won't be null

    public string showDeliveryAddress()
    {
        return
            $"Name: {firstName} {lastName} | Street: {addressStreet} {addressNumber} | Zip code: {addressZipCode} | City: {addressCity}";
    }
}