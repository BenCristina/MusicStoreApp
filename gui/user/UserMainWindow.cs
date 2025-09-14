using MusicStoreApp.data;

namespace MusicStoreApp.gui.user;

public partial class UserMainWindow : Form
{
    public UserMainWindow()
    {
        InitializeComponent();
        lbl_DisplayFirstName_Updated(); // Update label on window load
    }

    private void lbl_DisplayFirstName_Updated()
    {
        // Retrieve the logged-in user ID
        var loggedInUserId = DatabaseHandler.userIDFromDatabase;

        // Retrieve the logged-in user info
        if (DataManager.Instance.Users.TryGetValue(loggedInUserId, out var loggedInUser))
            // Use FirstName in UI
            lbl_WelcomeMessage.Text = $"Welcome, {loggedInUser.firstName}";
        else
            lbl_WelcomeMessage.Text = "Welcome!";

        Console.WriteLine($"Logged-in User ID: {DatabaseHandler.userIDFromDatabase}"); // Debugging
    }

    private void btn_BrowseProducts_Click(object sender, EventArgs e)
    {
        var selectProductWindow = new UserSelectProductWindow();
        selectProductWindow.Show();
        Hide();
    }

    private void btn_Favorites_Click(object sender, EventArgs e)
    {
        var favoritesWindows = new UserFavoritesWindow();
        favoritesWindows.Show();
        Hide();
    }

    private void btn_AccountDetails_Click(object sender, EventArgs e)
    {
        var loggedInUserId = DatabaseHandler.userIDFromDatabase;
        DataManager.Instance.Users.TryGetValue(loggedInUserId, out var loggedInUser);


        if (loggedInUser != null)
        {
            var displayAccountDetails = new UserDisplayAccountDetails(loggedInUser);
            displayAccountDetails.Show();
            Hide();
        }
        else
        {
            MessageBox.Show("Unable to retrieve user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btn_ShoppingCart_Click(object sender, EventArgs e)
    {
        var shoppingCart = new UserShoppingCartWindow();
        shoppingCart.Show();
        Hide();
    }

    private void btn_PastOrders_Click(object sender, EventArgs e)
    {
        // MessageBox.Show("Favorites are not yet implemented.\nWe're working on it.", "Not implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        // TODO: Edit revieOrdersWindow to list past orders
        var reviewOrdersWindow = new UserReviewOrdersWindow();
        reviewOrdersWindow.Show();
        Hide();
    }

    private void btn_Logout_Click(object sender, EventArgs e)
    {
        var loginWindow = new LoginWindow();
        loginWindow.Show();
        Close();
    }
}