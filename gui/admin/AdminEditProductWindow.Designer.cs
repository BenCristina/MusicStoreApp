namespace MusicStoreApp.gui.admin;

partial class AdminEditProductWindow
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
        lbl_WelcomeMessage = new System.Windows.Forms.Label();
        btn_UpdateProduct = new System.Windows.Forms.Button();
        tb_Artist = new System.Windows.Forms.TextBox();
        btn_CancelAndClose = new System.Windows.Forms.Button();
        cb_ProductType = new System.Windows.Forms.ComboBox();
        lbl_SelectType = new System.Windows.Forms.Label();
        lbl_Artist = new System.Windows.Forms.Label();
        lbl_Title = new System.Windows.Forms.Label();
        tb_Title = new System.Windows.Forms.TextBox();
        lbl_Genre = new System.Windows.Forms.Label();
        lbl_Price = new System.Windows.Forms.Label();
        tb_Price = new System.Windows.Forms.TextBox();
        lbl_Quantity = new System.Windows.Forms.Label();
        tb_Quantity = new System.Windows.Forms.TextBox();
        cb_Genre = new System.Windows.Forms.ComboBox();
        SuspendLayout();
        // 
        // lbl_WindowInfo
        // 
        lbl_WindowInfo.BackColor = System.Drawing.Color.Transparent;
        lbl_WindowInfo.ForeColor = System.Drawing.Color.Aquamarine;
        lbl_WindowInfo.Location = new System.Drawing.Point(40, 60);
        lbl_WindowInfo.Name = "lbl_WindowInfo";
        lbl_WindowInfo.Size = new System.Drawing.Size(372, 20);
        lbl_WindowInfo.TabIndex = 101;
        lbl_WindowInfo.Text = "Product IDs will not be changed";
        lbl_WindowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
        lbl_WelcomeMessage.Text = "Edit your existing products here";
        lbl_WelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_UpdateProduct
        // 
        btn_UpdateProduct.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_UpdateProduct.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_UpdateProduct.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_UpdateProduct.Location = new System.Drawing.Point(40, 480);
        btn_UpdateProduct.Name = "btn_UpdateProduct";
        btn_UpdateProduct.Size = new System.Drawing.Size(422, 40);
        btn_UpdateProduct.TabIndex = 6;
        btn_UpdateProduct.Text = "Update product details";
        btn_UpdateProduct.UseVisualStyleBackColor = false;
        btn_UpdateProduct.Click += btn_UpdateProduct_Click;
        // 
        // tb_Artist
        // 
        tb_Artist.BackColor = System.Drawing.Color.Honeydew;
        tb_Artist.Location = new System.Drawing.Point(40, 185);
        tb_Artist.Name = "tb_Artist";
        tb_Artist.Size = new System.Drawing.Size(420, 23);
        tb_Artist.TabIndex = 1;
        // 
        // btn_CancelAndClose
        // 
        btn_CancelAndClose.BackColor = System.Drawing.Color.Crimson;
        btn_CancelAndClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_CancelAndClose.ForeColor = System.Drawing.Color.Honeydew;
        btn_CancelAndClose.Location = new System.Drawing.Point(260, 680);
        btn_CancelAndClose.Name = "btn_CancelAndClose";
        btn_CancelAndClose.Size = new System.Drawing.Size(200, 40);
        btn_CancelAndClose.TabIndex = 7;
        btn_CancelAndClose.Text = "Cancel and close";
        btn_CancelAndClose.UseVisualStyleBackColor = false;
        btn_CancelAndClose.Click += btn_LogoutAndClose_Click;
        // 
        // cb_ProductType
        // 
        cb_ProductType.BackColor = System.Drawing.Color.Honeydew;
        cb_ProductType.FormattingEnabled = true;
        cb_ProductType.Location = new System.Drawing.Point(40, 125);
        cb_ProductType.Name = "cb_ProductType";
        cb_ProductType.Size = new System.Drawing.Size(420, 23);
        cb_ProductType.TabIndex = 0;
        // 
        // lbl_SelectType
        // 
        lbl_SelectType.BackColor = System.Drawing.Color.Transparent;
        lbl_SelectType.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_SelectType.ForeColor = System.Drawing.Color.Honeydew;
        lbl_SelectType.Location = new System.Drawing.Point(40, 100);
        lbl_SelectType.Name = "lbl_SelectType";
        lbl_SelectType.Size = new System.Drawing.Size(420, 20);
        lbl_SelectType.TabIndex = 102;
        lbl_SelectType.Text = "Select product type";
        lbl_SelectType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_Artist
        // 
        lbl_Artist.BackColor = System.Drawing.Color.Transparent;
        lbl_Artist.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Artist.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Artist.Location = new System.Drawing.Point(40, 160);
        lbl_Artist.Name = "lbl_Artist";
        lbl_Artist.Size = new System.Drawing.Size(420, 20);
        lbl_Artist.TabIndex = 103;
        lbl_Artist.Text = "Artist";
        lbl_Artist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_Title
        // 
        lbl_Title.BackColor = System.Drawing.Color.Transparent;
        lbl_Title.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Title.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Title.Location = new System.Drawing.Point(40, 220);
        lbl_Title.Name = "lbl_Title";
        lbl_Title.Size = new System.Drawing.Size(420, 20);
        lbl_Title.TabIndex = 104;
        lbl_Title.Text = "Title";
        lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tb_Title
        // 
        tb_Title.BackColor = System.Drawing.Color.Honeydew;
        tb_Title.Location = new System.Drawing.Point(40, 245);
        tb_Title.Name = "tb_Title";
        tb_Title.Size = new System.Drawing.Size(420, 23);
        tb_Title.TabIndex = 2;
        // 
        // lbl_Genre
        // 
        lbl_Genre.BackColor = System.Drawing.Color.Transparent;
        lbl_Genre.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Genre.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Genre.Location = new System.Drawing.Point(40, 280);
        lbl_Genre.Name = "lbl_Genre";
        lbl_Genre.Size = new System.Drawing.Size(420, 20);
        lbl_Genre.TabIndex = 105;
        lbl_Genre.Text = "Genre";
        lbl_Genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_Price
        // 
        lbl_Price.BackColor = System.Drawing.Color.Transparent;
        lbl_Price.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Price.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Price.Location = new System.Drawing.Point(40, 340);
        lbl_Price.Name = "lbl_Price";
        lbl_Price.Size = new System.Drawing.Size(420, 20);
        lbl_Price.TabIndex = 106;
        lbl_Price.Text = "Price";
        lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tb_Price
        // 
        tb_Price.BackColor = System.Drawing.Color.Honeydew;
        tb_Price.Location = new System.Drawing.Point(40, 365);
        tb_Price.Name = "tb_Price";
        tb_Price.Size = new System.Drawing.Size(420, 23);
        tb_Price.TabIndex = 4;
        // 
        // lbl_Quantity
        // 
        lbl_Quantity.BackColor = System.Drawing.Color.Transparent;
        lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Quantity.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Quantity.Location = new System.Drawing.Point(40, 400);
        lbl_Quantity.Name = "lbl_Quantity";
        lbl_Quantity.Size = new System.Drawing.Size(420, 20);
        lbl_Quantity.TabIndex = 107;
        lbl_Quantity.Text = "Quantity";
        lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tb_Quantity
        // 
        tb_Quantity.BackColor = System.Drawing.Color.Honeydew;
        tb_Quantity.Location = new System.Drawing.Point(40, 425);
        tb_Quantity.Name = "tb_Quantity";
        tb_Quantity.Size = new System.Drawing.Size(420, 23);
        tb_Quantity.TabIndex = 5;
        // 
        // cb_Genre
        // 
        cb_Genre.BackColor = System.Drawing.Color.Honeydew;
        cb_Genre.FormattingEnabled = true;
        cb_Genre.Location = new System.Drawing.Point(40, 303);
        cb_Genre.Name = "cb_Genre";
        cb_Genre.Size = new System.Drawing.Size(420, 23);
        cb_Genre.TabIndex = 4;
        // 
        // AdminEditProductWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Teal;
        ClientSize = new System.Drawing.Size(504, 761);
        Controls.Add(cb_Genre);
        Controls.Add(lbl_Quantity);
        Controls.Add(tb_Quantity);
        Controls.Add(lbl_Price);
        Controls.Add(tb_Price);
        Controls.Add(lbl_Genre);
        Controls.Add(lbl_Title);
        Controls.Add(tb_Title);
        Controls.Add(lbl_Artist);
        Controls.Add(lbl_SelectType);
        Controls.Add(cb_ProductType);
        Controls.Add(btn_CancelAndClose);
        Controls.Add(tb_Artist);
        Controls.Add(btn_UpdateProduct);
        Controls.Add(lbl_WelcomeMessage);
        Controls.Add(lbl_WindowInfo);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(520, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(520, 800);
        Opacity = 0.95D;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Edit Product";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox cb_Genre;

    private System.Windows.Forms.Label lbl_Genre;
    private System.Windows.Forms.Label lbl_Price;
    private System.Windows.Forms.TextBox tb_Price;
    private System.Windows.Forms.Label lbl_Quantity;
    private System.Windows.Forms.TextBox tb_Quantity;

    private System.Windows.Forms.Label lbl_SelectType;
    private System.Windows.Forms.Label lbl_Artist;
    private System.Windows.Forms.Label lbl_Title;
    private System.Windows.Forms.TextBox tb_Title;

    private System.Windows.Forms.ComboBox cb_ProductType;

    private System.Windows.Forms.Button btn_CancelAndClose;

    private System.Windows.Forms.TextBox tb_Artist;

    private System.Windows.Forms.Label lbl_WelcomeMessage;

    private System.Windows.Forms.Button btn_UpdateProduct;

    private System.Windows.Forms.Label lbl_WindowInfo;

    #endregion
}