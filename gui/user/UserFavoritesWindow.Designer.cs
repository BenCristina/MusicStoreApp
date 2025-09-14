namespace MusicStoreApp.gui.user;

partial class UserFavoritesWindow
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
        lb_FavoritesList = new System.Windows.Forms.ListBox();
        btn_RemoveItem = new System.Windows.Forms.Button();
        lbl_WhatYouLike = new System.Windows.Forms.Label();
        btn_Cancel = new System.Windows.Forms.Button();
        lbl_Favorites = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // lb_FavoritesList
        // 
        lb_FavoritesList.BackColor = System.Drawing.Color.Honeydew;
        lb_FavoritesList.FormattingEnabled = true;
        lb_FavoritesList.Location = new System.Drawing.Point(40, 100);
        lb_FavoritesList.Name = "lb_FavoritesList";
        lb_FavoritesList.Size = new System.Drawing.Size(320, 544);
        lb_FavoritesList.TabIndex = 102;
        // 
        // btn_RemoveItem
        // 
        btn_RemoveItem.BackColor = System.Drawing.Color.PaleGreen;
        btn_RemoveItem.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_RemoveItem.ForeColor = System.Drawing.Color.DarkGreen;
        btn_RemoveItem.Location = new System.Drawing.Point(40, 680);
        btn_RemoveItem.Name = "btn_RemoveItem";
        btn_RemoveItem.Size = new System.Drawing.Size(120, 40);
        btn_RemoveItem.TabIndex = 0;
        btn_RemoveItem.Text = "Remove item";
        btn_RemoveItem.UseVisualStyleBackColor = false;
        btn_RemoveItem.Click += btn_RemoveItem_Click;
        // 
        // lbl_WhatYouLike
        // 
        lbl_WhatYouLike.BackColor = System.Drawing.Color.Transparent;
        lbl_WhatYouLike.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_WhatYouLike.Location = new System.Drawing.Point(40, 60);
        lbl_WhatYouLike.Name = "lbl_WhatYouLike";
        lbl_WhatYouLike.Size = new System.Drawing.Size(320, 20);
        lbl_WhatYouLike.TabIndex = 101;
        lbl_WhatYouLike.Text = "This is what you like";
        lbl_WhatYouLike.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_Cancel
        // 
        btn_Cancel.BackColor = System.Drawing.Color.Crimson;
        btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Cancel.ForeColor = System.Drawing.Color.Honeydew;
        btn_Cancel.Location = new System.Drawing.Point(240, 680);
        btn_Cancel.Name = "btn_Cancel";
        btn_Cancel.Size = new System.Drawing.Size(120, 40);
        btn_Cancel.TabIndex = 2;
        btn_Cancel.Text = "Cancel";
        btn_Cancel.UseVisualStyleBackColor = false;
        btn_Cancel.Click += btn_Cancel_Click;
        // 
        // lbl_Favorites
        // 
        lbl_Favorites.BackColor = System.Drawing.Color.Transparent;
        lbl_Favorites.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Favorites.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Favorites.Location = new System.Drawing.Point(40, 40);
        lbl_Favorites.Name = "lbl_Favorites";
        lbl_Favorites.Size = new System.Drawing.Size(320, 20);
        lbl_Favorites.TabIndex = 100;
        lbl_Favorites.Text = "Your favorite items";
        lbl_Favorites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // FavoritesWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.SeaGreen;
        ClientSize = new System.Drawing.Size(404, 761);
        Controls.Add(lbl_Favorites);
        Controls.Add(btn_Cancel);
        Controls.Add(lbl_WhatYouLike);
        Controls.Add(btn_RemoveItem);
        Controls.Add(lb_FavoritesList);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(420, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(420, 800);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Favorites";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label lbl_Favorites;

    private System.Windows.Forms.Button btn_Cancel;

    private System.Windows.Forms.Label lbl_WhatYouLike;

    private System.Windows.Forms.Button btn_RemoveItem;

    private System.Windows.Forms.ListBox lb_FavoritesList;

    #endregion
}