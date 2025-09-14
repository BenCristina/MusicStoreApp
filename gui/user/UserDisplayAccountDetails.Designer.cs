namespace MusicStoreApp.gui.user;

partial class UserDisplayAccountDetails
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
        lb_AccountDetails = new System.Windows.Forms.ListBox();
        lbl_Review = new System.Windows.Forms.Label();
        btn_UpdateAccountDetails = new System.Windows.Forms.Button();
        btn_Cancel = new System.Windows.Forms.Button();
        lbl_AccountDetails = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // lb_AccountDetails
        // 
        lb_AccountDetails.BackColor = System.Drawing.Color.Honeydew;
        lb_AccountDetails.FormattingEnabled = true;
        lb_AccountDetails.Location = new System.Drawing.Point(46, 100);
        lb_AccountDetails.Name = "lb_AccountDetails";
        lb_AccountDetails.Size = new System.Drawing.Size(500, 439);
        lb_AccountDetails.TabIndex = 102;
        // 
        // lbl_Review
        // 
        lbl_Review.BackColor = System.Drawing.Color.Transparent;
        lbl_Review.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_Review.Location = new System.Drawing.Point(40, 60);
        lbl_Review.Name = "lbl_Review";
        lbl_Review.Size = new System.Drawing.Size(320, 20);
        lbl_Review.TabIndex = 101;
        lbl_Review.Text = "Review the your information";
        lbl_Review.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_UpdateAccountDetails
        // 
        btn_UpdateAccountDetails.BackColor = System.Drawing.Color.PaleGreen;
        btn_UpdateAccountDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_UpdateAccountDetails.ForeColor = System.Drawing.Color.DarkGreen;
        btn_UpdateAccountDetails.Location = new System.Drawing.Point(40, 580);
        btn_UpdateAccountDetails.Name = "btn_UpdateAccountDetails";
        btn_UpdateAccountDetails.Size = new System.Drawing.Size(240, 40);
        btn_UpdateAccountDetails.TabIndex = 0;
        btn_UpdateAccountDetails.Text = "Update account details";
        btn_UpdateAccountDetails.UseVisualStyleBackColor = false;
        btn_UpdateAccountDetails.Click += btn_UpdateAccountDetails_Click;
        // 
        // btn_Cancel
        // 
        btn_Cancel.BackColor = System.Drawing.Color.Crimson;
        btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Cancel.ForeColor = System.Drawing.Color.Honeydew;
        btn_Cancel.Location = new System.Drawing.Point(300, 580);
        btn_Cancel.Name = "btn_Cancel";
        btn_Cancel.Size = new System.Drawing.Size(240, 40);
        btn_Cancel.TabIndex = 1;
        btn_Cancel.Text = "Cancel and close";
        btn_Cancel.UseVisualStyleBackColor = false;
        btn_Cancel.Click += btn_Cancel_Click;
        // 
        // lbl_AccountDetails
        // 
        lbl_AccountDetails.BackColor = System.Drawing.Color.Transparent;
        lbl_AccountDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_AccountDetails.ForeColor = System.Drawing.Color.Honeydew;
        lbl_AccountDetails.Location = new System.Drawing.Point(40, 40);
        lbl_AccountDetails.Name = "lbl_AccountDetails";
        lbl_AccountDetails.Size = new System.Drawing.Size(320, 20);
        lbl_AccountDetails.TabIndex = 100;
        lbl_AccountDetails.Text = "Your account details";
        lbl_AccountDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // DisplayAccountDetails
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.SeaGreen;
        ClientSize = new System.Drawing.Size(584, 661);
        Controls.Add(lbl_AccountDetails);
        Controls.Add(btn_Cancel);
        Controls.Add(btn_UpdateAccountDetails);
        Controls.Add(lbl_Review);
        Controls.Add(lb_AccountDetails);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(600, 700);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(600, 700);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Account details";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label lbl_AccountDetails;

    private System.Windows.Forms.Button btn_Cancel;

    private System.Windows.Forms.Button btn_UpdateAccountDetails;

    private System.Windows.Forms.Label lbl_Review;

    private System.Windows.Forms.ListBox lb_AccountDetails;

    #endregion
}