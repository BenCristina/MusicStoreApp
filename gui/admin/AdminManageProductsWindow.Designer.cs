namespace MusicStoreApp.gui.admin;

partial class AdminManageProductsWindow
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
        lb_ProductList = new System.Windows.Forms.ListBox();
        lbl_WindowInfo = new System.Windows.Forms.Label();
        btn_EditProduct = new System.Windows.Forms.Button();
        btn_ShowCd = new System.Windows.Forms.Button();
        btn_ShowVinyl = new System.Windows.Forms.Button();
        btn_ShowCassette = new System.Windows.Forms.Button();
        tb_SearchProduct = new System.Windows.Forms.TextBox();
        btn_AddNewProduct = new System.Windows.Forms.Button();
        btn_ReturnToAdminPanel = new System.Windows.Forms.Button();
        btn_DeleteProduct = new System.Windows.Forms.Button();
        btn_Download = new System.Windows.Forms.Button();
        lbl_WelcomeMessage = new System.Windows.Forms.Label();
        lbl_Search = new System.Windows.Forms.Label();
        btn_ShowAll = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lb_ProductList
        // 
        lb_ProductList.BackColor = System.Drawing.Color.Honeydew;
        lb_ProductList.FormattingEnabled = true;
        lb_ProductList.Location = new System.Drawing.Point(40, 180);
        lb_ProductList.Name = "lb_ProductList";
        lb_ProductList.Size = new System.Drawing.Size(1100, 484);
        lb_ProductList.TabIndex = 102;
        // 
        // lbl_WindowInfo
        // 
        lbl_WindowInfo.BackColor = System.Drawing.Color.Transparent;
        lbl_WindowInfo.ForeColor = System.Drawing.Color.Aquamarine;
        lbl_WindowInfo.Location = new System.Drawing.Point(40, 60);
        lbl_WindowInfo.Name = "lbl_WindowInfo";
        lbl_WindowInfo.Size = new System.Drawing.Size(372, 20);
        lbl_WindowInfo.TabIndex = 101;
        lbl_WindowInfo.Text = "You can manage your inventory here.";
        lbl_WindowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_EditProduct
        // 
        btn_EditProduct.BackColor = System.Drawing.Color.PaleTurquoise;
        btn_EditProduct.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_EditProduct.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_EditProduct.Location = new System.Drawing.Point(260, 680);
        btn_EditProduct.Name = "btn_EditProduct";
        btn_EditProduct.Size = new System.Drawing.Size(200, 40);
        btn_EditProduct.TabIndex = 5;
        btn_EditProduct.Text = "Edit product";
        btn_EditProduct.UseVisualStyleBackColor = false;
        btn_EditProduct.Click += btn_EditProduct_Click;
        // 
        // btn_ShowCd
        // 
        btn_ShowCd.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_ShowCd.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowCd.ForeColor = System.Drawing.Color.DarkSlateGray;
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
        btn_ShowVinyl.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_ShowVinyl.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowVinyl.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_ShowVinyl.Location = new System.Drawing.Point(176, 130);
        btn_ShowVinyl.Name = "btn_ShowVinyl";
        btn_ShowVinyl.Size = new System.Drawing.Size(120, 40);
        btn_ShowVinyl.TabIndex = 2;
        btn_ShowVinyl.Text = "Vinyl";
        btn_ShowVinyl.UseVisualStyleBackColor = false;
        btn_ShowVinyl.Click += btn_ShowVinyl_Click;
        // 
        // btn_ShowCassette
        // 
        btn_ShowCassette.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_ShowCassette.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowCassette.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_ShowCassette.Location = new System.Drawing.Point(313, 130);
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
        tb_SearchProduct.Size = new System.Drawing.Size(464, 23);
        tb_SearchProduct.TabIndex = 0;
        // 
        // btn_AddNewProduct
        // 
        btn_AddNewProduct.BackColor = System.Drawing.Color.SpringGreen;
        btn_AddNewProduct.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_AddNewProduct.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_AddNewProduct.Location = new System.Drawing.Point(40, 680);
        btn_AddNewProduct.Name = "btn_AddNewProduct";
        btn_AddNewProduct.Size = new System.Drawing.Size(200, 40);
        btn_AddNewProduct.TabIndex = 4;
        btn_AddNewProduct.Text = "Add new product";
        btn_AddNewProduct.UseVisualStyleBackColor = false;
        btn_AddNewProduct.Click += btn_AddNewProduct_Click;
        // 
        // btn_ReturnToAdminPanel
        // 
        btn_ReturnToAdminPanel.BackColor = System.Drawing.Color.Crimson;
        btn_ReturnToAdminPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_ReturnToAdminPanel.ForeColor = System.Drawing.Color.Honeydew;
        btn_ReturnToAdminPanel.Location = new System.Drawing.Point(820, 680);
        btn_ReturnToAdminPanel.Name = "btn_ReturnToAdminPanel";
        btn_ReturnToAdminPanel.Size = new System.Drawing.Size(320, 40);
        btn_ReturnToAdminPanel.TabIndex = 7;
        btn_ReturnToAdminPanel.Text = "Return to Admin Panel";
        btn_ReturnToAdminPanel.UseVisualStyleBackColor = false;
        btn_ReturnToAdminPanel.Click += btn_ReturnToAdminPanel_Click;
        // 
        // btn_DeleteProduct
        // 
        btn_DeleteProduct.BackColor = System.Drawing.Color.Tomato;
        btn_DeleteProduct.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_DeleteProduct.ForeColor = System.Drawing.Color.Honeydew;
        btn_DeleteProduct.Location = new System.Drawing.Point(480, 680);
        btn_DeleteProduct.Name = "btn_DeleteProduct";
        btn_DeleteProduct.Size = new System.Drawing.Size(200, 40);
        btn_DeleteProduct.TabIndex = 6;
        btn_DeleteProduct.Text = "Delete product";
        btn_DeleteProduct.UseVisualStyleBackColor = false;
        btn_DeleteProduct.Click += btn_DeleteProduct_Click;
        // 
        // btn_Download
        // 
        btn_Download.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_Download.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Download.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_Download.Location = new System.Drawing.Point(448, 130);
        btn_Download.Name = "btn_Download";
        btn_Download.Size = new System.Drawing.Size(120, 40);
        btn_Download.TabIndex = 103;
        btn_Download.Text = "Download";
        btn_Download.UseVisualStyleBackColor = false;
        btn_Download.Click += btn_Download_Click;
        // 
        // lbl_WelcomeMessage
        // 
        lbl_WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
        lbl_WelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_WelcomeMessage.ForeColor = System.Drawing.Color.Honeydew;
        lbl_WelcomeMessage.Location = new System.Drawing.Point(40, 40);
        lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
        lbl_WelcomeMessage.Size = new System.Drawing.Size(397, 20);
        lbl_WelcomeMessage.TabIndex = 100;
        lbl_WelcomeMessage.Text = "Welcome to the MusicStore inventory management system";
        lbl_WelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_Search
        // 
        lbl_Search.BackColor = System.Drawing.Color.Transparent;
        lbl_Search.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Search.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Search.Location = new System.Drawing.Point(40, 89);
        lbl_Search.Name = "lbl_Search";
        lbl_Search.Size = new System.Drawing.Size(57, 20);
        lbl_Search.TabIndex = 104;
        lbl_Search.Text = "Search:";
        lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_ShowAll
        // 
        btn_ShowAll.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_ShowAll.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ShowAll.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_ShowAll.Location = new System.Drawing.Point(584, 130);
        btn_ShowAll.Name = "btn_ShowAll";
        btn_ShowAll.Size = new System.Drawing.Size(120, 40);
        btn_ShowAll.TabIndex = 105;
        btn_ShowAll.Text = "ShowAll";
        btn_ShowAll.UseVisualStyleBackColor = false;
        btn_ShowAll.Click += btn_ShowAll_Click;
        // 
        // AdminManageProductsWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Teal;
        ClientSize = new System.Drawing.Size(1184, 761);
        Controls.Add(btn_ShowAll);
        Controls.Add(lbl_Search);
        Controls.Add(btn_Download);
        Controls.Add(btn_DeleteProduct);
        Controls.Add(btn_ReturnToAdminPanel);
        Controls.Add(btn_AddNewProduct);
        Controls.Add(tb_SearchProduct);
        Controls.Add(btn_ShowCassette);
        Controls.Add(btn_ShowVinyl);
        Controls.Add(btn_ShowCd);
        Controls.Add(lbl_WelcomeMessage);
        Controls.Add(btn_EditProduct);
        Controls.Add(lbl_WindowInfo);
        Controls.Add(lb_ProductList);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(1200, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(1200, 800);
        Opacity = 0.95D;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Manage Product";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btn_ShowAll;

    private System.Windows.Forms.Label lbl_Search;

    private System.Windows.Forms.Button btn_Download;

    private System.Windows.Forms.Button btn_DeleteProduct;

    private System.Windows.Forms.Button btn_ReturnToAdminPanel;

    private System.Windows.Forms.Button btn_ShowVinyl;
    private System.Windows.Forms.Button btn_ShowCassette;
    private System.Windows.Forms.TextBox tb_SearchProduct;

    private System.Windows.Forms.Label lbl_WelcomeMessage;

    private System.Windows.Forms.Button btn_ShowCd;

    private System.Windows.Forms.Button btn_EditProduct;

    private System.Windows.Forms.Label lbl_WindowInfo;

    private System.Windows.Forms.Button btn_AddNewProduct;

    private System.Windows.Forms.ListBox lb_ProductList;

    #endregion
}