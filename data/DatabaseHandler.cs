using System.Data;
using System.Globalization;
using System.Text;
using Microsoft.Data.SqlClient;
using MusicStoreApp.gui.admin;

namespace MusicStoreApp.data;

public class DatabaseHandler
{
    private static DatabaseHandler _databaseHandler;

    private static readonly string ConnectionString =
        @"Data Source=NotForYourEyes;User ID=NotForYourEyes;Password=NotForYourEyes; TrustServerCertificate=True;";
    // Connection string will not be published here, but is embedded in the working Demo

    public static int userIDFromDatabase;

    // Update Quantity according to the user interaction
    private static readonly Dictionary<int, int> originalQuantity = new();


    private List<User> users;

    public DatabaseHandler()
    {
        users = new List<User>();
    }

    public static DatabaseHandler Instance
    {
        get
        {
            if (_databaseHandler == null) _databaseHandler = new DatabaseHandler();

            return _databaseHandler;
        }
    }

    public static void Connect()
    {
        try
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open(); // Opens connection to database
                Console.WriteLine("Conneceted to database successfully.");

                // Load data from different tables into the application
                LoadUsers();
                LoadProducts();
                LoadOrders();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    // Executes SQL query and returns the result as DataTable
    private static DataTable GetTable(string query)
    {
        var resultTable = new DataTable();

        using (var connection = new SqlConnection(ConnectionString))
        using (var command = new SqlCommand(query, connection))
        using (var adapter = new SqlDataAdapter(command))
        {
            // Fill the DataTable with query results
            adapter.Fill(resultTable);
        }

        return resultTable;
    }

    // Helper method that loads users from Users table and integrates them into the application
    public static void LoadUsers()
    {
        var query = "SELECT * FROM [MusicStoreUsers]"; // SQL query to fetch all users
        var resultTable = GetTable(query); // Execute query and store results in DataTable

        try
        {
            resultTable = GetTable(query); // Get product data from database
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to fetch users {ex.Message}");
        }

        if (resultTable.Rows.Count == 0) // Check for empty database
        {
            MessageBox.Show("No users were found");
            return;
        }

        var allUserDetails = new StringBuilder();

        foreach (DataRow row in resultTable.Rows)
        {
            try
            {
                var user = new User
                {
                    ID = row["ID"] != DBNull.Value ? Convert.ToInt32(row["ID"]) : 0,
                    firstName = row["FirstName"]?.ToString() ?? "Unknown first name",
                    lastName = row["LastName"]?.ToString() ?? "Unknown last name",
                    email = row["Email"]?.ToString() ?? "Unknown email",
                    phone = row["Phone"]?.ToString() ?? "Unknown phone number",
                    addressStreet = row["AddressStreet"]?.ToString() ?? "Unknown street address",
                    addressNumber = row["AddressNumber"]?.ToString() ?? "Unknown house number",
                    addressCity = row["AddressCity"]?.ToString() ?? "Unknown city",
                    addressZipCode = row["AddressZipCode"]?.ToString() ?? "Unknown zip code",
                    dateOfBirth = row["DateOfBirth"]?.ToString() ?? "Unknown date of birth",
                    username = row["UserName"]?.ToString() ?? "Unknown username",
                    password = row["Password"]?.ToString() ?? "Unknown password",
                    isAdmin = Convert.ToBoolean(row["IsAdmin"]) // Convert isAdmin column to boolean
                };

                Console.WriteLine($"Populating user in DatabaseManager {user.firstName} {user.lastName}"); // Debugging

                DataManager.Instance.Users[user.ID] = user; // Add user to DataManager
                DataManager.Instance.AddUsers(user); // Add users to DataManager;
                allUserDetails.AppendLine(
                    ConvertUserToString(user)); // Convert users to string and add to StringBuilder
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing user row: {ex.Message}");
            }

            Console.WriteLine(allUserDetails.ToString()); // Print all user details to console
        }
    }

    // Helper method to convert product object to string
    private static string ConvertUserToString(User user)
    {
        return
            $"ID: {user.ID}, First Name: {user.firstName}, Last Name: {user.lastName}, Email: {user.email}, Phone: {user.phone}, Street: {user.addressStreet} {user.addressNumber}, Zip Code: {user.addressZipCode}, City: {user.addressCity}, Date of Birth: {user.dateOfBirth}";
    }

    // Helper method that loads products from Product table and integrates them
    public static void LoadProducts()
    {
        var query = "SELECT * FROM MusicStoreProducts"; // SQL query for all products
        var resultTable = GetTable(query);

        try
        {
            resultTable = GetTable(query); // Get product data from database
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to fetch products {ex.Message}");
            return;
        }

        if (resultTable.Rows.Count == 0) // Check for empty database
        {
            MessageBox.Show("No products found");
            return;
        }

        DataManager.Instance.ProductsList.Clear(); // Clear existing products in DataManager to avoid duplicates

        var allProductsDetails = new StringBuilder();

        foreach (DataRow row in resultTable.Rows)
            try
            {
                var product = new Product
                {
                    ID = row["ID"] != DBNull.Value ? Convert.ToInt32(row["ID"]) : 0,
                    ProductType = Enum.TryParse<ProductType>(row["ProductType"]?.ToString(), out var productType)
                        ? productType
                        : ProductType.CD,
                    Artist = row["Artist"]?.ToString() ?? "Unknown Artist",
                    Title = row["Title"]?.ToString() ?? "Unkown Title",
                    Genre = Enum.TryParse<Genre>(row["Genre"]?.ToString(), out var genre)
                        ? genre
                        : Genre.Rock,
                    ReleaseYear = row["ReleaseYear"] != DBNull.Value ? Convert.ToInt32(row["ReleaseYear"]) : 0,
                    Price = row["Price"] != DBNull.Value ? Convert.ToDouble(row["Price"]) : 0.00,
                    Quantity = row["Quantity"] != DBNull.Value ? Convert.ToInt32(row["Quantity"]) : 0,
                    ImageUrl = row["ImageUrl"]?.ToString() ?? "Unknown Image URL"
                };

                DataManager.Instance.AddProduct(product); // Add product to DataManager

                allProductsDetails.AppendLine(
                    ConvertProductToString(product)); // Convert product to string and add to StringBuilder
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing product row: {ex.Message}");
            }

        Console.WriteLine(allProductsDetails.ToString()); // Print all products details to console
    }

    // Helper method to convert product object to string
    private static string ConvertProductToString(Product product)
    {
        var euroCulture = new CultureInfo("de-DE");

        return
            $"ID: {product.ID}, Product Type: {product.ProductType}, Artist: {product.Artist}, Title: {product.Title}, " +
            $"Genre: {product.Genre}, Release Year: {product.ReleaseYear}, Price: {product.Price.ToString("C", euroCulture)}, " +
            $"Quantity: {product.Quantity}, Image URL: {product.ImageUrl}";
    }

    // Helper method that loads the connection between orders and users from the table
    public static void LoadOrders()
    {
        var query = "SELECT * FROM MusicStoreOrders";
        DataTable resultTable;

        try
        {
            resultTable = GetTable(query); // Get order data from database
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading orders: {ex.Message}");
            return;
        }

        if (resultTable.Rows.Count == 0)
        {
            MessageBox.Show("No orders found");
            return;
        }

        DataManager.Instance.OrdersList.Clear(); // Clear existing orders in DataManager to avoid duplicates
        var allOrdersDetails = new StringBuilder();

        foreach (DataRow row in resultTable.Rows)
            try
            {
                // Map data row to Orders object
                var orders = new Orders
                {
                    ID = row["ID"]?.ToString() ?? "Unknown ID", // Handle ID as string
                    OrderDate = row["OrderDate"] != DBNull.Value
                        ? Convert.ToDateTime(row["OrderDate"])
                        : DateTime.MinValue,
                    PaymentStatus = row["PaymentStatus"] != DBNull.Value
                        ? Convert.ToBoolean(row["PaymentStatus"])
                        : false,
                    ShippingStatus = row["ShippingStatus"] != DBNull.Value
                        ? Convert.ToBoolean(row["ShippingStatus"])
                        : false,
                    UserID = row["UserID"] != DBNull.Value ? Convert.ToInt32(row["UserID"]) : 0,
                    ProductID = row["ProductID"] != DBNull.Value ? Convert.ToInt32(row["ProductID"]) : 0,
                    OrderedItemQuantity = row["OrderedItemQuantity"] != DBNull.Value
                        ? Convert.ToInt32(row["OrderedItemQuantity"])
                        : 0,
                    TotalPrice = row["TotalPrice"] != DBNull.Value ? Convert.ToDouble(row["TotalPrice"]) : 0.00
                };


                // Add the order to the DataManager
                DataManager.Instance.AddOrder(orders);

                // Convert order to string and append it to all orders details
                allOrdersDetails.AppendLine(ConvertOrdersToString(orders));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing order row: {ex.Message}");
            }

        Console.WriteLine(allOrdersDetails.ToString()); // Output all orders details to the console
    }

    // Helper method to convert orders object to string
    public static string ConvertOrdersToString(Orders order)
    {
        var product = DataManager.Instance.ProductsList
            ?.FirstOrDefault(p => p.ID == order.ProductID);

        var productTitle = product?.Title ?? "Unknown Title";
        var productArtist = product?.Artist ?? "Unknown Artist";

        var euroCulture = new CultureInfo("de-DE");

        return
            $"Order ID: {order.ID} | Date: {order.OrderDate:yyyy-MM-dd} | Artist: {productArtist} | Title: {productTitle} | Quantity: {order.OrderedItemQuantity} | Total Price: {order.TotalPrice.ToString("C", euroCulture)}";
    }

    // Login validation method
    public (bool isLoginSuccessful, bool isAdmin) ValidateLogin(string username, string password)
    {
        const string query = "SELECT Password, IsAdmin FROM MusicStoreUsers WHERE Username = @Username";

        try
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // First query to validate password and get IsAdmin
                using (var command = new SqlCommand(query, connection))
                {
                    // Add username parameter
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute reader for the first query
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // If a matching user is found
                        {
                            // Retrieve and store hashed password and IsAdmin value
                            var storedHashedPassword = reader["Password"].ToString();
                            var isAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));

                            // Hash the input password for comparison
                            var hashedInputPassword = HashPassword(password);

                            // Compare hashed values
                            if (storedHashedPassword == hashedInputPassword)
                            {
                                // Close the reader before executing another query
                                reader.Close();

                                // Second query to get the ID of the user
                                var getUserIdQuery = "SELECT ID FROM MusicStoreUsers WHERE Username = @Username";
                                using (var idCommand = new SqlCommand(getUserIdQuery, connection))
                                {
                                    idCommand.Parameters.AddWithValue("@Username", username);
                                    var result = idCommand.ExecuteScalar();
                                    if (result != null)
                                    {
                                        userIDFromDatabase = Convert.ToInt32(result);
                                        Console.WriteLine(
                                            $"User ID from Database: {userIDFromDatabase}");
                                    }
                                }

                                return (true, isAdmin); // Return login success and IsAdmin status
                            }
                        }
                    } // DataReader is disposed here
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error validating login: {ex.Message}");
            throw;
        }

        return (false, false); // Return false if login fails
    }

    // Helper method for password hashing
    private static string HashPassword(string plainTextPassword)
    {
        if (string.IsNullOrWhiteSpace(plainTextPassword))
            throw new ArgumentException("Password cannot be null or whitespace", nameof(plainTextPassword));

        return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainTextPassword));
    }

    // Method to register user 
    public void RegisterUser(User user)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            try
            {
                conn.Open();

                // Define the SQL query to insert data
                var query =
                    "INSERT INTO MusicStoreUsers (firstName, lastName, email, phone, addressStreet, addressNumber, addressCity, addressZipCode, dateOfBirth, username, password, isAdmin) " +
                    "values (@firstName, @lastName, @email, @phone, @addressStreet, @addressNumber, @addressCity, @addressZipCode, @dateOfBirth, @username, @password, @isAdmin)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    // Add parameterized values to avoid SQL injection
                    cmd.Parameters.AddWithValue("@firstName", user.firstName);
                    cmd.Parameters.AddWithValue("@lastName", user.lastName);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@phone", user.phone);
                    cmd.Parameters.AddWithValue("addressStreet", user.addressStreet);
                    cmd.Parameters.AddWithValue("@addressNumber", user.addressNumber);
                    cmd.Parameters.AddWithValue("@addressCity", user.addressCity);
                    cmd.Parameters.AddWithValue("@addressZipCode", user.addressZipCode);
                    cmd.Parameters.AddWithValue("@DateOfBirth",
                        DateTime.Parse(user.dateOfBirth).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Username", user.username);
                    cmd.Parameters.AddWithValue("@Password",
                        HashPassword(user.password)); // Hash passwords before storing
                    cmd.Parameters.AddWithValue("@IsAdmin", user.isAdmin);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log and rethrow exception for calling methods to handle
                Console.WriteLine($"Error registering user: {ex.Message}");
                throw;
            }
        }
    }

    // Method to update user details
    public void UpdateUser(User user)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            try
            {
                conn.Open();

                // Define the SQL query to update user data
                var query = "UPDATE MusicStoreUsers " +
                            "SET firstName = @firstName, lastName = @lastName, email = @email, phone = @phone, " +
                            "addressStreet = @addressStreet, addressNumber = @addressNumber, addressCity = @addressCity, " +
                            "addressZipCode = @addressZipCode, dateOfBirth = @dateOfBirth, username = @username, password = @password, isAdmin = @isAdmin " +
                            "WHERE ID = @ID"; // Use unique ID to target the correct user

                using (var cmd = new SqlCommand(query, conn))
                {
                    // Add parameterized values to avoid SQL injection
                    cmd.Parameters.AddWithValue("@firstName", user.firstName);
                    cmd.Parameters.AddWithValue("@lastName", user.lastName);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@phone", user.phone);
                    cmd.Parameters.AddWithValue("@addressStreet", user.addressStreet);
                    cmd.Parameters.AddWithValue("@addressNumber", user.addressNumber);
                    cmd.Parameters.AddWithValue("@addressCity", user.addressCity);
                    cmd.Parameters.AddWithValue("@addressZipCode", user.addressZipCode);
                    cmd.Parameters.AddWithValue("@dateOfBirth",
                        DateTime.Parse(user.dateOfBirth).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@username", user.username);
                    cmd.Parameters.AddWithValue("@password",
                        HashPassword(user.password)); // Ensure the password is hashed
                    cmd.Parameters.AddWithValue("@isAdmin", user.isAdmin);
                    cmd.Parameters.AddWithValue("@ID", user.ID); // Pass the user's unique ID

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log and rethrow any exceptions
                Console.WriteLine($"Error updating user information: {ex.Message}");
                throw;
            }
        }
    }

    // Method to add a new product
    public void AddNewProduct(Product product)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            try
            {
                conn.Open();

                // define the SQL-Query to insert Data
                var query =
                    "INSERT INTO MusicStoreProducts(ProductType, Artist, Title, Genre, Price, Quantity, ImageUrl, ReleaseYear)" +
                    "VALUES (@ProductType, @Artist, @Title, @Genre, @Price, @Quantity,@ImageUrl,@ReleaseYear)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    // Add parameterized values to avoid SQL injection
                    cmd.Parameters.AddWithValue("@ProductType", product.ProductType.ToString());
                    cmd.Parameters.AddWithValue("@Artist", product.Artist);
                    cmd.Parameters.AddWithValue("@Title", product.Title);
                    cmd.Parameters.AddWithValue("@Genre", product.Genre);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("@ImageUrl", product.ImageUrl);
                    cmd.Parameters.AddWithValue("@ReleaseYear", product.ReleaseYear);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding new product: {ex.Message}");
                throw;
            }
        }
    }

    // Method to edit a product
    public void EditProduct(Product product)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var transaction = conn.BeginTransaction();
            try
            {
                var query =
                    "UPDATE MusicStoreProducts SET ProductType = @ProductType, Artist = @Artist, Title = @Title, Genre = @Genre, Price = @Price, Quantity = @Quantity WHERE Artist = @Artist";

                using (var cmd = new SqlCommand(query, conn, transaction))
                {
                    cmd.Parameters.Add("@ProductType", SqlDbType.VarChar).Value = product.ProductType.ToString();
                    cmd.Parameters.Add("@Artist", SqlDbType.VarChar).Value = product.Artist;
                    cmd.Parameters.Add("@Title", SqlDbType.VarChar).Value = product.Title;
                    cmd.Parameters.Add("@Genre", SqlDbType.VarChar).Value = product.Genre;
                    cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = product.Price;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = product.Quantity;
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine($"Error editing product: {ex.Message}");
                throw;
            }
        }
    }

    // Method to delete a product
    public static void DeleteProduct(Product product)
    {
        if (product == null)
        {
            MessageBox.Show("Kein Produkt ausgewählt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var query = "DELETE FROM MusicStoreProducts WHERE ID = @ID";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", product.ID);
                    cmd.ExecuteNonQuery();
                }
            }

            DataManager.Instance.ProductsList.RemoveAll(product => product.ID == product.ID);
            var productWindow = new AdminManageProductsWindow();
            productWindow.LoadProductsToListBox();
            productWindow.Show();

            MessageBox.Show("Produkt erfolgreich gelöscht", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Fehler beim Löschen des produktes: {ex.Message}", "Fehler", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    // Method to edit a user from Admin panel
    public void EditUser(User user)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var transaction = conn.BeginTransaction();
            try
            {
                var query =
                    "UPDATE MusicStoreUsers SET firstName = @firstName, lastName = @lastName, email = @email, phone = @phone, addressStreet = @addressStreet, addressNumber = @addressNumber, addressCity = @addressCity, addressZipCode = @addressZipCode, dateOfBirth = @dateOfBirth WHERE lastName = @lastName";

                using (var cmd = new SqlCommand(query, conn, transaction))
                {
                    cmd.Parameters.Add("@firstName", SqlDbType.VarChar).Value = user.firstName;
                    cmd.Parameters.Add("@lastName", SqlDbType.VarChar).Value = user.lastName;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = user.email;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = user.phone;
                    cmd.Parameters.Add("@addressStreet", SqlDbType.VarChar).Value = user.addressStreet;
                    cmd.Parameters.Add("@addressNumber", SqlDbType.Int).Value = user.addressNumber;
                    cmd.Parameters.Add("@addressCity", SqlDbType.VarChar).Value = user.addressCity;
                    cmd.Parameters.Add("@addressZipCode", SqlDbType.VarChar).Value = user.addressZipCode;
                    cmd.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = user.dateOfBirth;
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine($"Error editing user: {ex.Message}");
                throw;
            }
        }
    }

    // Method to update user address
    public static void UpdateUserAddress(int userID, string addressStreet, string addressNumber, string addressZipCode,
        string addressCity)
    {
        var query =
            "UPDATE MusicStoreUsers SET AddressStreet = @addressStreet, AddressNumber = @addressNumber, AddressZipCode = @addressZipCode, AddressCity = @addressCity WHERE ID = @ID";

        using (var connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@addressStreet", addressStreet);
                command.Parameters.AddWithValue("@addressNumber", addressNumber);
                command.Parameters.AddWithValue("@addressZipCode", addressZipCode);
                command.Parameters.AddWithValue("@addressCity", addressCity);
                command.Parameters.AddWithValue("@ID", userID);
                command.ExecuteNonQuery();
            }
        }
    }

    // Method to create Order from CheckoutWindow
    public static void AddOrder(int userId, DateTime orderDate, Dictionary<Product, int> cart, bool paymentStatus,
        bool shippingStatus)
    {
        // Generate a unique Order ID
        var orderId = GenerateUniqueOrderId();

        var query = @"
        INSERT INTO MusicStoreOrders (ID, UserID, OrderDate, OrderedItemQuantity, PaymentStatus, ShippingStatus, TotalPrice, ProductID) 
        VALUES (@ID, @UserID, @OrderDate, @OrderedItemQuantity, @PaymentStatus, @ShippingStatus, @TotalPrice, @ProductID);";

        using (var connection = new SqlConnection(ConnectionString))
        {
            try
            {
                connection.Open();

                using (var command = new SqlCommand(query, connection))
                {
                    // Loop through each product in the cart
                    foreach (var entry in cart)
                    {
                        var product = entry.Key;
                        var quantity = entry.Value;
                        var totalPrice = product.Price * quantity;

                        // Add parameters for each product in the cart
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@ID", orderId); // Same Order ID for all rows in this order
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@OrderDate", orderDate);
                        command.Parameters.AddWithValue("@OrderedItemQuantity", quantity);
                        command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                        command.Parameters.AddWithValue("@ShippingStatus", shippingStatus);
                        command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        command.Parameters.AddWithValue("@ProductID", product.ID);

                        // Insert the row
                        command.ExecuteNonQuery();

                        originalQuantity.Remove(product.ID);
                    }
                }

                Console.WriteLine($"Order with ID {orderId} added successfully.");
            }
            catch (Exception ex)
            {
                ResetProductQuantity();
                Console.WriteLine($"Error adding order: {ex.Message}");
                throw;
            }
        }
    }

    // Method to generate a unique Order ID
    private static string GenerateUniqueOrderId()
    {
        var datePrefix = DateTime.Now.ToString("yyMMdd");
        var nextIncrement = 1;

        using (var connection = new SqlConnection(ConnectionString))
        {
            connection.Open();

            // Query to find the largest Order ID matching yyMMdd prefix
            var query = "SELECT TOP 1 ID FROM MusicStoreOrders WHERE ID LIKE @DatePrefix + '%' ORDER BY ID DESC";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DatePrefix", datePrefix);

                var result = command.ExecuteScalar();
                if (result != null)
                {
                    var lastOrderId = result.ToString();
                    var parts = lastOrderId.Split('-');

                    if (parts.Length == 2 && int.TryParse(parts[1], out var lastIncrement))
                        nextIncrement = lastIncrement + 1; // Safely increment numeric part
                }
            }
        }

        return $"{datePrefix}-{nextIncrement}";
    }

    public static void UpdateProductQuantity(int productID, int quantity, bool isTemporary = false)
    {
        try
        {
            // Store original quantity if this is a temporary update
            if (isTemporary && !originalQuantity.ContainsKey(productID))
            {
                var query = "SELECT Quantity FROM MusicStoreProducts WHERE ID = @ID";
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", productID);
                        var result = command.ExecuteScalar();
                        if (result != null) originalQuantity[productID] = Convert.ToInt32(result);
                    }
                }
            }

            // Update quantity in database
            var updateQuery = "UPDATE MusicStoreProducts SET Quantity = @Quantity WHERE ID = @ID";
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@ID", productID);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating product quantity: {ex.Message}");
            throw;
        }
    }

    // Method to reset product quantity to original value
    public static void ResetProductQuantity()
    {
        foreach (var kvp in originalQuantity) UpdateProductQuantity(kvp.Key, kvp.Value);
        originalQuantity.Clear();
    }

    // Method to load favorites from database
    public static void LoadFavorites()
    {
        
    }

    // Method to save favorites to database
    public static void SaveFavorites(User user, Product product)
    {
        
    }

}
