namespace MusicStoreApp.gui.admin;

public partial class AdminManageUsersWindow : Form
{
    // This is the basic template for all Forms of the app
    // Please copy and paste to create a new window and use the elements provided for the layout
    // Do not delete :-*  
    public AdminManageUsersWindow()
    {
        InitializeComponent();
    }

    private void btn_OpenOrders_Click(object sender, EventArgs e)
    {
        var adminManageOrdersWindow = new AdminManageOrdersWindow();
        adminManageOrdersWindow.Show();
    }

    private void btn_EditUser_Click(object sender, EventArgs e)
    {
        var adminUpdateAccountWindow = new AdminUpdateAccountWindow();
        adminUpdateAccountWindow.Show();
    }

    private void btn_ResetPassword_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void btn_EmailUser_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void btn_ReturnToMainWindow_Click(object sender, EventArgs e)
    {
        var adminPanelWindow = new AdminPanelWindow();
        adminPanelWindow.Show();
        Close();
    }
}