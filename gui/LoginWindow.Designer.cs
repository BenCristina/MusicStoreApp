namespace MusicStoreApp.gui;

partial class LoginWindow
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
        lbl_NoAccount = new System.Windows.Forms.Label();
        btn_Login = new System.Windows.Forms.Button();
        tb_Password = new System.Windows.Forms.TextBox();
        lbl_Username = new System.Windows.Forms.Label();
        tb_Username = new System.Windows.Forms.TextBox();
        lbl_Password = new System.Windows.Forms.Label();
        lbl_RegisterHere = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // lbl_NoAccount
        // 
        lbl_NoAccount.BackColor = System.Drawing.Color.Transparent;
        lbl_NoAccount.ForeColor = System.Drawing.Color.PaleGreen;
        lbl_NoAccount.Location = new System.Drawing.Point(440, 445);
        lbl_NoAccount.Name = "lbl_NoAccount";
        lbl_NoAccount.Size = new System.Drawing.Size(96, 20);
        lbl_NoAccount.TabIndex = 102;
        lbl_NoAccount.Text = "No account yet?";
        // 
        // btn_Login
        // 
        btn_Login.BackColor = System.Drawing.Color.PaleGreen;
        btn_Login.Font = new System.Drawing.Font("Segoe UI", 11F);
        btn_Login.ForeColor = System.Drawing.Color.DarkGreen;
        btn_Login.Location = new System.Drawing.Point(440, 400);
        btn_Login.Name = "btn_Login";
        btn_Login.Size = new System.Drawing.Size(320, 40);
        btn_Login.TabIndex = 2;
        btn_Login.Text = "Login";
        btn_Login.UseVisualStyleBackColor = false;
        btn_Login.Click += btn_Login_Click;
        // 
        // tb_Password
        // 
        tb_Password.BackColor = System.Drawing.Color.Honeydew;
        tb_Password.Location = new System.Drawing.Point(440, 355);
        tb_Password.Name = "tb_Password";
        tb_Password.PasswordChar = '*';
        tb_Password.Size = new System.Drawing.Size(320, 23);
        tb_Password.TabIndex = 1;
        // 
        // lbl_Username
        // 
        lbl_Username.BackColor = System.Drawing.Color.Transparent;
        lbl_Username.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Username.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Username.Location = new System.Drawing.Point(440, 270);
        lbl_Username.Name = "lbl_Username";
        lbl_Username.Size = new System.Drawing.Size(320, 20);
        lbl_Username.TabIndex = 100;
        lbl_Username.Text = "Username";
        lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tb_Username
        // 
        tb_Username.BackColor = System.Drawing.Color.Honeydew;
        tb_Username.Location = new System.Drawing.Point(440, 295);
        tb_Username.Name = "tb_Username";
        tb_Username.Size = new System.Drawing.Size(320, 23);
        tb_Username.TabIndex = 0;
        // 
        // lbl_Password
        // 
        lbl_Password.BackColor = System.Drawing.Color.Transparent;
        lbl_Password.Font = new System.Drawing.Font("Segoe UI", 11F);
        lbl_Password.ForeColor = System.Drawing.Color.Honeydew;
        lbl_Password.Location = new System.Drawing.Point(440, 330);
        lbl_Password.Name = "lbl_Password";
        lbl_Password.Size = new System.Drawing.Size(320, 20);
        lbl_Password.TabIndex = 101;
        lbl_Password.Text = "Password";
        lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lbl_RegisterHere
        // 
        lbl_RegisterHere.BackColor = System.Drawing.Color.Transparent;
        lbl_RegisterHere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lbl_RegisterHere.ForeColor = System.Drawing.Color.Honeydew;
        lbl_RegisterHere.Location = new System.Drawing.Point(440, 465);
        lbl_RegisterHere.Name = "lbl_RegisterHere";
        lbl_RegisterHere.Size = new System.Drawing.Size(96, 20);
        lbl_RegisterHere.TabIndex = 3;
        lbl_RegisterHere.Text = "Register here";
        lbl_RegisterHere.Click += lbl_RegisterHere_Click;
        // 
        // LoginWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.SeaGreen;
        ClientSize = new System.Drawing.Size(1184, 761);
        Controls.Add(lbl_RegisterHere);
        Controls.Add(lbl_Password);
        Controls.Add(tb_Username);
        Controls.Add(lbl_Username);
        Controls.Add(tb_Password);
        Controls.Add(btn_Login);
        Controls.Add(lbl_NoAccount);
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(1200, 800);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(1200, 800);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lbl_Password;
    private System.Windows.Forms.Label lbl_RegisterHere;

    private System.Windows.Forms.TextBox tb_Username;

    private System.Windows.Forms.Label lbl_Username;

    private System.Windows.Forms.TextBox tb_Password;

    private System.Windows.Forms.Button btn_Login;

    private System.Windows.Forms.Label lbl_NoAccount;

    #endregion
}