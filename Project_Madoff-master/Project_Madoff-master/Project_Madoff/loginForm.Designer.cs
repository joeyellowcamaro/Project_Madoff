namespace Project_Madoff
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.csvLocTBox = new System.Windows.Forms.TextBox();
            this.fileBrowseBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.createProBtn = new System.Windows.Forms.Button();
            this.userNameLab = new System.Windows.Forms.Label();
            this.csvFileLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTBox
            // 
            this.nameTBox.Location = new System.Drawing.Point(452, 108);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(100, 20);
            this.nameTBox.TabIndex = 0;
            this.nameTBox.TextChanged += new System.EventHandler(this.nameTBox_TextChanged);
            // 
            // csvLocTBox
            // 
            this.csvLocTBox.Location = new System.Drawing.Point(452, 175);
            this.csvLocTBox.Name = "csvLocTBox";
            this.csvLocTBox.Size = new System.Drawing.Size(100, 20);
            this.csvLocTBox.TabIndex = 1;
            this.csvLocTBox.TextChanged += new System.EventHandler(this.csvLocTBox_TextChanged);
            // 
            // fileBrowseBtn
            // 
            this.fileBrowseBtn.Location = new System.Drawing.Point(578, 172);
            this.fileBrowseBtn.Name = "fileBrowseBtn";
            this.fileBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.fileBrowseBtn.TabIndex = 2;
            this.fileBrowseBtn.Text = "Browse";
            this.fileBrowseBtn.UseVisualStyleBackColor = true;
            this.fileBrowseBtn.Click += new System.EventHandler(this.fileBrowseBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(280, 255);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(182, 31);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // createProBtn
            // 
            this.createProBtn.Location = new System.Drawing.Point(106, 259);
            this.createProBtn.Name = "createProBtn";
            this.createProBtn.Size = new System.Drawing.Size(98, 23);
            this.createProBtn.TabIndex = 4;
            this.createProBtn.Text = "Create Profile";
            this.createProBtn.UseVisualStyleBackColor = true;
            this.createProBtn.Click += new System.EventHandler(this.createProBtn_Click);
            // 
            // userNameLab
            // 
            this.userNameLab.AutoSize = true;
            this.userNameLab.Location = new System.Drawing.Point(386, 111);
            this.userNameLab.Name = "userNameLab";
            this.userNameLab.Size = new System.Drawing.Size(60, 13);
            this.userNameLab.TabIndex = 5;
            this.userNameLab.Text = "User Name";
            // 
            // csvFileLab
            // 
            this.csvFileLab.AutoSize = true;
            this.csvFileLab.Location = new System.Drawing.Point(399, 178);
            this.csvFileLab.Name = "csvFileLab";
            this.csvFileLab.Size = new System.Drawing.Size(47, 13);
            this.csvFileLab.TabIndex = 6;
            this.csvFileLab.Text = "CSV File";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 343);
            this.Controls.Add(this.csvFileLab);
            this.Controls.Add(this.userNameLab);
            this.Controls.Add(this.createProBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.fileBrowseBtn);
            this.Controls.Add(this.csvLocTBox);
            this.Controls.Add(this.nameTBox);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Madoff";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.TextBox csvLocTBox;
        private System.Windows.Forms.Button fileBrowseBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button createProBtn;
        private System.Windows.Forms.Label userNameLab;
        private System.Windows.Forms.Label csvFileLab;
    }
}

