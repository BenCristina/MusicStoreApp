using MusicStoreApp.data;

namespace MusicStoreApp.gui.admin;

public partial class AdminPanelWindow : Form
{
    public AdminPanelWindow()
    {
        InitializeComponent();
        lbl_DisplayFirstName_Updated(); // Update label on window load
    }

    private void lbl_FirstName_Update(object sender, EventArgs e)
    {
        throw new NotImplementedException();
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

    private void btn_ManageProducts_Click(object sender, EventArgs e)
    {
        var adminManageProductsWindow = new AdminManageProductsWindow();
        adminManageProductsWindow.Show();
        Close();
    }

    private void btn_ManageUsers_Click(object sender, EventArgs e)
    {
        var adminManageUsersWindow = new AdminManageUsersWindow();
        adminManageUsersWindow.Show();
        Close();
    }

    private void btn_ManageOrders_Click(object sender, EventArgs e)
    {
        var adminManageOrdersWindow = new AdminManageOrdersWindow();
        adminManageOrdersWindow.Show();
        Close();
    }

    private void btn_LogoutAndClose_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Thank you for using MusicStore. Goodbye!", "Goodbye", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        Application.Exit();
    }
}