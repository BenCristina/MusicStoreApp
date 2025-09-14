using MusicStoreApp.data;

namespace MusicStoreApp.gui.admin;

public partial class AdminEditProductWindow : Form
{
    // This is the basic template for all Forms of the app
    // Please copy and paste to create a new window and use the elements provided for the layout
    // Do not delete :-*  
    public AdminEditProductWindow()
    {
        InitializeComponent();
        PopulateComboBoxes();
    }

    private void PopulateComboBoxes()
    {
        // Populate ProductType ComboBox
        cb_ProductType.DataSource = Enum.GetValues(typeof(ProductType));

        // Populate Genre ComboBox (assuming you have a combobox for Genre named cb_Genre)
        cb_Genre.DataSource = Enum.GetValues(typeof(Genre));
    }

    private void btn_UpdateProduct_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(tb_Artist.Text) ||
                string.IsNullOrWhiteSpace(tb_Title.Text) ||
                string.IsNullOrWhiteSpace(tb_Price.Text) ||
                string.IsNullOrWhiteSpace(tb_Quantity.Text))
            {
                MessageBox.Show("Please fill all the information");
                return;
            }

            var editProduct = new Product
            {
                ProductType = (ProductType)cb_ProductType.SelectedItem,
                Artist = tb_Artist.Text,
                Title = tb_Title.Text,
                Genre = (Genre)cb_Genre.SelectedItem,
                Price = double.Parse(tb_Price.Text),
                Quantity = int.Parse(tb_Quantity.Text)
            };

            // Call EditProducts
            var dbHandler = new DatabaseHandler();
            dbHandler.EditProduct(editProduct);

            MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }

        Close();
        var adminManageProductsWindow = new AdminManageProductsWindow();
        adminManageProductsWindow.Show();
    }

    private void btn_LogoutAndClose_Click(object sender, EventArgs e)
    {
        Close();
        var adminManageProductsWindow = new AdminManageProductsWindow();
        adminManageProductsWindow.Show();
    }
}