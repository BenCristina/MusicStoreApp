using System.Net.Mail;
using MusicStoreApp.data;

namespace MusicStoreApp.gui.user;

public partial class UserUpdateAccountWindow : Form
{
    private readonly User? user; // Logged-in user

    public UserUpdateAccountWindow(User loggedInUser)
    {
        InitializeComponent();
        user = loggedInUser;

        // Populate the form with the user's details'
        if (user != null)
        {
            tb_FirstName.Text = user.firstName;
            tb_LastName.Text = user.lastName;
            tb_Email.Text = user.email;
            tb_Phone.Text = user.phone;
            tb_StreetName.Text = user.addressStreet;
            tb_HouseNumber.Text = user.addressNumber;
            tb_ZipCode.Text = user.addressZipCode;
            tb_City.Text = user.addressCity;
            dtp_DateOfBirth.Text = user.dateOfBirth;
            tb_Username.Text = user.username;
        }
    }

    public User GetUpdatedUserInfo()
    {
        // Update the User object with data from the textboxes
        if (user != null)
        {
            user.firstName = tb_FirstName.Text;
            user.lastName = tb_LastName.Text;
            user.email = tb_Email.Text;
            user.phone = tb_Phone.Text;
            user.addressStreet = tb_StreetName.Text;
            user.addressNumber = tb_HouseNumber.Text;
            user.addressZipCode = tb_ZipCode.Text;
            user.addressCity = tb_City.Text;
            user.dateOfBirth = dtp_DateOfBirth.Value.ToString("yyyy-MM-dd");
            user.username = tb_Username.Text;
            user.password = tb_Password.Text;
            user.password = tb_PasswordRepeat.Text;
        }

        return user;
    }

    private void btn_UpdateAccount_Click(object sender, EventArgs e)
    {
        // Ensure passwords match before continuing
        if (!ArePasswordsMatching()) return;

        // Check for empty fields
        if (string.IsNullOrWhiteSpace(tb_FirstName.Text) ||
            string.IsNullOrWhiteSpace(tb_LastName.Text) ||
            string.IsNullOrWhiteSpace(tb_Email.Text) ||
            string.IsNullOrWhiteSpace(tb_Phone.Text) ||
            string.IsNullOrWhiteSpace(tb_StreetName.Text) ||
            string.IsNullOrWhiteSpace(tb_HouseNumber.Text) ||
            string.IsNullOrWhiteSpace(tb_ZipCode.Text) ||
            string.IsNullOrWhiteSpace(tb_City.Text) ||
            string.IsNullOrWhiteSpace(dtp_DateOfBirth.Text) ||
            string.IsNullOrWhiteSpace(tb_Username.Text) ||
            string.IsNullOrWhiteSpace(tb_Password.Text) ||
            string.IsNullOrWhiteSpace(tb_PasswordRepeat.Text))
        {
            MessageBox.Show("No fields can be empty. Please check your inputs!", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Validate email format
        if (!IsValidEmail(tb_Email.Text))
        {
            MessageBox.Show("Invalid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Get the updated user object
        var updatedUser = GetUpdatedUserInfo();

        // Update the user details in the database
        try
        {
            var databaseHandler = new DatabaseHandler();
            databaseHandler.UpdateUser(updatedUser);

            // Notify the caller (DisplayAccountDetails) of the successful update
            DialogResult = DialogResult.OK;
            MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            var displayAccountDetails = new UserDisplayAccountDetails(updatedUser);
            displayAccountDetails.Show();
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Helper function to validate email format
    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to close without saving changes?", "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            var displayAccountDetails = new UserDisplayAccountDetails(user);
            displayAccountDetails.Show();
            Close();
        }
    }

    private bool ArePasswordsMatching()
    {
        // Trim the text values to prevent leading/trailing spaces causing mismatches
        var password = tb_Password.Text.Trim();
        var passwordRepeat = tb_PasswordRepeat.Text.Trim();

        if (password != passwordRepeat)
        {
            MessageBox.Show("Passwords do not match. Please re-enter them.", "Validation Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }

        return true;
    }
}