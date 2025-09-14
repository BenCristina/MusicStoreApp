namespace MusicStoreApp.gui.user;

partial class UserSelectProductWindow   
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lbl_WindowInfo = new System.Windows.Forms.Label();
        btn_AddToShoppingCart = new System.Windows.Forms.Button();
        lbl_WelcomeMessage = new System.Windows.Forms.Label();
        btn_ShowCd = new System.Windows.Forms.Button();
        btn_ShowVinyl = new System.Windows.Forms.Button();
        btn_ShowCassette = new System.Windows.Forms.Button();
        tb_SearchProduct = new System.Windows.Forms.TextBox();
        btn_AddToFavorites = new System.Windows.Forms.Button();
        btn_CancelAndClose = new System.Windows.Forms.Button();
        btn_ShowProductDetails = new System.Windows.Forms.Button();
        btn_OpenShoppingCart = new System.Windows.Forms.Button();
        btn_ShowFavorites = new System.Windows.Forms.Button();
        lb_ProductList = new System.Windows.Forms.ListBox();
        btn_ShowAll = new System.Windows.Forms.Button();
        lbl_Search = new System.Windows.Forms.Label();
        btn_ShowDownload = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lbl_WindowInfo
        // 
        lbl_WindowInfo.BackColor = System.Drawing.Color.Transparent;
        lbl_WindowInfo.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_WindowInfo.Location = new System.Drawing.Point(40, 60);
        lbl_WindowInfo.Name = "lbl_WindowInfo";
        lbl_WindowInfo.Size = new System.Drawing.Size(372, 20);
        lbl_WindowInfo.TabIndex = 101;
        lbl_WindowInfo.Text = "Feel free to browse and get inspired by our catalogue.";
        lbl_WindowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_AddToShoppingCart
        // 
        btn_AddToShoppingCart.BackColor = System.Drawing.Color.PaleGreen;
        btn_AddToShoppingCart.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_AddToShoppingCart.ForeColor = System.Drawing.Color.DarkGreen;
        btn_AddToShoppingCart.Location = new System.Drawing.Point(40, 680);
        btn_AddToShoppingCart.Name = "btn_AddToShoppingCart";
        btn_AddToShoppingCart.Size = new System.Drawing.Size(160, 40);
        btn_AddToShoppingCart.TabIndex = 4;
        btn_AddToShoppingCart.Text = "Add to shopping cart";
        btn_AddToShoppingCart.UseVisualStyleBackColor = false;
        btn_AddToShoppingCart.Click += btn_AddToShoppingCart_Click;
        // 
        // lbl_WelcomeMessage
        // 
        lbl_WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
        lbl_WelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_WelcomeMessage.ForeColor = System.Drawing.Color.Honeydew;
        lbl_WelcomeMessage.Location = new System.Drawing.Point(40, 40);
        lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
        lbl_WelcomeMessage.Size = new System.Drawing.Size(372, 20);
        lbl_WelcomeMessage.TabIndex = 100;
        lbl_WelcomeMessage.Text = "Welcome to the MusicStore";
        lbl_WelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_ShowCd
        // 
        btn_ShowCd.BackColor = System.Drawing.Color.PaleGreen;
        btn_ShowCd.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowCd.ForeColor = System.Drawing.Color.DarkGreen;
        btn_ShowCd.Location = new System.Drawing.Point(40, 130);
        btn_ShowCd.Name = "btn_ShowCd";
        btn_ShowCd.Size = new System.Drawing.Size(120, 40);
        btn_ShowCd.TabIndex = 1;
        btn_ShowCd.Text = "CD";
        btn_ShowCd.UseVisualStyleBackColor = false;
        btn_ShowCd.Click += btn_ShowCd_Click;
        // 
        // btn_ShowVinyl
        // 
        btn_ShowVinyl.BackColor = System.Drawing.Color.PaleGreen;
        btn_ShowVinyl.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowVinyl.ForeColor = System.Drawing.Color.DarkGreen;
        btn_ShowVinyl.Location = new System.Drawing.Point(166, 130);
        btn_ShowVinyl.Name = "btn_ShowVinyl";
        btn_ShowVinyl.Size = new System.Drawing.Size(120, 40);
        btn_ShowVinyl.TabIndex = 2;
        btn_ShowVinyl.Text = "Vinyl";
        btn_ShowVinyl.UseVisualStyleBackColor = false;
        btn_ShowVinyl.Click += btn_ShowVinyl_Click;
        // 
        // btn_ShowCassette
        // 
        btn_ShowCassette.BackColor = System.Drawing.Color.PaleGreen;
        btn_ShowCassette.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowCassette.ForeColor = System.Drawing.Color.DarkGreen;
        btn_ShowCassette.Location = new System.Drawing.Point(292, 130);
        btn_ShowCassette.Name = "btn_ShowCassette";
        btn_ShowCassette.Size = new System.Drawing.Size(120, 40);
        btn_ShowCassette.TabIndex = 3;
        btn_ShowCassette.Text = "Cassette";
        btn_ShowCassette.UseVisualStyleBackColor = false;
        btn_ShowCassette.Click += btn_ShowCassette_Click;
        // 
        // tb_SearchProduct
        // 
        tb_SearchProduct.BackColor = System.Drawing.Color.Honeydew;
        tb_SearchProduct.Location = new System.Drawing.Point(104, 90);
        tb_SearchProduct.Name = "tb_SearchProduct";
        tb_SearchProduct.Size = new System.Drawing.Size(434, 23);
        tb_SearchProduct.TabIndex = 0;
        tb_SearchProduct.TextChanged += tb_SearchProduct_TextChanged;
        // 
        // btn_AddToFavorites
        // 
        btn_AddToFavorites.BackColor = System.Drawing.Color.PaleGreen;
        btn_AddToFavorites.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_AddToFavorites.ForeColor = System.Drawing.Color.DarkGreen;
        btn_AddToFavorites.Location = new System.Drawing.Point(400, 680);
        btn_AddToFavorites.Name = "btn_AddToFavorites";
        btn_AddToFavorites.Size = new System.Drawing.Size(160, 40);
        btn_AddToFavorites.TabIndex = 6;
        btn_AddToFavorites.Text = "Add to favorites";
        btn_AddToFavorites.UseVisualStyleBackColor = false;
        btn_AddToFavorites.Click += btn_AddToFavorites_Click;
        // 
        // btn_CancelAndClose
        // 
        btn_CancelAndClose.BackColor = System.Drawing.Color.Crimson;
        btn_CancelAndClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_CancelAndClose.ForeColor = System.Drawing.Color.Honeydew;
        btn_CancelAndClose.Location = new System.Drawing.Point(960, 680);
        btn_CancelAndClose.Name = "btn_CancelAndClose";
        btn_CancelAndClose.Size = new System.Drawing.Size(160, 40);
        btn_CancelAndClose.TabIndex = 9;
        btn_CancelAndClose.Text = "Cancel and close";
        btn_CancelAndClose.UseVisualStyleBackColor = false;
        btn_CancelAndClose.Click += btn_CancelAndClose_Click;
        // 
        // btn_ShowProductDetails
        // 
        btn_ShowProductDetails.BackColor = System.Drawing.Color.PaleGreen;
        btn_ShowProductDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowProductDetails.ForeColor = System.Drawing.Color.DarkGreen;
        btn_ShowProductDetails.Location = new System.Drawing.Point(760, 680);
        btn_ShowProductDetails.Name = "btn_ShowProductDetails";
        btn_ShowProductDetails.Size = new System.Drawing.Size(160, 40);
        btn_ShowProductDetails.TabIndex = 8;
        btn_ShowProductDetails.Text = "Show product details";
        btn_ShowProductDetails.UseVisualStyleBackColor = false;
        btn_ShowProductDetails.Click += btn_ShowProductDetails_Click;
        // 
        // btn_OpenShoppingCart
        // 
        btn_OpenShoppingCart.BackColor = System.Drawing.Color.PaleGreen;
        btn_OpenShoppingCart.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_OpenShoppingCart.ForeColor = System.Drawing.Color.DarkGreen;
        btn_OpenShoppingCart.Location = new System.Drawing.Point(220, 680);
        btn_OpenShoppingCart.Name = "btn_OpenShoppingCart";
        btn_OpenShoppingCart.Size = new System.Drawing.Size(160, 40);
        btn_OpenShoppingCart.TabIndex = 5;
        btn_OpenShoppingCart.Text = "Open shopping cart";
        btn_OpenShoppingCart.UseVisualStyleBackColor = false;
        btn_OpenShoppingCart.Click += btn_OpenShoppingCart_Click;
        // 
        // btn_ShowFavorites
        // 
        btn_ShowFavorites.BackColor = System.Drawing.Color.PaleGreen;
        btn_ShowFavorites.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowFavorites.ForeColor = System.Drawing.Color.DarkGreen;
        btn_ShowFavorites.Location = new System.Drawing.Point(580, 680);
        btn_ShowFavorites.Name = "btn_ShowFavorites";
        btn_ShowFavorites.Size = new System.Drawing.Size(160, 40);
        btn_ShowFavorites.TabIndex = 7;
        btn_ShowFavorites.Text = "Show favorites";
        btn_ShowFavorites.UseVisualStyleBackColor = false;
        btn_ShowFavorites.Click += btn_ShowFavorites_Click;
        // 
        // lb_ProductList
        // 
        lb_ProductList.BackColor = System.Drawing.Color.Honeydew;
        lb_ProductList.Font = new System.Drawing.Font("Segoe UI", 10F);
        lb_ProductList.FormattingEnabled = true;
        lb_ProductList.Location = new System.Drawing.Point(40, 200);
        lb_ProductList.Name = "lb_ProductList";
        lb_ProductList.Size = new System.Drawing.Size(1080, 395);
        lb_ProductList.TabIndex = 102;
        // 
        // btn_ShowAll
        // 
        btn_ShowAll.BackColor = System.Drawing.Color.PaleGreen;
        btn_ShowAll.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowAll.ForeColor = System.Drawing.Color.DarkGreen;
        btn_ShowAll.Location = new System.Drawing.Point(544, 130);
        btn_ShowAll.Name = "btn_ShowAll";
        btn_ShowAll.Size = new System.Drawing.Size(120, 40);
        btn_ShowAll.TabIndex = 103;
        btn_ShowAll.Text = "Show all";
        btn_ShowAll.UseVisualStyleBackColor = false;
        btn_ShowAll.Click += btn_ShowAll_Click;
        // 
        // lbl_Search
        // 
        lbl_Search.BackColor = System.Drawing.Color.Transparent;
        lbl_Search.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Search.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Search.Location = new System.Drawing.Point(40, 90);
        lbl_Search.Name = "lbl_Search";
        lbl_Search.Size = new System.Drawing.Size(58, 20);
        lbl_Search.TabIndex = 104;
        lbl_Search.Text = "Search:";
        lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_ShowDownload
        // 
        btn_ShowDownload.BackColor = System.Drawing.Color.PaleGreen;
        btn_ShowDownload.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowDownload.ForeColor = System.Drawing.Color.DarkGreen;
        btn_ShowDownload.Location = new System.Drawing.Point(418, 130);
        btn_ShowDownload.Name = "btn_ShowDownload";
        btn_ShowDownload.Size = new System.Drawing.Size(120, 40);
        btn_ShowDownload.TabIndex = 105;
        btn_ShowDownload.Text = "Download";
        btn_ShowDownload.UseVisualStyleBackColor = false;
        btn_ShowDownload.Click += btn_ShowDownload_Click;
        // 
        // SelectProductWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.SeaGreen;
        ClientSize = new System.Drawing.Size(1184, 761);
        Controls.Add(btn_ShowDownload);
        Controls.Add(lbl_Search);
        Controls.Add(btn_ShowAll);
        Controls.Add(lb_ProductList);
        Controls.Add(btn_ShowFavorites);
        Controls.Add(btn_OpenShoppingCart);
        Controls.Add(btn_ShowProductDetails);
        Controls.Add(btn_CancelAndClose);
        Controls.Add(btn_AddToFavorites);
        Controls.Add(tb_SearchProduct);
        Controls.Add(btn_ShowCassette);
        Controls.Add(btn_ShowVinyl);
        Controls.Add(btn_ShowCd);
        Controls.Add(lbl_WelcomeMessage);
        Controls.Add(btn_AddToShoppingCart);
        Controls.Add(lbl_WindowInfo);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(1200, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(1200, 800);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Products";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btn_ShowDownload;

    private System.Windows.Forms.Label lbl_Search;

    private System.Windows.Forms.Button btn_ShowAll;

    private System.Windows.Forms.ListBox lb_ProductList;

    private System.Windows.Forms.Button btn_OpenShoppingCart;
    private System.Windows.Forms.Button btn_ShowFavorites;

    private System.Windows.Forms.Button btn_ShowProductDetails;

    private System.Windows.Forms.Button btn_CancelAndClose;

    private System.Windows.Forms.Button btn_ShowVinyl;
    private System.Windows.Forms.Button btn_ShowCassette;
    private System.Windows.Forms.TextBox tb_SearchProduct;

    private System.Windows.Forms.Label lbl_WelcomeMessage;

    private System.Windows.Forms.Button btn_ShowCd;

    private System.Windows.Forms.Button btn_AddToShoppingCart;

    private System.Windows.Forms.Label lbl_WindowInfo;

    private System.Windows.Forms.Button btn_AddToFavorites;

    #endregion
}