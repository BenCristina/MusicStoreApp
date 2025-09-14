using MusicStoreApp.data;

namespace MusicStoreApp.gui.user;

public partial class UserDisplayAccountDetails : Form
{
    private readonly User? user;

    public UserDisplayAccountDetails(User loggedInUser)
    {
        InitializeComponent();
        user = loggedInUser;
        Load += DisplayAccountDetails_Load;
    }

    private void LoadUserDetailsToListBox()
    {
        // Clear any previous data in the ListBox
        lb_AccountDetails.Items.Clear();

        // Populate the ListBox with user details, omitting the password
        lb_AccountDetails.Items.Add($"Username: {user?.username}");
        lb_AccountDetails.Items.Add($"First Name: {user?.firstName}");
        lb_AccountDetails.Items.Add($"Last Name: {user?.lastName}");
        lb_AccountDetails.Items.Add($"Email: {user?.email}");
        lb_AccountDetails.Items.Add($"Phone: {user?.phone}");
        lb_AccountDetails.Items.Add($"Street: {user?.addressStreet} {user?.addressNumber}");
        lb_AccountDetails.Items.Add($"Zip Code: {user?.addressZipCode}");
        lb_AccountDetails.Items.Add($"City: {user?.addressCity}");
    }

    private void DisplayAccountDetails_Load(object? sender, EventArgs e)
    {
        // Load the logged-in user's details into the ListBox
        LoadUserDetailsToListBox();
    }


    private void btn_UpdateAccountDetails_Click(object? sender, EventArgs e)
    {
        // Open the UpdateAccountWindow
        var updateAccountWindow = new UserUpdateAccountWindow(user);
        updateAccountWindow.Show();
        Close();
    }

    private void btn_Cancel_Click(object? sender, EventArgs e)
    {
        var userMainWindow = new UserMainWindow();
        userMainWindow.Show();
        Close();
    }
}