namespace Project_Madoff
{
    partial class createProfileForm
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
            this.createProTBox = new System.Windows.Forms.TextBox();
            this.createProBtn = new System.Windows.Forms.Button();
            this.userNameLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createProTBox
            // 
            this.createProTBox.Location = new System.Drawing.Point(239, 120);
            this.createProTBox.Name = "createProTBox";
            this.createProTBox.Size = new System.Drawing.Size(100, 20);
            this.createProTBox.TabIndex = 0;
            this.createProTBox.TextChanged += new System.EventHandler(this.createProTBox_TextChanged);
            // 
            // createProBtn
            // 
            this.createProBtn.Location = new System.Drawing.Point(248, 204);
            this.createProBtn.Name = "createProBtn";
            this.createProBtn.Size = new System.Drawing.Size(75, 23);
            this.createProBtn.TabIndex = 1;
            this.createProBtn.Text = "Create";
            this.createProBtn.UseVisualStyleBackColor = true;
            this.createProBtn.Click += new System.EventHandler(this.createProBtn_Click);
            // 
            // userNameLab
            // 
            this.userNameLab.AutoSize = true;
            this.userNameLab.Location = new System.Drawing.Point(173, 123);
            this.userNameLab.Name = "userNameLab";
            this.userNameLab.Size = new System.Drawing.Size(60, 13);
            this.userNameLab.TabIndex = 2;
            this.userNameLab.Text = "User Name";
            // 
            // createProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 268);
            this.Controls.Add(this.userNameLab);
            this.Controls.Add(this.createProBtn);
            this.Controls.Add(this.createProTBox);
            this.Name = "createProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Madoff";
            this.Load += new System.EventHandler(this.createProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox createProTBox;
        private System.Windows.Forms.Button createProBtn;
        private System.Windows.Forms.Label userNameLab;
    }
}