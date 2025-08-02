namespace SystemCourseA_MakeupExam_01
{
    partial class frmLogin
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserID = new TextBox();
            lblUserID = new Label();
            txtPassWord = new TextBox();
            lblPassWord = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(68, 62);
            txtUserID.MaxLength = 100;
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(250, 23);
            txtUserID.TabIndex = 1;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(68, 44);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(46, 15);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "ユーザID";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(67, 141);
            txtPassWord.MaxLength = 100;
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(250, 23);
            txtPassWord.TabIndex = 3;
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(67, 123);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(51, 15);
            lblPassWord.TabIndex = 2;
            lblPassWord.Text = "パスワード";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(67, 212);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(251, 57);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ログイン";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(384, 311);
            Controls.Add(btnLogin);
            Controls.Add(lblPassWord);
            Controls.Add(txtPassWord);
            Controls.Add(lblUserID);
            Controls.Add(txtUserID);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmLogin";
            Text = "ログイン画面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserID;
        private Label lblUserID;
        private TextBox txtPassWord;
        private Label lblPassWord;
        private Button btnLogin;
    }
}
