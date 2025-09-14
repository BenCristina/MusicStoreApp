using MusicStoreApp.data;

namespace MusicStoreApp.gui;

public partial class RegistrationWindow : Form
{
    public RegistrationWindow()
    {
        InitializeComponent();
    }

    private void btn_CreateAccount_Click(object sender, EventArgs e)
    {
        try
        {
            // Validate form inputs
            if (string.IsNullOrWhiteSpace(tb_Username.Text) ||
                string.IsNullOrWhiteSpace(tb_Password.Text))
            {
                MessageBox.Show("Username and Password are required.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(dtp_DateOfBirth.Text) || dtp_DateOfBirth.Value == DateTime.MinValue)
            {
                MessageBox.Show("Date of Birth is required.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Check if the Password and Password Repeat fields match
            if (!ArePasswordsMatching()) return; // Exit the method if passwords do not match

            if (string.IsNullOrWhiteSpace(dtp_DateOfBirth.Text) || dtp_DateOfBirth.Value == DateTime.MinValue)
            {
                MessageBox.Show("Date of Birth is required.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var newUser = new User
            {
                firstName = tb_FirstName.Text,
                lastName = tb_LastName.Text,
                email = tb_Email.Text,
                phone = tb_Phone.Text,
                addressStreet = tb_StreetName.Text,
                addressNumber = tb_HouseNumber.Text,
                addressCity = tb_City.Text,
                addressZipCode = tb_ZipCode.Text,
                dateOfBirth = dtp_DateOfBirth.Value.ToString("yyyy-MM-dd"),
                username = tb_Username.Text,
                password = tb_Password.Text
            };

            // Call RegisterUser
            var databaseHandler = new DatabaseHandler();
            databaseHandler.RegisterUser(newUser);

            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            var loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }
        catch (Exception ex)
        {
            // Show the error message to get more debugging information
            MessageBox.Show($"Error during registration: {ex.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void lbl_BackToLogin_Click(object sender, EventArgs e)
    {
        var loginWindow = new LoginWindow();
        loginWindow.Show();
        Close();
    }

    // TODO: Write function to check that password is typed in identically twice
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