using MusicStoreApp.data;

namespace MusicStoreApp.gui.admin;

public partial class AdminManageProductsWindow : Form
{
    public AdminManageProductsWindow()
    {
        InitializeComponent();
        DatabaseHandler.Connect();
        Load += SelectManageProducts_Load;
        tb_SearchProduct.TextChanged += tb_SearchProduct_TextChanged;
        btn_ShowCd.Click += btn_ShowCd_Click;
        btn_ShowVinyl.Click += btn_ShowVinyl_Click;
        btn_ShowCassette.Click += btn_ShowCassette_Click;
        btn_Download.Click += btn_Download_Click;
        btn_ShowAll.Click += btn_ShowAll_Click;
    }

    private void SelectManageProducts_Load(object? sender, EventArgs e)
    {
        try
        {
            // Load products from the database
            DatabaseHandler.LoadProducts();

            // Populate the ListBox
            LoadProductsToListBox();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    public void LoadProductsToListBox()
    {
        var productList = DataManager.Instance?.ProductsList;

        // Debugging output: Check if list is generated
        Console.WriteLine($"Number of products loaded: {productList?.Count ?? 0}");

        if (productList == null || productList.Count == 0)
        {
            MessageBox.Show("No products found. DataManager.ProductsList is empty.", "No Products Found");
            return;
        }

        // Clear the ListBox and display products
        lb_ProductList.Items.Clear();
        foreach (var product in productList) lb_ProductList.Items.Add(product);
    }

    public void LoadProductsToListBox(List<Product>? productList = null)
    {
        productList ??= DataManager.Instance?.ProductsList; // Use the provided list or the full list by default

        lb_ProductList.Items.Clear();
        foreach (var product in productList) lb_ProductList.Items.Add(product);
    }

    private void DisplayProducts(Func<Product, bool> predicate)
    {
        var filteredProducts = DataManager.Instance.ProductsList
            .Where(predicate)
            .ToList();

        LoadProductsToListBox(filteredProducts);

        if (filteredProducts.Count == 0) MessageBox.Show("No products found.", "Results");
    }

    private void tb_SearchProduct_TextChanged(object? sender, EventArgs e)
    {
        var query = tb_SearchProduct.Text.Trim();
        if (!string.IsNullOrEmpty(query))
            DisplayProducts(p =>
                p.Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                p.Artist.Contains(query, StringComparison.OrdinalIgnoreCase));
        else
            LoadProductsToListBox();
    }

    private void btn_ShowCd_Click(object? sender, EventArgs e)
    {
        DisplayProducts(p => p.ProductType == ProductType.CD);
    }

    private void btn_ShowVinyl_Click(object? sender, EventArgs e)
    {
        DisplayProducts(p => p.ProductType == ProductType.Vinyl);
    }

    private void btn_ShowCassette_Click(object? sender, EventArgs e)
    {
        DisplayProducts(p => p.ProductType == ProductType.Cassette);
    }

    private void btn_Download_Click(object sender, EventArgs e)
    {
        DisplayProducts(p => p.ProductType == ProductType.Download);
    }

    private void btn_ShowAll_Click(object? sender, EventArgs e)
    {
        LoadProductsToListBox();
    }

    private void btn_EditProduct_Click(object sender, EventArgs e)
    {
        Close();
        var editProductWindow = new AdminEditProductWindow();
        editProductWindow.Show();
    }

    private void btn_DeleteProduct_Click(object sender, EventArgs e)
    {
        if (lb_ProductList.SelectedItem != null)
        {
            var productToDelete = (Product)lb_ProductList.SelectedItem;
            Close();
            DatabaseHandler.DeleteProduct(productToDelete);
            LoadProductsToListBox();
        }
        else
        {
            MessageBox.Show("Please select a product from the list.", "No Product Selected");
        }
    }

    private void btn_AddNewProduct_Click(object sender, EventArgs e)
    {
        Close();
        var addProductWindow = new AdminAddProductWindow();
        addProductWindow.Show();
    }

    private void btn_ReturnToAdminPanel_Click(object sender, EventArgs e)
    {
        Close();
        var adminPanelWindow = new AdminPanelWindow();
        adminPanelWindow.Show();
    }
}