namespace MusicStoreApp.gui.admin;

public partial class AdminResetPasswordWindow : Form
{
    public AdminResetPasswordWindow()
    {
        InitializeComponent();
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        Close();
        var adminManageUsersWindow = new AdminManageUsersWindow();
        adminManageUsersWindow.Show();
    }

    private void btn_ResetPassword_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}