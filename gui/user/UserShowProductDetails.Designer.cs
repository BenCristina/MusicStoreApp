namespace MusicStoreApp;

partial class UserShowProductDetails
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
        lbl_Title = new System.Windows.Forms.Label();
        btn_Close = new System.Windows.Forms.Button();
        lbl_ArtistName = new System.Windows.Forms.Label();
        pb_CoverArtwork = new System.Windows.Forms.PictureBox();
        lbl_ReleaseYear = new System.Windows.Forms.Label();
        lbl_Genre = new System.Windows.Forms.Label();
        lbl_ProductType = new System.Windows.Forms.Label();
        lbl_Price = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pb_CoverArtwork).BeginInit();
        SuspendLayout();
        // 
        // lbl_Title
        // 
        lbl_Title.BackColor = System.Drawing.Color.Transparent;
        lbl_Title.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Title.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_Title.Location = new System.Drawing.Point(40, 60);
        lbl_Title.Name = "lbl_Title";
        lbl_Title.Size = new System.Drawing.Size(320, 20);
        lbl_Title.TabIndex = 101;
        lbl_Title.Text = "TODO: Title";
        lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_Close
        // 
        btn_Close.BackColor = System.Drawing.Color.Crimson;
        btn_Close.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Close.ForeColor = System.Drawing.Color.Honeydew;
        btn_Close.Location = new System.Drawing.Point(40, 680);
        btn_Close.Name = "btn_Close";
        btn_Close.Size = new System.Drawing.Size(320, 40);
        btn_Close.TabIndex = 1;
        btn_Close.Text = "Close";
        btn_Close.UseVisualStyleBackColor = false;
        btn_Close.Click += btn_Close_Click;
        // 
        // lbl_ArtistName
        // 
        lbl_ArtistName.BackColor = System.Drawing.Color.Transparent;
        lbl_ArtistName.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_ArtistName.ForeColor = System.Drawing.Color.Honeydew;
        lbl_ArtistName.Location = new System.Drawing.Point(40, 40);
        lbl_ArtistName.Name = "lbl_ArtistName";
        lbl_ArtistName.Size = new System.Drawing.Size(320, 20);
        lbl_ArtistName.TabIndex = 100;
        lbl_ArtistName.Text = "TODO: Artist name";
        lbl_ArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // pb_CoverArtwork
        // 
        pb_CoverArtwork.Location = new System.Drawing.Point(40, 100);
        pb_CoverArtwork.Name = "pb_CoverArtwork";
        pb_CoverArtwork.Size = new System.Drawing.Size(320, 320);
        pb_CoverArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pb_CoverArtwork.TabIndex = 17;
        pb_CoverArtwork.TabStop = false;
        // 
        // lbl_ReleaseYear
        // 
        lbl_ReleaseYear.BackColor = System.Drawing.Color.Transparent;
        lbl_ReleaseYear.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_ReleaseYear.ForeColor = System.Drawing.Color.Honeydew;
        lbl_ReleaseYear.Location = new System.Drawing.Point(40, 440);
        lbl_ReleaseYear.Name = "lbl_ReleaseYear";
        lbl_ReleaseYear.Size = new System.Drawing.Size(320, 20);
        lbl_ReleaseYear.TabIndex = 102;
        lbl_ReleaseYear.Text = "TODO: Release Year";
        lbl_ReleaseYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_Genre
        // 
        lbl_Genre.BackColor = System.Drawing.Color.Transparent;
        lbl_Genre.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Genre.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Genre.Location = new System.Drawing.Point(40, 470);
        lbl_Genre.Name = "lbl_Genre";
        lbl_Genre.Size = new System.Drawing.Size(320, 20);
        lbl_Genre.TabIndex = 103;
        lbl_Genre.Text = "TODO: Genre";
        lbl_Genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_ProductType
        // 
        lbl_ProductType.BackColor = System.Drawing.Color.Transparent;
        lbl_ProductType.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_ProductType.ForeColor = System.Drawing.Color.Honeydew;
        lbl_ProductType.Location = new System.Drawing.Point(40, 500);
        lbl_ProductType.Name = "lbl_ProductType";
        lbl_ProductType.Size = new System.Drawing.Size(320, 20);
        lbl_ProductType.TabIndex = 104;
        lbl_ProductType.Text = "TODO: Type";
        lbl_ProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_Price
        // 
        lbl_Price.BackColor = System.Drawing.Color.Transparent;
        lbl_Price.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Price.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Price.Location = new System.Drawing.Point(40, 530);
        lbl_Price.Name = "lbl_Price";
        lbl_Price.Size = new System.Drawing.Size(320, 20);
        lbl_Price.TabIndex = 105;
        lbl_Price.Text = "TODO: Price";
        lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // ShowProductDetails
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.SeaGreen;
        ClientSize = new System.Drawing.Size(404, 761);
        Controls.Add(lbl_Price);
        Controls.Add(lbl_ProductType);
        Controls.Add(lbl_Genre);
        Controls.Add(lbl_ReleaseYear);
        Controls.Add(pb_CoverArtwork);
        Controls.Add(lbl_ArtistName);
        Controls.Add(btn_Close);
        Controls.Add(lbl_Title);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(420, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(420, 800);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Product Details";
        ((System.ComponentModel.ISupportInitialize)pb_CoverArtwork).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label lbl_Genre;
    private System.Windows.Forms.Label lbl_ProductType;
    private System.Windows.Forms.Label lbl_Price;
    private System.Windows.Forms.PictureBox pb_CoverArtwork;
    private System.Windows.Forms.Label lbl_ArtistName;
    private System.Windows.Forms.Button btn_Close;
    private System.Windows.Forms.Label lbl_ReleaseYear;
    private System.Windows.Forms.Label lbl_Title;

    #endregion
}