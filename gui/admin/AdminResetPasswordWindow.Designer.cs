namespace MusicStoreApp.gui.admin;

partial class AdminResetPasswordWindow
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
        btn_ResetPassword = new System.Windows.Forms.Button();
        lbl_FullName = new System.Windows.Forms.Label();
        lbl_EnterNewPassword = new System.Windows.Forms.Label();
        tb_Password = new System.Windows.Forms.TextBox();
        lbl_RepeatPassword = new System.Windows.Forms.Label();
        btn_Cancel = new System.Windows.Forms.Button();
        lbl_WelcomeMessage = new System.Windows.Forms.Label();
        lbl_WindowInfo = new System.Windows.Forms.Label();
        tb_RepeatPassword = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // btn_ResetPassword
        // 
        btn_ResetPassword.BackColor = System.Drawing.Color.MediumTurquoise;
        btn_ResetPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_ResetPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
        btn_ResetPassword.Location = new System.Drawing.Point(40, 600);
        btn_ResetPassword.Name = "btn_ResetPassword";
        btn_ResetPassword.Size = new System.Drawing.Size(160, 40);
        btn_ResetPassword.TabIndex = 10;
        btn_ResetPassword.Text = "ResetPassword";
        btn_ResetPassword.UseVisualStyleBackColor = false;
        btn_ResetPassword.Click += btn_ResetPassword_Click;
        // 
        // lbl_FullName
        // 
        lbl_FullName.BackColor = System.Drawing.Color.Transparent;
        lbl_FullName.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_FullName.ForeColor = System.Drawing.Color.Honeydew;
        lbl_FullName.Location = new System.Drawing.Point(40, 230);
        lbl_FullName.Name = "lbl_FullName";
        lbl_FullName.Size = new System.Drawing.Size(140, 20);
        lbl_FullName.TabIndex = 102;
        lbl_FullName.Text = "// TODO: Username";
        // 
        // lbl_EnterNewPassword
        // 
        lbl_EnterNewPassword.BackColor = System.Drawing.Color.Transparent;
        lbl_EnterNewPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_EnterNewPassword.ForeColor = System.Drawing.Color.Honeydew;
        lbl_EnterNewPassword.Location = new System.Drawing.Point(40, 260);
        lbl_EnterNewPassword.Name = "lbl_EnterNewPassword";
        lbl_EnterNewPassword.Size = new System.Drawing.Size(320, 20);
        lbl_EnterNewPassword.TabIndex = 104;
        lbl_EnterNewPassword.Text = "New password:";
        // 
        // tb_Password
        // 
        tb_Password.BackColor = System.Drawing.Color.Honeydew;
        tb_Password.Location = new System.Drawing.Point(40, 285);
        tb_Password.Name = "tb_Password";
        tb_Password.Size = new System.Drawing.Size(320, 23);
        tb_Password.TabIndex = 2;
        // 
        // lbl_RepeatPassword
        // 
        lbl_RepeatPassword.BackColor = System.Drawing.Color.Transparent;
        lbl_RepeatPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_RepeatPassword.ForeColor = System.Drawing.Color.Honeydew;
        lbl_RepeatPassword.Location = new System.Drawing.Point(40, 320);
        lbl_RepeatPassword.Name = "lbl_RepeatPassword";
        lbl_RepeatPassword.Size = new System.Drawing.Size(320, 20);
        lbl_RepeatPassword.TabIndex = 105;
        lbl_RepeatPassword.Text = "Confirm password";
        // 
        // btn_Cancel
        // 
        btn_Cancel.BackColor = System.Drawing.Color.Crimson;
        btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Cancel.ForeColor = System.Drawing.Color.Honeydew;
        btn_Cancel.Location = new System.Drawing.Point(259, 600);
        btn_Cancel.Name = "btn_Cancel";
        btn_Cancel.Size = new System.Drawing.Size(100, 40);
        btn_Cancel.TabIndex = 11;
        btn_Cancel.Text = "Cancel";
        btn_Cancel.UseVisualStyleBackColor = false;
        btn_Cancel.Click += btn_Cancel_Click;
        // 
        // lbl_WelcomeMessage
        // 
        lbl_WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
        lbl_WelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_WelcomeMessage.ForeColor = System.Drawing.Color.Honeydew;
        lbl_WelcomeMessage.Location = new System.Drawing.Point(40, 40);
        lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
        lbl_WelcomeMessage.Size = new System.Drawing.Size(320, 20);
        lbl_WelcomeMessage.TabIndex = 100;
        lbl_WelcomeMessage.Text = "Reset a user\'s password here";
        // 
        // lbl_WindowInfo
        // 
        lbl_WindowInfo.BackColor = System.Drawing.Color.Transparent;
        lbl_WindowInfo.ForeColor = System.Drawing.Color.Aquamarine;
        lbl_WindowInfo.Location = new System.Drawing.Point(40, 60);
        lbl_WindowInfo.Name = "lbl_WindowInfo";
        lbl_WindowInfo.Size = new System.Drawing.Size(346, 20);
        lbl_WindowInfo.TabIndex = 101;
        lbl_WindowInfo.Text = "Before you start, first confirm with the user";
        // 
        // tb_RepeatPassword
        // 
        tb_RepeatPassword.BackColor = System.Drawing.Color.Honeydew;
        tb_RepeatPassword.Location = new System.Drawing.Point(40, 345);
        tb_RepeatPassword.Name = "tb_RepeatPassword";
        tb_RepeatPassword.Size = new System.Drawing.Size(320, 23);
        tb_RepeatPassword.TabIndex = 3;
        // 
        // AdminResetPasswordWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Teal;
        ClientSize = new System.Drawing.Size(404, 761);
        Controls.Add(lbl_WindowInfo);
        Controls.Add(lbl_WelcomeMessage);
        Controls.Add(btn_Cancel);
        Controls.Add(lbl_RepeatPassword);
        Controls.Add(tb_RepeatPassword);
        Controls.Add(lbl_EnterNewPassword);
        Controls.Add(tb_Password);
        Controls.Add(lbl_FullName);
        Controls.Add(btn_ResetPassword);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(420, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(420, 800);
        Opacity = 0.95D;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Update Users Account";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lbl_WelcomeMessage;
    private System.Windows.Forms.Label lbl_WindowInfo;

    private System.Windows.Forms.Button btn_Cancel;

    private System.Windows.Forms.Label lbl_RepeatPassword;
    private System.Windows.Forms.TextBox tb_RepeatPassword;

    private System.Windows.Forms.TextBox tb_Password;
    private System.Windows.Forms.Label lbl_EnterNewPassword;

    private System.Windows.Forms.Label lbl_FullName;

    private System.Windows.Forms.Button btn_ResetPassword;

    #endregion
}