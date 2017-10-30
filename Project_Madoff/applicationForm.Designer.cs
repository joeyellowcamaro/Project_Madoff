namespace Project_Madoff
{
    partial class applicationForm
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
            this.tickerTBox = new System.Windows.Forms.TextBox();
            this.sharesBox = new System.Windows.Forms.TextBox();
            this.tickerLabel = new System.Windows.Forms.Label();
            this.sharesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tickerTBox
            // 
            this.tickerTBox.Location = new System.Drawing.Point(474, 151);
            this.tickerTBox.Name = "tickerTBox";
            this.tickerTBox.Size = new System.Drawing.Size(100, 20);
            this.tickerTBox.TabIndex = 0;
            this.tickerTBox.TextChanged += new System.EventHandler(this.tickerTBox_TextChanged);
            // 
            // sharesBox
            // 
            this.sharesBox.Location = new System.Drawing.Point(474, 191);
            this.sharesBox.Name = "sharesBox";
            this.sharesBox.Size = new System.Drawing.Size(100, 20);
            this.sharesBox.TabIndex = 1;
            this.sharesBox.TextChanged += new System.EventHandler(this.sharesBox_TextChanged);
            // 
            // tickerLabel
            // 
            this.tickerLabel.AutoSize = true;
            this.tickerLabel.Location = new System.Drawing.Point(433, 154);
            this.tickerLabel.Name = "tickerLabel";
            this.tickerLabel.Size = new System.Drawing.Size(37, 13);
            this.tickerLabel.TabIndex = 2;
            this.tickerLabel.Text = "Ticker";
            // 
            // sharesLabel
            // 
            this.sharesLabel.AutoSize = true;
            this.sharesLabel.Location = new System.Drawing.Point(406, 194);
            this.sharesLabel.Name = "sharesLabel";
            this.sharesLabel.Size = new System.Drawing.Size(62, 13);
            this.sharesLabel.TabIndex = 3;
            this.sharesLabel.Text = "# of Shares";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // applicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sharesLabel);
            this.Controls.Add(this.tickerLabel);
            this.Controls.Add(this.sharesBox);
            this.Controls.Add(this.tickerTBox);
            this.Name = "applicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Madoff";
            this.Load += new System.EventHandler(this.applicationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tickerTBox;
        private System.Windows.Forms.TextBox sharesBox;
        private System.Windows.Forms.Label tickerLabel;
        private System.Windows.Forms.Label sharesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}