using MusicStoreApp.data;

namespace MusicStoreApp;

public partial class UserDeliveryAddressWindow : Form
{
    private readonly User? user; // Logged-in user

    public UserDeliveryAddressWindow(User loggedInUser)
    {
        InitializeComponent();
        user = loggedInUser;

        // Load detail into textboxes
        if (user != null)
        {
            tb_FirstName.Text = user.firstName;
            tb_LastName.Text = user.lastName;
            tb_StreetName.Text = user.addressStreet;
            tb_HouseNumber.Text = user.addressNumber;
            tb_ZipCode.Text = user.addressZipCode;
            tb_City.Text = user.addressCity;
        }
    }

    public User GetUpdatedUserAddress()
    {
        // Update the User object with data from the textboxes
        if (user != null)
        {
            user.firstName = tb_FirstName.Text;
            user.lastName = tb_LastName.Text;
            user.addressStreet = tb_StreetName.Text;
            user.addressNumber = tb_HouseNumber.Text;
            user.addressZipCode = tb_ZipCode.Text;
            user.addressCity = tb_City.Text;
        }

        return user;
    }

    private void btn_update_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btn_cancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    public bool UpdateAccountInDatabase()
    {
        if (!cb_UpdateAccount.Checked) return false;

        return true;
    }

    private void cb_UpdateAccount_CheckedChanged(object sender, EventArgs e)
    {
        // Nothing to do here
    }
}