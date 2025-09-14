namespace MusicStoreApp.data;

public class DataManager
{
    // Singleton
    private static DataManager instance;

    private DataManager()
    {
    }

    public static DataManager Instance
    {
        get
        {
            if (instance == null) instance = new DataManager();

            return instance;
        }
    }

    // Dictionary for evaluating users
    // The key is a combination (Tuple) of password and username
    // The value is the associated email address
    public Dictionary<(string password, string userName), string> EvaluateUsers { get; set; } = new();

    // Dictionary for storing users by their ID (key)
    public Dictionary<int, User> Users { get; set; } = new();

    // List for storing all products
    public List<Product> ProductsList { get; set; } = new();

    // List for storing all orders
    public List<Orders> OrdersList { get; set; } = new();
    
    // Hash map of favorites: key is (UserId, ProductId), value is isFavorite
    public Dictionary<(int userId, int productId), bool> FavoritesMap { get; set; } = new();

    /**
     * SHOPPING CART
     */

    // ShoppingCartWindow items (key: product, value: Quantity)
    public Dictionary<Product, int> ShoppingCartList { get; set; } = new();

    // Method to add a user to the EvaluateUsers list
    // The user is identified by a combination of password and username (as key)
    // The value is the user's email
    public void AddToEvaluate(User user)
    {
        EvaluateUsers.Add((user.password, user.username), user.email);
    }

    // Method to add or update a user in the database
    // The user is identified by their unique ID
    public void AddUsers(User user)
    {
        Users[user.ID] = user;
    }

    // Method to add a product to the ProductsList
    public void AddProduct(Product product)
    {
        if (ProductsList == null) ProductsList = new List<Product>();

        ProductsList.Add(product);
    }

    // Method to clear the ProductsList
    public void ClearProducts()
    {
        ProductsList.Clear();
    }

    // Method to add an order to the OrdersList
    public void AddOrder(Orders order)
    {
        OrdersList.Add(order);
    }

    // Method to check if username and password are valid
    // Validation is based on the EvaluateUsers database
    public bool ValidateUser(string password, string username)
    {
        // Checks if there is an entry with the combination of password and username
        return EvaluateUsers.ContainsKey((password, username));
    }

    // Method to check if the username exists in combination with the password in the database
    public bool CheckUsername(string password, string username)
    {
        return EvaluateUsers.ContainsKey((password, username));
    }

    // Method to check if the specified email exists
    public bool CheckEmail(string email)
    {
        // Checks if the specified email exists in the values of the EvaluateUsers dictionary
        return EvaluateUsers.ContainsValue(email);
    }

    // Method to add product to shopping cart
    public void AddToShoppingCart(Product product, int quantity)
    {
        if (ShoppingCartList.ContainsKey(product))
            ShoppingCartList[product] += quantity;
        else
            ShoppingCartList[product] = quantity;

        var newQuantity = product.Quantity - quantity;
        DatabaseHandler.UpdateProductQuantity(product.ID, newQuantity, true); // Update Product Quantity in Database;
    }

    // Remove item from shopping cart
    public void RemoveFromShoppingCart(Product product)
    {
        if (ShoppingCartList.ContainsKey(product))
        {
            var originalQuantity = ShoppingCartList[product];
            var newQuantity = product.Quantity + originalQuantity;

            DatabaseHandler.UpdateProductQuantity(product.ID, newQuantity,
                true); // Update Product Quantity in Database;

            ShoppingCartList.Remove(product);
            MessageBox.Show($"{product.Artist} | {product.Title} has been removed from your cart."); // For Debugging
        }
        else
        {
            MessageBox.Show($"{product.Artist} | {product.Title} is not in your cart."); // For Debugging
        }
    }


    // Update Quantity of product in shopping cart
    public void UpdateShoppingCart(Product product, int newQuantity)
    {
        if (ShoppingCartList.ContainsKey(product))
        {
            var originalQuantity = ShoppingCartList[product];
            var quantityDifference = originalQuantity - newQuantity; // Reversed the difference calculation

            // Calculate what the new database quantity would be
            var potentialDbQuantity = product.Quantity + quantityDifference;

            if (potentialDbQuantity < 0)
                MessageBox.Show($"Only {product.Quantity + originalQuantity} items available.", "Insufficient Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (newQuantity > 0)
            {
                // Update database quantity
                DatabaseHandler.UpdateProductQuantity(product.ID, potentialDbQuantity, true);

                // Update cart quantity
                ShoppingCartList[product] = newQuantity;
                MessageBox.Show($"{product.Artist} | {product.Title} has been updated to {newQuantity} in your cart.");
            }
            else
            {
                // Restore original quantity to database
                var restoredQuantity = product.Quantity + originalQuantity;
                DatabaseHandler.UpdateProductQuantity(product.ID, restoredQuantity, true);

                ShoppingCartList.Remove(product);
                MessageBox.Show($"{product.Artist} | {product.Title} has been removed from your cart.");
            }
        }
        else if (newQuantity > 0)
        {
            // Check if there's enough quantity available
            if (newQuantity > product.Quantity)
            {
                MessageBox.Show($"Cannot add {newQuantity} items. Only {product.Quantity} items available.",
                    "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Adding new item to cart
            var updatedDbQuantity = product.Quantity - newQuantity;
            DatabaseHandler.UpdateProductQuantity(product.ID, updatedDbQuantity, true);

            ShoppingCartList.Add(product, newQuantity);
        }
    }

    // Method to clear shopping cart
    public void ClearShoppingCart()
    {
        ShoppingCartList.Clear();
    }


    // Method to cancel an order
    public void CancelOrder()
    {
        DatabaseHandler.ResetProductQuantity();
        ClearShoppingCart();
    }

    // Method to add a product to the FavoritesMap
    public void AddToFavorites(int userId, int productId)
    {
        
    }
}