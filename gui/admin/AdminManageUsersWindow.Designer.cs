namespace MusicStoreApp.gui.admin;

partial class AdminManageUsersWindow
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
        lb_UserList = new System.Windows.Forms.ListBox();
        lbl_WindowInfo = new System.Windows.Forms.Label();
        btn_EditUser = new System.Windows.Forms.Button();
        lbl_WelcomeMessage = new System.Windows.Forms.Label();
        btn_OpenOrders = new System.Windows.Forms.Button();
        tb_SearchUser = new System.Windows.Forms.TextBox();
        btn_EmailUser = new System.Windows.Forms.Button();
        btn_ReturnToAdminPanel = new System.Windows.Forms.Button();
        btn_ResetPassword = new System.Windows.Forms.Button();
        lb_OrderList = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // lb_UserList
        // 
        lb_UserList.BackColor = System.Drawing.Color.Honeydew;
        lb_UserList.FormattingEnabled = true;
        lb_UserList.Location = new System.Drawing.Point(40, 180);
        lb_UserList.Name = "lb_UserList";
        lb_UserList.Size = new System.Drawing.Size(640, 469);
        lb_UserList.TabIndex = 102;
        // 
        // lbl_WindowInfo
        // 
        lbl_WindowInfo.BackColor = System.Drawing.Color.Transparent;
        lbl_WindowInfo.ForeColor = System.Drawing.Color.Aquamarine;
        lbl_WindowInfo.Location = new System.Drawing.Point(40, 60);
        lbl_WindowInfo.Name = "lbl_WindowInfo";
        lbl_WindowInfo.Size = new System.Drawing.Size(372, 20);
        lbl_WindowInfo.TabIndex = 101;
        lbl_WindowInfo.Text = "You can manage your users here.";
        lbl_WindowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_EditUser
        // 
        btn_EditUser.BackColor = System.Drawing.Color.PaleTurquoise;
        btn_EditUser.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_EditUser.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_EditUser.Location = new System.Drawing.Point(40, 680);
        btn_EditUser.Name = "btn_EditUser";
        btn_EditUser.Size = new System.Drawing.Size(200, 40);
        btn_EditUser.TabIndex = 2;
        btn_EditUser.Text = "Edit user";
        btn_EditUser.UseVisualStyleBackColor = false;
        btn_EditUser.Click += btn_EditUser_Click;
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
        lbl_WelcomeMessage.Text = "Welcome to the MusicStore user management system";
        lbl_WelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btn_OpenOrders
        // 
        btn_OpenOrders.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_OpenOrders.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_OpenOrders.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_OpenOrders.Location = new System.Drawing.Point(40, 130);
        btn_OpenOrders.Name = "btn_OpenOrders";
        btn_OpenOrders.Size = new System.Drawing.Size(357, 40);
        btn_OpenOrders.TabIndex = 1;
        btn_OpenOrders.Text = "Show users with open orders";
        btn_OpenOrders.UseVisualStyleBackColor = false;
        btn_OpenOrders.Click += btn_OpenOrders_Click;
        // 
        // tb_SearchUser
        // 
        tb_SearchUser.BackColor = System.Drawing.Color.Honeydew;
        tb_SearchUser.Location = new System.Drawing.Point(40, 90);
        tb_SearchUser.Name = "tb_SearchUser";
        tb_SearchUser.Size = new System.Drawing.Size(357, 23);
        tb_SearchUser.TabIndex = 0;
        tb_SearchUser.Text = "Search";
        // 
        // btn_EmailUser
        // 
        btn_EmailUser.BackColor = System.Drawing.Color.PaleTurquoise;
        btn_EmailUser.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_EmailUser.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_EmailUser.Location = new System.Drawing.Point(480, 680);
        btn_EmailUser.Name = "btn_EmailUser";
        btn_EmailUser.Size = new System.Drawing.Size(200, 40);
        btn_EmailUser.TabIndex = 4;
        btn_EmailUser.Text = "Email user";
        btn_EmailUser.UseVisualStyleBackColor = false;
        btn_EmailUser.Click += btn_EmailUser_Click;
        // 
        // btn_ReturnToAdminPanel
        // 
        btn_ReturnToAdminPanel.BackColor = System.Drawing.Color.Crimson;
        btn_ReturnToAdminPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_ReturnToAdminPanel.ForeColor = System.Drawing.Color.Honeydew;
        btn_ReturnToAdminPanel.Location = new System.Drawing.Point(820, 680);
        btn_ReturnToAdminPanel.Name = "btn_ReturnToAdminPanel";
        btn_ReturnToAdminPanel.Size = new System.Drawing.Size(320, 40);
        btn_ReturnToAdminPanel.TabIndex = 5;
        btn_ReturnToAdminPanel.Text = "Return to Admin Panel";
        btn_ReturnToAdminPanel.UseVisualStyleBackColor = false;
        btn_ReturnToAdminPanel.Click += btn_ReturnToMainWindow_Click;
        // 
        // btn_ResetPassword
        // 
        btn_ResetPassword.BackColor = System.Drawing.Color.PaleTurquoise;
        btn_ResetPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ResetPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_ResetPassword.Location = new System.Drawing.Point(260, 680);
        btn_ResetPassword.Name = "btn_ResetPassword";
        btn_ResetPassword.Size = new System.Drawing.Size(200, 40);
        btn_ResetPassword.TabIndex = 3;
        btn_ResetPassword.Text = "Reset user password";
        btn_ResetPassword.UseVisualStyleBackColor = false;
        btn_ResetPassword.Click += btn_ResetPassword_Click;
        // 
        // lb_OrderList
        // 
        lb_OrderList.BackColor = System.Drawing.Color.Honeydew;
        lb_OrderList.FormattingEnabled = true;
        lb_OrderList.Location = new System.Drawing.Point(720, 180);
        lb_OrderList.Name = "lb_OrderList";
        lb_OrderList.Size = new System.Drawing.Size(420, 469);
        lb_OrderList.TabIndex = 103;
        // 
        // AdminManageUsersWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Teal;
        ClientSize = new System.Drawing.Size(1184, 761);
        Controls.Add(lb_OrderList);
        Controls.Add(btn_ResetPassword);
        Controls.Add(btn_ReturnToAdminPanel);
        Controls.Add(btn_EmailUser);
        Controls.Add(tb_SearchUser);
        Controls.Add(btn_OpenOrders);
        Controls.Add(lbl_WelcomeMessage);
        Controls.Add(btn_EditUser);
        Controls.Add(lbl_WindowInfo);
        Controls.Add(lb_UserList);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(1200, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(1200, 800);
        Opacity = 0.95D;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Manage Users";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ListBox lb_OrderList;

    private System.Windows.Forms.Button btn_ResetPassword;

    private System.Windows.Forms.Button btn_ReturnToAdminPanel;

    private System.Windows.Forms.TextBox tb_SearchUser;

    private System.Windows.Forms.Label lbl_WelcomeMessage;

    private System.Windows.Forms.Button btn_OpenOrders;

    private System.Windows.Forms.Button btn_EditUser;

    private System.Windows.Forms.Label lbl_WindowInfo;

    private System.Windows.Forms.Button btn_EmailUser;

    private System.Windows.Forms.ListBox lb_UserList;

    #endregion
}