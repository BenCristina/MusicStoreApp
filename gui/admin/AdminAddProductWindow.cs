using MusicStoreApp.data;

namespace MusicStoreApp.gui.admin;

public partial class AdminAddProductWindow : Form
{
    public AdminAddProductWindow()
    {
        InitializeComponent();
        PopulateComboBoxes();
    }


    private void PopulateComboBoxes()
    {
        // Populate the ProductType combo box
        cb_ProductType.DataSource = Enum.GetValues(typeof(ProductType));

        // Populate the Genre combo box
        cb_genre.DataSource = Enum.GetValues(typeof(Genre));
    }

    private void btn_AddNewProduct_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(tb_Artist.Text) ||
                string.IsNullOrWhiteSpace(tb_Title.Text) ||
                string.IsNullOrWhiteSpace(tb_Price.Text) ||
                string.IsNullOrWhiteSpace(tb_Quantity.Text))
            {
                MessageBox.Show("Please fill all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newProduct = new Product
            {
                ProductType = (ProductType)cb_ProductType.SelectedItem,
                Artist = tb_Artist.Text,
                Title = tb_Title.Text,
                Genre = (Genre)cb_genre.SelectedItem,
                Price = double.Parse(tb_Price.Text),
                Quantity = int.Parse(tb_Quantity.Text),
                ImageUrl = textBox1.Text,
                ReleaseYear = int.Parse(textBox2.Text)
            };

            // Call AddProducts
            var dbHandler = new DatabaseHandler();
            dbHandler.AddNewProduct(newProduct);

            MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
            var adminManageProductsWindow = new AdminManageProductsWindow();
            adminManageProductsWindow.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btn_CancelAndClose_Click(object sender, EventArgs e)
    {
        Close();
        var adminManageProductsWindow = new AdminManageProductsWindow();
        adminManageProductsWindow.Show();
    }

    private void cb_genre_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
}