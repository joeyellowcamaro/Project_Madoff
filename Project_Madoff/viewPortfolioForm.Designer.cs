namespace Project_Madoff
{
    partial class viewPortfolioForm
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
            this.components = new System.ComponentModel.Container();
            this.portGrid = new System.Windows.Forms.DataGridView();
            this.portfolioTemplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.portGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioTemplateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // portGrid
            // 
            this.portGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portGrid.Location = new System.Drawing.Point(12, 12);
            this.portGrid.Name = "portGrid";
            this.portGrid.Size = new System.Drawing.Size(356, 300);
            this.portGrid.TabIndex = 0;
            // 
            // portfolioTemplateBindingSource
            // 
            this.portfolioTemplateBindingSource.DataSource = typeof(Project_Madoff.portfolioTemplate);
            // 
            // viewPortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 335);
            this.Controls.Add(this.portGrid);
            this.Name = "viewPortfolioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Madoff";
            this.Load += new System.EventHandler(this.viewPortfolioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioTemplateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView portGrid;
        private System.Windows.Forms.BindingSource portfolioTemplateBindingSource;
    }
}