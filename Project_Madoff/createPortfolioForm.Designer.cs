namespace Project_Madoff
{
    partial class createPortfolioForm
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
            this.portNameTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createPortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portNameTBox
            // 
            this.portNameTBox.Location = new System.Drawing.Point(223, 97);
            this.portNameTBox.Name = "portNameTBox";
            this.portNameTBox.Size = new System.Drawing.Size(115, 20);
            this.portNameTBox.TabIndex = 0;
            this.portNameTBox.TextChanged += new System.EventHandler(this.portNameTBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type in the name of \r\nyour new portfolio";
            // 
            // createPortBtn
            // 
            this.createPortBtn.Location = new System.Drawing.Point(243, 176);
            this.createPortBtn.Name = "createPortBtn";
            this.createPortBtn.Size = new System.Drawing.Size(75, 23);
            this.createPortBtn.TabIndex = 2;
            this.createPortBtn.Text = "Create";
            this.createPortBtn.UseVisualStyleBackColor = true;
            this.createPortBtn.Click += new System.EventHandler(this.createPortBtn_Click);
            // 
            // createProtfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 267);
            this.Controls.Add(this.createPortBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portNameTBox);
            this.Name = "createProtfolioForm";
            this.Text = "createProtfolioForm";
            this.Load += new System.EventHandler(this.createProtfolioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox portNameTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createPortBtn;
    }
}