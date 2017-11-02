using System;
using System.Windows.Forms;

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
            this.sharesTBox = new System.Windows.Forms.TextBox();
            this.tickerLabel = new System.Windows.Forms.Label();
            this.sharesLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.buyBtn = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.incBtn = new System.Windows.Forms.Button();
            this.decBtn = new System.Windows.Forms.Button();
            this.portValLabel = new System.Windows.Forms.Label();
            this.cashLabel = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.webTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.webBtn = new System.Windows.Forms.Button();
            this.changePortBtn = new System.Windows.Forms.Button();
            this.mkPortBtn = new System.Windows.Forms.Button();
            this.viewPortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tickerTBox
            // 
            this.tickerTBox.Location = new System.Drawing.Point(824, 74);
            this.tickerTBox.Name = "tickerTBox";
            this.tickerTBox.Size = new System.Drawing.Size(100, 20);
            this.tickerTBox.TabIndex = 0;
            this.tickerTBox.TextChanged += new System.EventHandler(this.tickerTBox_TextChanged);
            // 
            // sharesTBox
            // 
            this.sharesTBox.Location = new System.Drawing.Point(824, 114);
            this.sharesTBox.Name = "sharesTBox";
            this.sharesTBox.Size = new System.Drawing.Size(100, 20);
            this.sharesTBox.TabIndex = 1;
            this.sharesTBox.TextChanged += new System.EventHandler(this.sharesTBox_TextChanged);
            // 
            // tickerLabel
            // 
            this.tickerLabel.AutoSize = true;
            this.tickerLabel.Location = new System.Drawing.Point(783, 77);
            this.tickerLabel.Name = "tickerLabel";
            this.tickerLabel.Size = new System.Drawing.Size(37, 13);
            this.tickerLabel.TabIndex = 2;
            this.tickerLabel.Text = "Ticker";
            // 
            // sharesLabel
            // 
            this.sharesLabel.AutoSize = true;
            this.sharesLabel.Location = new System.Drawing.Point(756, 117);
            this.sharesLabel.Name = "sharesLabel";
            this.sharesLabel.Size = new System.Drawing.Size(62, 13);
            this.sharesLabel.TabIndex = 3;
            this.sharesLabel.Text = "# of Shares";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(25, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(111, 22);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "User Name";
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(793, 156);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(75, 23);
            this.buyBtn.TabIndex = 5;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.Location = new System.Drawing.Point(874, 156);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(75, 23);
            this.sellBtn.TabIndex = 6;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(25, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Portfolio Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cash:";
            // 
            // incBtn
            // 
            this.incBtn.Location = new System.Drawing.Point(940, 91);
            this.incBtn.Name = "incBtn";
            this.incBtn.Size = new System.Drawing.Size(29, 27);
            this.incBtn.TabIndex = 9;
            this.incBtn.UseVisualStyleBackColor = true;
            this.incBtn.Click += new System.EventHandler(this.incBtn_Click);
            // 
            // decBtn
            // 
            this.decBtn.Location = new System.Drawing.Point(940, 125);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(28, 25);
            this.decBtn.TabIndex = 10;
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // portValLabel
            // 
            this.portValLabel.AutoSize = true;
            this.portValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portValLabel.Location = new System.Drawing.Point(160, 72);
            this.portValLabel.Name = "portValLabel";
            this.portValLabel.Size = new System.Drawing.Size(18, 20);
            this.portValLabel.TabIndex = 11;
            this.portValLabel.Text = "$";
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.Location = new System.Drawing.Point(85, 105);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(27, 20);
            this.cashLabel.TabIndex = 12;
            this.cashLabel.Text = "$$";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser.Location = new System.Drawing.Point(0, 302);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1046, 541);
            this.webBrowser.TabIndex = 13;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // webTBox
            // 
            this.webTBox.Location = new System.Drawing.Point(67, 273);
            this.webTBox.Name = "webTBox";
            this.webTBox.Size = new System.Drawing.Size(125, 20);
            this.webTBox.TabIndex = 14;
            this.webTBox.TextChanged += new System.EventHandler(this.webTBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chart";
            // 
            // webBtn
            // 
            this.webBtn.Location = new System.Drawing.Point(198, 273);
            this.webBtn.Name = "webBtn";
            this.webBtn.Size = new System.Drawing.Size(54, 20);
            this.webBtn.TabIndex = 16;
            this.webBtn.Text = "Search";
            this.webBtn.UseVisualStyleBackColor = true;
            this.webBtn.Click += new System.EventHandler(this.webBtn_Click);
            // 
            // changePortBtn
            // 
            this.changePortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePortBtn.Location = new System.Drawing.Point(26, 154);
            this.changePortBtn.Name = "changePortBtn";
            this.changePortBtn.Size = new System.Drawing.Size(110, 26);
            this.changePortBtn.TabIndex = 17;
            this.changePortBtn.Text = "Change Portfolio";
            this.changePortBtn.UseVisualStyleBackColor = true;
            // 
            // mkPortBtn
            // 
            this.mkPortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkPortBtn.Location = new System.Drawing.Point(26, 186);
            this.mkPortBtn.Name = "mkPortBtn";
            this.mkPortBtn.Size = new System.Drawing.Size(110, 26);
            this.mkPortBtn.TabIndex = 18;
            this.mkPortBtn.Text = "Create Portfolio";
            this.mkPortBtn.UseVisualStyleBackColor = true;
            // 
            // viewPortBtn
            // 
            this.viewPortBtn.Location = new System.Drawing.Point(142, 155);
            this.viewPortBtn.Name = "viewPortBtn";
            this.viewPortBtn.Size = new System.Drawing.Size(110, 23);
            this.viewPortBtn.TabIndex = 19;
            this.viewPortBtn.Text = "View Portfolio";
            this.viewPortBtn.UseVisualStyleBackColor = true;
            // 
            // applicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1046, 843);
            this.Controls.Add(this.viewPortBtn);
            this.Controls.Add(this.mkPortBtn);
            this.Controls.Add(this.changePortBtn);
            this.Controls.Add(this.webBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.webTBox);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.portValLabel);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.incBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.sharesLabel);
            this.Controls.Add(this.tickerLabel);
            this.Controls.Add(this.sharesTBox);
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
        private System.Windows.Forms.TextBox sharesTBox;
        private System.Windows.Forms.Label tickerLabel;
        private System.Windows.Forms.Label sharesLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button incBtn;
        private System.Windows.Forms.Button decBtn;
        private System.Windows.Forms.Label portValLabel;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox webTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button webBtn;
        private Button changePortBtn;
        private Button mkPortBtn;
        private Button viewPortBtn;
    }
}