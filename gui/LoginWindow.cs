using MusicStoreApp.data;
using MusicStoreApp.gui.admin;
using MusicStoreApp.gui.user;

namespace MusicStoreApp.gui;

public partial class LoginWindow : Form
{
    private bool isLoggedIn;

    public LoginWindow()
    {
        InitializeComponent();
        DatabaseHandler.Connect();
        isLoggedIn = false;
    }

    private void btn_Login_Click(object sender, EventArgs e)
    {
        var username = tb_Username.Text;
        var password = tb_Password.Text;

        var databaseHandler = new DatabaseHandler();

        var (isLoginSuccessful, isAdmin) = databaseHandler.ValidateLogin(username, password);

        if (isLoginSuccessful)
        {
            isLoggedIn = true;

            // Proceed to UserMainWindow or AdminPanelWindow
            if (isAdmin)
            {
                MessageBox.Show("Login Successful.\nWelcome back!", "Admin Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                var adminPanelWindow = new AdminPanelWindow();
                adminPanelWindow.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login Successful.\nWelcome back!", "User Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                var userMainWindow = new UserMainWindow();
                userMainWindow.Show();
                Hide();
            }
        }
        else
        {
            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void lbl_RegisterHere_Click(object sender, EventArgs e)
    {
        var registrationWindow = new RegistrationWindow();
        registrationWindow.Show();
        Hide();
    }
}