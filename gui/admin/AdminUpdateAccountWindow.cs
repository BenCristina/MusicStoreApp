using MusicStoreApp.data;

namespace MusicStoreApp.gui.admin;

public partial class AdminUpdateAccountWindow : Form
{
    // This is the basic template for all Forms of the app
    // Please copy and paste to create a new window and use the elements provided for the layout
    // Do not delete :-*  
    public AdminUpdateAccountWindow()
    {
        InitializeComponent();
    }

    private void btn_UpdateAccount_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(tb_FirstName.Text) || string.IsNullOrWhiteSpace(tb_LastName.Text) ||
                string.IsNullOrWhiteSpace(tb_Email.Text) || string.IsNullOrWhiteSpace(tb_Phone.Text) ||
                string.IsNullOrWhiteSpace(tb_StreetName.Text) || string.IsNullOrWhiteSpace(tb_HouseNumber.Text) ||
                string.IsNullOrWhiteSpace(tb_ZipCode.Text) || string.IsNullOrWhiteSpace(tb_City.Text) ||
                string.IsNullOrWhiteSpace(dtp_DateOfBirth.Text))
                MessageBox.Show("Please fill all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var editUser = new User
            {
                firstName = tb_FirstName.Text,
                lastName = tb_LastName.Text,
                email = tb_Email.Text,
                phone = tb_Phone.Text,
                addressStreet = tb_StreetName.Text,
                addressNumber = tb_HouseNumber.Text,
                addressZipCode = tb_ZipCode.Text,
                addressCity = tb_City.Text,
                dateOfBirth = dtp_DateOfBirth.Value.ToString("yyyy-MM-dd")
            };

            var databaseHandler = new DatabaseHandler();
            databaseHandler.EditUser(editUser);

            MessageBox.Show("Account Updated Successfully", "Account Updated", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating account: {ex.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            throw;
        }

        Close();
        var adminManageUsersWindow = new AdminManageUsersWindow();
        adminManageUsersWindow.Show();
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        Close();
        var adminManageUsersWindow = new AdminManageUsersWindow();
        adminManageUsersWindow.Show();
    }
}